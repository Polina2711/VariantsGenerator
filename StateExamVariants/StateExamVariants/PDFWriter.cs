using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StateExamVariants
{
    public class PDFWriter:IPDFWriter
    {
        public event Func<Dictionary<int, List<string[]>>> GetAllDict;

        public void AddToPDFFile(string filename)
        {
            var doc = new Document();
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
            doc.Open();

            foreach (var item in GetAllDict?.Invoke())
            {
                if(item.Key < 13)
                {
                    foreach (var array in item.Value)
                    {
                        doc.Add(new Paragraph(" ", font));

                        Assembly assembly = Assembly.GetExecutingAssembly();
                        Stream stream = assembly.GetManifestResourceStream("StateExamVariants.TaskNumPics.TaskPic" + item.Key + ".PNG");
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(stream);
                        doc.Add(img);

                        foreach (var strng in array)
                        {
                            if (strng.Count() != 0)
                            {
                                if (strng[0] != '/')
                                    doc.Add(new Paragraph(strng, font));
                                else
                                {
                                    var url = new Uri("http://mathege.ru" + strng);
                                    img = iTextSharp.text.Image.GetInstance(url);
                                    doc.Add(img);
                                }
                            }
                        }
                    }
                   
                }

                else
                {
                    foreach (var array in item.Value)
                    {
                        foreach (var strng in array)
                        {
                            var url = new Uri(strng);
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(url);

                            float scaler = ((doc.PageSize.Width - doc.LeftMargin
                                - doc.RightMargin) / img.Width) * 100;
                            img.ScalePercent(scaler);

                            doc.Add(img);
                        }
                    }
                }

            }

            doc.Close();
        }
    }
}

