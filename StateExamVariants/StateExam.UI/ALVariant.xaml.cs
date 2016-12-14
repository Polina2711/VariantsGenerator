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

    public partial class AlVariant : Window
    {
        public AlVariant()
        {
            InitializeComponent();
        }

        OutputFormer output = new OutputFormer();
        VariantGenerator varger = new VariantGenerator();

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
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task1button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(1);
        }

        private void Task2button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(2);
        }

        private void Task3button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(3);
        }

        private void Task4button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(4);
        }

        private void Task5button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(5);
        }

        private void Task6button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(6);
        }

        private void Task7button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(7);
        }

        private void Task8button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(8);
        }

        private void Task9button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(9);
        }

        private void Task10button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(10);
        }

        private void Task11button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(11);
        }

        private void Task12button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(12);
        }

        private void Task13button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(13);
        }

        private void Task14button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(14);
        }

        private void Task15button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(15);
        }

        private void Task16button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(16);
        }
    

        private void Task17button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(17);
        }

    private void Task18button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(18);
        }

        private void Task19button_Click(object sender, RoutedEventArgs e)
        {
            Outputer(19);
        }
    }
}
