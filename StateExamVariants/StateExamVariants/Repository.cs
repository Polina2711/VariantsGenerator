using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace StateExamVariants
{
    public class Repository
    {
        public static Dictionary<int, List<string[]>> tasks = new Dictionary<int, List<string[]>>();
        public void Generator(int tasknum, int numboftasks)
        {
            ParserFromMathege parser = new ParserFromMathege();
            List<string[]> onetask = new List<string[]>();
            while (numboftasks != 0)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Stream stream = assembly.GetManifestResourceStream("StateExamVariants.AL.Task"+tasknum+".txt");
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                List<string> tasknumbers = new List<string>();
                string taskn;
                while ((taskn = reader.ReadLine()) != null)
                {
                    tasknumbers.Add(taskn);
                }
                reader.Close();

                Random r = new Random();

                string [] result=parser.GetTask(int.Parse(tasknumbers[(r.Next(tasknumbers.Count))]));
                onetask.Add(result);
           
                numboftasks--;
            }
            tasks.Add(tasknum, onetask);
        }

        public List<string[]> GetTaskString(int taskid)
        {
            //var value = tasks.TryGetValue(taskid, out result);
            var result = tasks[taskid];
            return result;
        }
        public List<UIElement> Output(int taskid)
        {
            List<UIElement> outputstuff = new List<UIElement>();
            foreach (var stringarray in GetTaskString(taskid))
            {
                foreach (var item in stringarray)
                {
                    if (item.Count() != 0)
                    {
                        if (item[0] != '/')
                            outputstuff.Add(new TextBlock
                            {
                                Text = item,
                                Margin = new Thickness(5, 0, 0, 0),
                                VerticalAlignment = VerticalAlignment.Center
                            });
                        else
                        {
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.UriSource = new Uri("http://mathege.ru" + item, UriKind.Absolute);
                            image.EndInit();
                            outputstuff.Add(new Image
                            {
                                Source = image,
                                Margin = new Thickness(5, 0, 0, 0),
                                Width = 100,
                                Height = 40
                            });
                        }
                    }
                }
            }
            return outputstuff;
        }
        public void ClearTasks()
        {
            tasks.Clear();
        }
    }
}
