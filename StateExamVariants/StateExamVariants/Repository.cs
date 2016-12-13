using iTextSharp.text;
using iTextSharp.text.pdf;
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
                Stream stream = assembly.GetManifestResourceStream("StateExamVariants.AL.Task" + tasknum + ".txt");
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                List<string> tasknumbers = new List<string>();
                string taskn;
                while ((taskn = reader.ReadLine()) != null)
                {
                    tasknumbers.Add(taskn);
                }
                reader.Close();

                Random r = new Random();

                string[] result = parser.GetTask(int.Parse(tasknumbers[(r.Next(tasknumbers.Count))]));
                onetask.Add(result);

                numboftasks--;
            }
            tasks.Add(tasknum, onetask);
        }

        public List<string[]> GetTaskString(int taskid)
        {
            List<string[]> result = new List<string[]>();
            var check = tasks.TryGetValue(taskid, out result);
            return result;
        }

        public List<UIElement> Output(int taskid)
        {
            List<UIElement> outputstuff = new List<UIElement>();
            var result = GetTaskString(taskid);
            if (result == null)
                return null;
            else
            {
                foreach (var stringarray in result)
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
                                outputstuff.Add(new System.Windows.Controls.Image
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
        }
        public void ClearTasks()
        {
            tasks.Clear();
        }

        public void PDFWriter()
        {
            var doc = new Document();
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            PdfWriter.GetInstance(doc, new FileStream(@"\Users\ale\Documents\Visual Studio 2015\Projects\Document.pdf", FileMode.Create));
            doc.Open();

            foreach (var item in tasks)
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
