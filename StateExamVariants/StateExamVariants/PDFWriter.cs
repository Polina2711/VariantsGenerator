using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExamVariants
{
    public class PDFWriter
    {
        public event Func<Dictionary<int, List<string[]>>> GetAllDict;

        public void AddToPDFFile()
        {
            var doc = new Document();
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            PdfWriter.GetInstance(doc, new FileStream(@"\Users\ale\Documents\Visual Studio 2015\Projects\Document.pdf", FileMode.Create));
            doc.Open();

            foreach (var item in GetAllDict?.Invoke())
            {
                foreach (var array in item.Value)
                {
                    foreach (var strng in array)
                    {
                        if (strng.Count() != 0)
                        {
                            if (strng[0] != '/')
                                doc.Add(new Paragraph(strng, font));
                            else
                            {
                                var url = new Uri("http://mathege.ru" + strng);
                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(url);
                                doc.Add(img);
                            }
                        }
                    }
                }
            }

            doc.Close();
        }
    }
}

