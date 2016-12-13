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
            Repository repo = new Repository();
            if (levelcombobox.Text=="Advanced")
            {
                repo.ClearTasks();
                if (task1checkbox.IsChecked == true)
                {
                    repo.Generator(1, int.Parse(task1comboBox.Text));
                }
                if (task2checkbox.IsChecked == true)
                {
                    repo.Generator(2, int.Parse(task2comboBox.Text));
                }
                if (task3checkbox.IsChecked == true)
                {
                    repo.Generator(3, int.Parse(task3comboBox.Text));
                }
                if (task4checkbox.IsChecked == true)
                {
                    repo.Generator(4, int.Parse(task4comboBox.Text));
                }
                if (task5checkbox.IsChecked == true)
                {
                    repo.Generator(5, int.Parse(task5comboBox.Text));
                }
                if (task6checkbox.IsChecked == true)
                {
                    repo.Generator(6, int.Parse(task6comboBox.Text));
                }
                if (task7checkbox.IsChecked == true)
                {
                    repo.Generator(7, int.Parse(task7comboBox.Text));
                }
                if (task8checkbox.IsChecked == true)
                {
                    repo.Generator(8, int.Parse(task8comboBox.Text));
                }
                if (task9checkbox.IsChecked == true)
                {
                    repo.Generator(9, int.Parse(task9comboBox.Text));
                }
                if (task10checkbox.IsChecked == true)
                {
                    repo.Generator(10, int.Parse(task10comboBox.Text));
                }
                if (task11checkbox.IsChecked == true)
                {
                    repo.Generator(11, int.Parse(task11comboBox.Text));
                }
                if (task12checkbox.IsChecked == true)
                {
                    repo.Generator(12, int.Parse(task12comboBox.Text));
                }
                if (task13checkbox.IsChecked == true)
                {
                    repo.Generator(13, int.Parse(task13comboBox.Text));
                }
                if (task14checkbox.IsChecked == true)
                {
                    repo.Generator(14, int.Parse(task14comboBox.Text));
                }
                if (task15checkbox.IsChecked == true)
                {
                    repo.Generator(15, int.Parse(task15comboBox.Text));
                }
                if (task16checkbox.IsChecked == true)
                {
                    repo.Generator(16, int.Parse(task16comboBox.Text));
                }
                if (task17checkbox.IsChecked == true)
                {
                    repo.Generator(17, int.Parse(task17comboBox.Text));
                }
                if (task18checkbox.IsChecked == true)
                {
                    repo.Generator(18, int.Parse(task18comboBox.Text));
                }
                if (task19checkbox.IsChecked == true)
                {
                    repo.Generator(19, int.Parse(task19comboBox.Text));
                }

                AlVariant window = new AlVariant();
                window.Show();
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void pdf_Click(object sender, RoutedEventArgs e)
        {
            Repository repo = new Repository();
            repo.PDFWriter();
        }
    }
}
