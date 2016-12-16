using StateExamVariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StateExam.UI
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class BLVariant : Window
    {
        
        public BLVariant()
            {
                InitializeComponent();
            }

            IOutputFormer output = Factory.Default.GetBaseOutputFormer();
            IVariantGenerator varger = Factory.Default.GetBaseVarientGenerator();

            public void Outputer(int taskid)
            {
                output.GetValueFromDict += varger.GetValueByKeyFromDict;
                Exercise window = new Exercise();
                window.Show();
                window.listBox.Items.Add(taskid);
                List<UIElement> result = output.FormOutputText(taskid);
                if (result == null)
                    return;
                else
                {
                    foreach (var item in result)
                    {
                        window.outputListbox.Items.Add(item);
                    }
                }
                output.GetValueFromDict -= varger.GetValueByKeyFromDict;
            }

            private void basetask1button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(1);
            }

            private void basetask2button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(2);
            }

            private void basetask3button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(3);
            }

            private void basetask4button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(4);
            }

            private void basetask5button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(5);
            }

            private void basetask6button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(6);
            }

            private void basetask7button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(7);
            }

            private void basetask8button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(8);
            }

            private void basetask9button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(9);
            }

            private void basetask10button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(10);
            }

            private void basetask11button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(11);
            }

            private void basetask12button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(12);
            }

            private void basetask13button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(13);
            }

            private void basetask14button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(14);
            }

            private void basetask15button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(15);
            }

            private void basetask16button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(16);
            }

            private void basetask17button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(17);
            }

            private void basetask18button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(18);
            }

            private void basetask19button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(19);
            }

            private void basetask20button_Click(object sender, RoutedEventArgs e)
            {
                Outputer(20);
            }
        }
    }
  