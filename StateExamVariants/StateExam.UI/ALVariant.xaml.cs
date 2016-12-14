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

        private void Task1button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("1");
            List<UIElement> result = output.FormOutputText(1);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task2button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("2");
            List<UIElement> result = output.FormOutputText(2);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task3button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("3");
            List<UIElement> result = output.FormOutputText(3);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task4button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("4");
            List<UIElement> result = output.FormOutputText(4);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task5button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("5");
            List<UIElement> result = output.FormOutputText(5);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task6button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("6");
            List<UIElement> result = output.FormOutputText(6);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task7button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("7");
            List<UIElement> result = output.FormOutputText(7);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task8button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("8");
            List<UIElement> result = output.FormOutputText(8);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task9button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("9");
            List<UIElement> result = output.FormOutputText(9);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task10button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("10");
            List<UIElement> result = output.FormOutputText(10);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task11button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("11");
            List<UIElement> result = output.FormOutputText(11);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task12button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("12");
            List<UIElement> result = output.FormOutputText(12);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task13button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("13");
            List<UIElement> result = output.FormOutputText(13);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task14button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("14");
            List<UIElement> result = output.FormOutputText(14);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task15button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("15");
            List<UIElement> result = output.FormOutputText(15);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task16button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("16");
            List<UIElement> result = output.FormOutputText(16);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }
    

        private void Task17button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("17");
            List<UIElement> result = output.FormOutputText(17);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

    private void Task18button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("18");
            List<UIElement> result = output.FormOutputText(18);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }

        private void Task19button_Click(object sender, RoutedEventArgs e)
        {
            output.GetValueFromDict += varger.GetValueByKeyFromDict;
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("19");
            List<UIElement> result = output.FormOutputText(19);
            if (result == null)
                return;
            else
            {
                foreach (var item in result)
                    window.outputStackPanel.Children.Add(item);
            }
            output.GetValueFromDict -= varger.GetValueByKeyFromDict;
        }
    }
}
