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
   
        class BaseOutputFormer : IOutputFormer
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

                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Stream stream = assembly.GetManifestResourceStream("StateExamVariants.TaskNumPics.TaskPic" + taskid + ".PNG");

                    BitmapSource source = null;
                    PngBitmapDecoder decoder;
                    using (stream)
                    {
                        decoder = new PngBitmapDecoder(stream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.None);

                        if (decoder.Frames != null && decoder.Frames.Count > 0)
                            source = decoder.Frames[0];
                    }

                    outputstuff.Add(new System.Windows.Controls.Image
                    {
                        Source = source,
                        Margin = new Thickness(5, 0, 0, 0),
                        Width = 60
                    });

                    foreach (var item in stringarray)
                        {
                            if (item.Count() != 0)
                            {
                                if (!item.Equals(""))
                                {
                                    BitmapImage image = new BitmapImage();
                                    image.BeginInit();
                                    image.UriSource = new Uri(item, UriKind.Absolute);
                                    image.EndInit();
                                    outputstuff.Add(new System.Windows.Controls.Image
                                    {
                                        Source = image,
                                        Margin = new Thickness(5, 0, 0, 0),
                                        Width = 542
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

