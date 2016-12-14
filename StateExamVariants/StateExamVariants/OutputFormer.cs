using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace StateExamVariants
{
    public class OutputFormer
    {
        public event Func<int, List<string[]>> GetValueFromDict;

        public List<UIElement> FormOutputText(int taskid)
        {
            List<UIElement> outputstuff = new List<UIElement>();
            var result = GetValueFromDict?.Invoke(taskid);
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
    }
}
