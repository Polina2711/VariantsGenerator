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
    public class BasePDFWriter:IPDFWriter
    {
        public event Func<Dictionary<int, List<string[]>>> GetAllDict;

        public void AddToPDFFile(string filename)
        {
            var doc = new Document();
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            var pdf=PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
            pdf.StrictImageSequence = true;

            doc.Open();
            

            foreach (var item in GetAllDict?.Invoke())
            {
                foreach (var array in item.Value)
                {
                    foreach (var strng in array)
                    {
                        doc.Add(new Paragraph(" ", font));

                        Assembly assembly = Assembly.GetExecutingAssembly();
                        Stream stream = assembly.GetManifestResourceStream("StateExamVariants.TaskNumPics.TaskPic" + item.Key + ".PNG");
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(stream);
                        doc.Add(img);

                        var url = new Uri(strng);
                        img = iTextSharp.text.Image.GetInstance(url);

                        float scaler = ((doc.PageSize.Width - doc.LeftMargin
                                - doc.RightMargin) / img.Width) * 100;
                        img.ScalePercent(scaler);

                        doc.Add(img);
                    }
                }
            }

            doc.Close();
        }
    }
}
