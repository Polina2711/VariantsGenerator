using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsers
{
    class PDFWriter
    {
        public void CreatePDF(string [] oue, HtmlNodeCollection c)
        {
            var doc = new Document();
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            PdfWriter.GetInstance(doc, new FileStream(@"\Users\ale\Documents\Visual Studio 2015\Projects\Document.pdf", FileMode.Create));
            doc.Open();
            for (int i = 0; i < 2; i++)
            {
                oue[i] = c[i].ParentNode.InnerText;

                oue[i] = oue[i].Replace("&shy;", null);
                oue[i] = oue[i].Replace("&nbsp;&nbsp;", "*");
                oue[i] = oue[i].Replace("&nbsp;", "");
                oue[i] = oue[i].Replace("&mdash;", "");
                oue[i] = oue[i].Replace("&minus;", "-");
                var addition = oue[i];

                doc.Add(new Paragraph(addition,font));
            }
            doc.Close();
        }
    }
}
