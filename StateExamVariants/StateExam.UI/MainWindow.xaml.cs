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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StateExam.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generator_Click(object sender, RoutedEventArgs e)
        {
            pdf.IsEnabled = true;
            VariantGenerator varger = new VariantGenerator();
            ParserFromMathege parser = new ParserFromMathege();
            varger.GetTaskProblem += parser.GetTask;

            if (levelcombobox.Text == "Advanced")
            {
                varger.ClearDict();

                if (task1checkbox.IsChecked == true)
                {
                    varger.Generator(1, int.Parse(task1comboBox.Text));
                }
                if (task2checkbox.IsChecked == true)
                {
                    varger.Generator(2, int.Parse(task2comboBox.Text));
                }
                if (task3checkbox.IsChecked == true)
                {
                    varger.Generator(3, int.Parse(task3comboBox.Text));
                }
                if (task4checkbox.IsChecked == true)
                {
                    varger.Generator(4, int.Parse(task4comboBox.Text));
                }
                if (task5checkbox.IsChecked == true)
                {
                    varger.Generator(5, int.Parse(task5comboBox.Text));
                }
                if (task6checkbox.IsChecked == true)
                {
                    varger.Generator(6, int.Parse(task6comboBox.Text));
                }
                if (task7checkbox.IsChecked == true)
                {
                    varger.Generator(7, int.Parse(task7comboBox.Text));
                }
                if (task8checkbox.IsChecked == true)
                {
                    varger.Generator(8, int.Parse(task8comboBox.Text));
                }
                if (task9checkbox.IsChecked == true)
                {
                    varger.Generator(9, int.Parse(task9comboBox.Text));
                }
                if (task10checkbox.IsChecked == true)
                {
                    varger.Generator(10, int.Parse(task10comboBox.Text));
                }
                if (task11checkbox.IsChecked == true)
                {
                    varger.Generator(11, int.Parse(task11comboBox.Text));
                }
                if (task12checkbox.IsChecked == true)
                {
                    varger.Generator(12, int.Parse(task12comboBox.Text));
                }
                if (task13checkbox.IsChecked == true)
                {
                    varger.Generator(13, int.Parse(task13comboBox.Text));
                }
                if (task14checkbox.IsChecked == true)
                {
                    varger.Generator(14, int.Parse(task14comboBox.Text));
                }
                if (task15checkbox.IsChecked == true)
                {
                    varger.Generator(15, int.Parse(task15comboBox.Text));
                }
                if (task16checkbox.IsChecked == true)
                {
                    varger.Generator(16, int.Parse(task16comboBox.Text));
                }
                if (task17checkbox.IsChecked == true)
                {
                    varger.Generator(17, int.Parse(task17comboBox.Text));
                }
                if (task18checkbox.IsChecked == true)
                {
                    varger.Generator(18, int.Parse(task18comboBox.Text));
                }
                if (task19checkbox.IsChecked == true)
                {
                    varger.Generator(19, int.Parse(task19comboBox.Text));
                }

                AlVariant window = new AlVariant();
                window.Show();
            }

            else if (levelcombobox.Text == "Base")
            { }

            else
                MessageBox.Show("Choose the level of the variant", "Error");
        }

        private void pdf_Click(object sender, RoutedEventArgs e)
        {
            PDFWriter pdf = new PDFWriter();
            VariantGenerator varger = new VariantGenerator();
            pdf.GetAllDict += varger.GetDict;
            pdf.AddToPDFFile();
            MessageBox.Show("Tasks have been added to a PDF file", "Notification");
        }

        private void levelcombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (levelcombobox.SelectedIndex>-1&&
                (task1checkbox.IsChecked == true ||
                task2checkbox.IsChecked == true ||
                task3checkbox.IsChecked == true ||
                task4checkbox.IsChecked == true ||
                task5checkbox.IsChecked == true ||
                task6checkbox.IsChecked == true ||
                task7checkbox.IsChecked == true ||
                task8checkbox.IsChecked == true ||
                task9checkbox.IsChecked == true ||
                task10checkbox.IsChecked == true ||
                task11checkbox.IsChecked == true ||
                task12checkbox.IsChecked == true ||
                task13checkbox.IsChecked == true ||
                task14checkbox.IsChecked == true ||
                task15checkbox.IsChecked == true ||
                task16checkbox.IsChecked == true ||
                task17checkbox.IsChecked == true ||
                task18checkbox.IsChecked == true ||
                task19checkbox.IsChecked == true))
            {
                generator.IsEnabled = true;
            }
        }

        public void GeneratorButtonEnable (bool? checkbox, int combobox, int level)
        {
            if (checkbox == true && combobox > -1 && level > -1)
                generator.IsEnabled = true;
        }
        private void task1checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task1checkbox.IsChecked, task1comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task2checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task2checkbox.IsChecked, task2comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task3checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task3checkbox.IsChecked, task3comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task4checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task4checkbox.IsChecked, task4comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task5checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task5checkbox.IsChecked, task5comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task6checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task6checkbox.IsChecked, task6comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task7checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task7checkbox.IsChecked, task7comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task8checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task8checkbox.IsChecked, task8comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task9checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task9checkbox.IsChecked, task9comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task10checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task10checkbox.IsChecked, task10comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task11checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task11checkbox.IsChecked, task11comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task12checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task12checkbox.IsChecked, task12comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task13checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task13checkbox.IsChecked, task13comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task14checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task14checkbox.IsChecked, task14comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task15checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task15checkbox.IsChecked, task15comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task16checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task16checkbox.IsChecked, task16comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task17checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task17checkbox.IsChecked, task17comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task18checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task18checkbox.IsChecked, task18comboBox.SelectedIndex, levelcombobox.SelectedIndex);

        }

        private void task19checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task19checkbox.IsChecked, task19comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }
    }
}
