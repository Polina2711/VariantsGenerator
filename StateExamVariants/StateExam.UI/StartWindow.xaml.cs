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
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void BaseGenerator_Click(object sender, RoutedEventArgs e)
        {
            ParserFromMathege parser = new ParserFromMathege();
            IVariantGenerator varger = Factory.Default.GetBaseVarientGenerator();
            varger.GetTaskProblem += parser.GetBaseTask;
            varger.ClearDict();

            for (int i = 1; i <= 20; i++)
            {
                varger.Generator(i, 1);
            }

            BLVariant window = new BLVariant();
            window.Show();
        }

        private void AdvancedGenerator_Click(object sender, RoutedEventArgs e)
        {
            ParserFromMathege parser = new ParserFromMathege();
            IVariantGenerator varger = Factory.Default.GetVarientGenerator();
            varger.GetTaskProblem += parser.GetTask;
            varger.ClearDict();

            for (int i = 1; i <= 19; i++)
            {
                varger.Generator(i, 1);
            }

            AlVariant window = new AlVariant();
            window.Show();
        }

        private void ManualGenerator_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}
