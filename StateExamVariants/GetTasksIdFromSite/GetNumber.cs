using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetTasksIdFromSite
{
    class GetNumber
    {

        public string[] GetNumberOfBaseTask()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Николай Саныч\Source\Repos\VariantsGenerator\StateExamVariants\GetTasksIdFromSite\BaseTasks\TextFileBase.txt");
            string uri = "http://base.mathege.ru/";
            string html;
            html = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(uri);
            string target = html.Replace("\n", "")
                                .Replace("\"", "");
            Regex reg_doc = new Regex(@"<.*?taskid=");
            var target2 = reg_doc.Replace(target, "");
            Regex reg_task = new Regex(@"var taskShowWindow.*?taskid=");
            var target3 = reg_task.Replace(target2, "");
            Regex reg_script = new Regex(@"</script>.*</html>");
            var target4 = reg_script.Replace(target3, "");
            Regex reg_t = new Regex(@";\t\t\t\t\t");
            var target5 = reg_t.Replace(target4, "");
            Regex reg_tzp = new Regex(@";");
            var target6 = reg_tzp.Replace(target5, "");
            string[] basetasks = target6.Split(')');
            foreach (var item in basetasks)
            {
                sw.WriteLine(item);
            }
            sw.Close();
            return basetasks;
        }

        public void GetNumberOfTask()
        {
            StreamWriter[] streamwriter = new StreamWriter[12];
            string[] tasklist = new string[12];
            for (int i = 0; i < 12; i++)
            {
                var number = i + 1;
                var path = @"C:\Users\Николай Саныч\Source\Repos\VariantsGenerator\StateExamVariants\GetTasksIdFromSite\AdvTasks\Task" + number + ".txt";
                streamwriter[i] = new StreamWriter(path);
                tasklist[i] = "Задание " + number + "";
            }

            for (int i = 2459; i < 77266; i++)
            {
                string uri = "http://mathege.ru/or/ege10/ShowProblem.html?probId=" + i + "&print=yes";
                string html;
                html = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(uri);
                string target = html.Replace("\n", "")
                                    .Replace("\"", "");

                if (!target.Contains("Указанное задание не существует или недоступно"))
                {
                    for (int k = 1; k < 12; k++)
                    {
                        if (target.Contains(tasklist[k])) streamwriter[k].WriteLine(i);
                    }
                    if (target.Contains("Задание 1") && !target.Contains("Задание 10") && !target.Contains("Задание 11") && !target.Contains("Задание 12")) streamwriter[0].WriteLine(i);
                    Console.WriteLine(i + "ok");
                }
                else { Console.WriteLine(i); }
            }

            for (int i = 0; i < 12; i++)
            {
                streamwriter[i].Close();
            }

            Console.ReadLine();

        }

    }
}
