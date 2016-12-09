using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Parsers
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(getRequest("https://ege.sdamgia.ru/problem?id=26623&print=true"));
            //HtmlNodeCollection c = doc.DocumentNode.SelectNodes("//p[@class='left_margin']");
            doc.LoadHtml(getRequest("https://ege.sdamgia.ru/problem?id=26691&print=true"));
            HtmlNodeCollection c = doc.DocumentNode.SelectNodes("//p[@class='left_margin']");
            string[] oue = new string[c.Count];

            PDFWriter pdf = new PDFWriter();
            pdf.CreatePDF(oue,c);

            //for (int i = 0; i < 2; i++)
            //{
            //    oue[i] = c[i].ParentNode.InnerText;

            //    oue[i] = oue[i].Replace("&shy;", null);
            //    oue[i] = oue[i].Replace("&nbsp;&nbsp;", "*");
            //    oue[i] = oue[i].Replace("&nbsp;", "");
            //    oue[i] = oue[i].Replace("&mdash;", "");
            //    oue[i] = oue[i].Replace("&minus;", "-");
            //    Console.WriteLine(oue[i]);
            //}
            //Console.ReadLine();
        }

        public static string getRequest(string url)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.AllowAutoRedirect = false;//Запрещаем автоматический редирект
                httpWebRequest.Method = "GET"; //Можно не указывать, по умолчанию используется GET.
                httpWebRequest.Referer = "http://google.com"; // Реферер. Тут можно указать любой URL
                using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var stream = httpWebResponse.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.GetEncoding(httpWebResponse.CharacterSet)))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
            catch
            {
                return String.Empty;
            }
        }
    }
}
