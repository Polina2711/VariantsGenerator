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
            ParserFromMathege parser = new ParserFromMathege();
            try
            {
                if (levelcombobox.Text == "Advanced")
                {
                    IVariantGenerator varger = Factory.Default.GetVarientGenerator();
                    varger.GetTaskProblem += parser.GetTask;

                    varger.ClearDict();

                    if (task1checkbox.IsChecked == true)
                    {
                        if (task1comboBox.Text!="")
                            varger.Generator(1, int.Parse(task1comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 1");
                    }
                    if (task2checkbox.IsChecked == true)
                    {
                        if (task2comboBox.Text != "")
                            varger.Generator(2, int.Parse(task2comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 2");
                    }
                    if (task3checkbox.IsChecked == true)
                    {
                        if (task3comboBox.Text != "")
                            varger.Generator(3, int.Parse(task3comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 3");
                    }
                    if (task4checkbox.IsChecked == true)
                    {
                        if (task4comboBox.Text != "")
                            varger.Generator(4, int.Parse(task4comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 4");
                    }
                    if (task5checkbox.IsChecked == true)
                    {
                        if (task5comboBox.Text != "")
                            varger.Generator(5, int.Parse(task5comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 5");
                    }
                    if (task6checkbox.IsChecked == true)
                    {
                        if (task6comboBox.Text != "")
                            varger.Generator(6, int.Parse(task6comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 6");
                    }
                    if (task7checkbox.IsChecked == true)
                    {
                        if (task7comboBox.Text != "")
                            varger.Generator(7, int.Parse(task7comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 7");
                    }
                    if (task8checkbox.IsChecked == true)
                    {
                        if (task8comboBox.Text != "")
                            varger.Generator(8, int.Parse(task8comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 8");
                    }
                    if (task9checkbox.IsChecked == true)
                    {
                        if (task9comboBox.Text != "")
                            varger.Generator(9, int.Parse(task9comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 9");
                    }
                    if (task10checkbox.IsChecked == true)
                    {
                        if (task10comboBox.Text != "")
                            varger.Generator(10, int.Parse(task10comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 10");
                    }
                    if (task11checkbox.IsChecked == true)
                    {
                        if (task11comboBox.Text != "")
                            varger.Generator(11, int.Parse(task11comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 11");
                    }
                    if (task12checkbox.IsChecked == true)
                    {
                        if (task12comboBox.Text != "")
                            varger.Generator(12, int.Parse(task12comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 12");
                    }
                    if (task13checkbox.IsChecked == true)
                    {
                        if (task13comboBox.Text != "")
                            varger.Generator(13, int.Parse(task13comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 13");
                    }
                    if (task14checkbox.IsChecked == true)
                    {
                        if (task14comboBox.Text != "")
                            varger.Generator(14, int.Parse(task14comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 14");
                    }
                    if (task15checkbox.IsChecked == true)
                    {
                        if (task15comboBox.Text != "")
                            varger.Generator(15, int.Parse(task15comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 15");
                    }
                    if (task16checkbox.IsChecked == true)
                    {
                        if (task16comboBox.Text != "")
                            varger.Generator(16, int.Parse(task16comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 16");
                    }
                    if (task17checkbox.IsChecked == true)
                    {
                        if (task17comboBox.Text != "")
                            varger.Generator(17, int.Parse(task17comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 17");
                    }
                    if (task18checkbox.IsChecked == true)
                    {
                        if (task18comboBox.Text != "")
                            varger.Generator(18, int.Parse(task18comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 18");
                    }
                    if (task19checkbox.IsChecked == true)
                    {
                        if (task19comboBox.Text != "")
                            varger.Generator(19, int.Parse(task19comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 19");
                    }
                    if (task20checkbox.IsChecked == true)
                    {
                        if (task20comboBox.Text != "")
                            varger.Generator(20, int.Parse(task20comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 20");
                    }

                    AlVariant window = new AlVariant();

                    Dictionary<int, List<string[]>> dict = varger.GetDict();
                    List<string[]> list = new List<string[]>();

                    if (dict.TryGetValue(1, out list) == false)
                        window.Task1button.IsEnabled = false;
                    if (dict.TryGetValue(2, out list) == false)
                        window.Task2button.IsEnabled = false;
                    if (dict.TryGetValue(3, out list) == false)
                        window.Task3button.IsEnabled = false;
                    if (dict.TryGetValue(4, out list) == false)
                        window.Task4button.IsEnabled = false;
                    if (dict.TryGetValue(5, out list) == false)
                        window.Task5button.IsEnabled = false;
                    if (dict.TryGetValue(6, out list) == false)
                        window.Task6button.IsEnabled = false;
                    if (dict.TryGetValue(7, out list) == false)
                        window.Task7button.IsEnabled = false;
                    if (dict.TryGetValue(8, out list) == false)
                        window.Task8button.IsEnabled = false;
                    if (dict.TryGetValue(9, out list) == false)
                        window.Task9button.IsEnabled = false;
                    if (dict.TryGetValue(10, out list) == false)
                        window.Task10button.IsEnabled = false;
                    if (dict.TryGetValue(11, out list) == false)
                        window.Task11button.IsEnabled = false;
                    if (dict.TryGetValue(12, out list) == false)
                        window.Task12button.IsEnabled = false;
                    if (dict.TryGetValue(13, out list) == false)
                        window.Task13button.IsEnabled = false;
                    if (dict.TryGetValue(14, out list) == false)
                        window.Task14button.IsEnabled = false;
                    if (dict.TryGetValue(15, out list) == false)
                        window.Task15button.IsEnabled = false;
                    if (dict.TryGetValue(16, out list) == false)
                        window.Task16button.IsEnabled = false;
                    if (dict.TryGetValue(17, out list) == false)
                        window.Task17button.IsEnabled = false;
                    if (dict.TryGetValue(18, out list) == false)
                        window.Task18button.IsEnabled = false;
                    if (dict.TryGetValue(19, out list) == false)
                        window.Task19button.IsEnabled = false;

                    window.Show();
                }
            

            else if (levelcombobox.Text == "Base")
            {
                IVariantGenerator varger = Factory.Default.GetBaseVarientGenerator();
                varger.GetTaskProblem += parser.GetBaseTask;

                varger.ClearDict();

                    if (task1checkbox.IsChecked == true)
                    {
                        if (task1comboBox.Text != "")
                            varger.Generator(1, int.Parse(task1comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 1");
                    }
                    if (task2checkbox.IsChecked == true)
                    {
                        if (task2comboBox.Text != "")
                            varger.Generator(2, int.Parse(task2comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 2");
                    }
                    if (task3checkbox.IsChecked == true)
                    {
                        if (task3comboBox.Text != "")
                            varger.Generator(3, int.Parse(task3comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 3");
                    }
                    if (task4checkbox.IsChecked == true)
                    {
                        if (task4comboBox.Text != "")
                            varger.Generator(4, int.Parse(task4comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 4");
                    }
                    if (task5checkbox.IsChecked == true)
                    {
                        if (task5comboBox.Text != "")
                            varger.Generator(5, int.Parse(task5comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 5");
                    }
                    if (task6checkbox.IsChecked == true)
                    {
                        if (task6comboBox.Text != "")
                            varger.Generator(6, int.Parse(task6comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 6");
                    }
                    if (task7checkbox.IsChecked == true)
                    {
                        if (task7comboBox.Text != "")
                            varger.Generator(7, int.Parse(task7comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 7");
                    }
                    if (task8checkbox.IsChecked == true)
                    {
                        if (task8comboBox.Text != "")
                            varger.Generator(8, int.Parse(task8comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 8");
                    }
                    if (task9checkbox.IsChecked == true)
                    {
                        if (task9comboBox.Text != "")
                            varger.Generator(9, int.Parse(task9comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 9");
                    }
                    if (task10checkbox.IsChecked == true)
                    {
                        if (task10comboBox.Text != "")
                            varger.Generator(10, int.Parse(task10comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 10");
                    }
                    if (task11checkbox.IsChecked == true)
                    {
                        if (task11comboBox.Text != "")
                            varger.Generator(11, int.Parse(task11comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 11");
                    }
                    if (task12checkbox.IsChecked == true)
                    {
                        if (task12comboBox.Text != "")
                            varger.Generator(12, int.Parse(task12comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 12");
                    }
                    if (task13checkbox.IsChecked == true)
                    {
                        if (task13comboBox.Text != "")
                            varger.Generator(13, int.Parse(task13comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 13");
                    }
                    if (task14checkbox.IsChecked == true)
                    {
                        if (task14comboBox.Text != "")
                            varger.Generator(14, int.Parse(task14comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 14");
                    }
                    if (task15checkbox.IsChecked == true)
                    {
                        if (task15comboBox.Text != "")
                            varger.Generator(15, int.Parse(task15comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 15");
                    }
                    if (task16checkbox.IsChecked == true)
                    {
                        if (task16comboBox.Text != "")
                            varger.Generator(16, int.Parse(task16comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 16");
                    }
                    if (task17checkbox.IsChecked == true)
                    {
                        if (task17comboBox.Text != "")
                            varger.Generator(17, int.Parse(task17comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 17");
                    }
                    if (task18checkbox.IsChecked == true)
                    {
                        if (task18comboBox.Text != "")
                            varger.Generator(18, int.Parse(task18comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 18");
                    }
                    if (task19checkbox.IsChecked == true)
                    {
                        if (task19comboBox.Text != "")
                            varger.Generator(19, int.Parse(task19comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 19");
                    }
                    if (task20checkbox.IsChecked == true)
                    {
                        if (task20comboBox.Text != "")
                            varger.Generator(20, int.Parse(task20comboBox.Text));
                        else throw new ArgumentException("Select the quantity of exercise 20");
                    }

                    BLVariant window = new BLVariant();
                Dictionary<int, List<string[]>> dict = varger.GetDict();
                List<string[]> list = new List<string[]>();

                if (dict.TryGetValue(1, out list) == false)
                    window.basetask1button.IsEnabled = false;
                if (dict.TryGetValue(2, out list) == false)
                    window.basetask2button.IsEnabled = false;
                if (dict.TryGetValue(3, out list) == false)
                    window.basetask3button.IsEnabled = false;
                if (dict.TryGetValue(4, out list) == false)
                    window.basetask4button.IsEnabled = false;
                if (dict.TryGetValue(5, out list) == false)
                    window.basetask5button.IsEnabled = false;
                if (dict.TryGetValue(6, out list) == false)
                    window.basetask6button.IsEnabled = false;
                if (dict.TryGetValue(7, out list) == false)
                    window.basetask7button.IsEnabled = false;
                if (dict.TryGetValue(8, out list) == false)
                    window.basetask8button.IsEnabled = false;
                if (dict.TryGetValue(9, out list) == false)
                    window.basetask9button.IsEnabled = false;
                if (dict.TryGetValue(10, out list) == false)
                    window.basetask10button.IsEnabled = false;
                if (dict.TryGetValue(11, out list) == false)
                    window.basetask11button.IsEnabled = false;
                if (dict.TryGetValue(12, out list) == false)
                    window.basetask12button.IsEnabled = false;
                if (dict.TryGetValue(13, out list) == false)
                    window.basetask13button.IsEnabled = false;
                if (dict.TryGetValue(14, out list) == false)
                    window.basetask14button.IsEnabled = false;
                if (dict.TryGetValue(15, out list) == false)
                    window.basetask15button.IsEnabled = false;
                if (dict.TryGetValue(16, out list) == false)
                    window.basetask16button.IsEnabled = false;
                if (dict.TryGetValue(17, out list) == false)
                    window.basetask17button.IsEnabled = false;
                if (dict.TryGetValue(18, out list) == false)
                    window.basetask18button.IsEnabled = false;
                if (dict.TryGetValue(19, out list) == false)
                    window.basetask19button.IsEnabled = false;
                if (dict.TryGetValue(20, out list) == false)
                    window.basetask20button.IsEnabled = false;

                window.Show();
            }

            else
                MessageBox.Show("Choose the level of the variant", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A handled exception was occured:\n" + ex.Message, "Oops...", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void levelcombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (levelcombobox.SelectedIndex > -1 &&
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
                task19checkbox.IsChecked == true ||
                task20checkbox.IsChecked == true))
            {
                generator.IsEnabled = true;
            }
        }

        public void GeneratorButtonEnable(bool? checkbox, int combobox, int level)
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

        private void task20checkbox_Checked(object sender, RoutedEventArgs e)
        {
            GeneratorButtonEnable(task20checkbox.IsChecked, task20comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }



        private void task1comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task1checkbox.IsChecked, task1comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task2comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task2checkbox.IsChecked, task2comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task3comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task3checkbox.IsChecked, task3comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task4comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task4checkbox.IsChecked, task4comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task5comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task5checkbox.IsChecked, task5comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task6comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task6checkbox.IsChecked, task6comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task7comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task7checkbox.IsChecked, task7comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task8comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task8checkbox.IsChecked, task8comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task9comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task9checkbox.IsChecked, task9comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task10comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task10checkbox.IsChecked, task10comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task11comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task11checkbox.IsChecked, task11comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task12comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task12checkbox.IsChecked, task12comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task13comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task13checkbox.IsChecked, task13comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task14comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task14checkbox.IsChecked, task14comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task15comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task15checkbox.IsChecked, task15comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task16comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task16checkbox.IsChecked, task16comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task17comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task17checkbox.IsChecked, task17comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task18comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task18checkbox.IsChecked, task18comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task19comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task19checkbox.IsChecked, task19comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }

        private void task20comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneratorButtonEnable(task20checkbox.IsChecked, task20comboBox.SelectedIndex, levelcombobox.SelectedIndex);
        }
    }
}
