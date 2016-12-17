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
    public class OutputFormer:IOutputFormer
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
                    outputstuff.Add(new TextBlock
                    {
                        Text = "",
                        Margin = new Thickness(5, 0, 0, 0),
                        VerticalAlignment = VerticalAlignment.Center
                    });
                    outputstuff.Add(new TextBlock
                    {
                        Text=string.Format("№" + taskid),
                        Margin=new Thickness(5,0,0,0),
                        VerticalAlignment=VerticalAlignment.Center
                    });
                   
                    foreach (var item in stringarray)
                    {
                        if (item.Count() != 0)
                        {
                            if (!item.Equals(""))
                            {
                                if (taskid < 13)
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

                                else
                                {
                                    BitmapImage image = new BitmapImage();
                                    image.BeginInit();
                                    image.UriSource = new Uri(item, UriKind.Absolute);
                                    image.EndInit();
                                    outputstuff.Add(new System.Windows.Controls.Image
                                    {
                                        Source = image,
                                        Margin = new Thickness(5, 0, 0, 0),
                                        Width = 650
                                    });
                                }
                            }
                        }
                    }
                }
                return outputstuff;
            }
        }
    }
}
