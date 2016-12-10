using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StateExamVariants
{
    class ParserFromMathege
    {
        public static string[] GetTask(int n)
        {
            string uri = "http://mathege.ru/or/ege10/ShowProblem.html?probId=" + n + "&print=yes";
            string html;
            html = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(uri);
            string target = html.Replace("\n", "")
                                .Replace("\"", "");
            Regex reg_p = new Regex(@"<p>.*</p>");
            Regex reg_alt = new Regex(@"alt=.*?/>");
            string[] stringSeparators = new string[] { "</p><p>" };
            var HtmlToString = reg_p.Match(target).ToString();
            var TaskParts = HtmlToString.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            var TaskString = reg_alt.Replace(TaskParts[0], "|");
            TaskString = TaskString.Replace("<p>", "")
                            .Replace("<i>", "")
                            .Replace("</i>", "")
                            .Replace("<img src=", "|")
                            .Replace("</p>", "");
            var FinalTask = TaskString.Split('|');
            if (TaskParts.Length == 2)
            {
                Regex reg_img = new Regex(@"<img.*src=");
                var SecondPart = reg_img.Replace(TaskParts[1], "");
                SecondPart = SecondPart.Replace("/></p>", "");
                Array.Resize(ref FinalTask, FinalTask.Length + 1);
                FinalTask[FinalTask.Length - 1] = SecondPart;
            }
            return FinalTask;
        }
    }
}
