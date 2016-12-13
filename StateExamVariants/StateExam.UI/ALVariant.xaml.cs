﻿using StateExamVariants;
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

        Repository repo = new Repository();

        private void Task1button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("1");
            List<UIElement> result = repo.Output(1);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task2button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("2");
            List<UIElement> result = repo.Output(2);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task3button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("3");
            List<UIElement> result = repo.Output(3);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task4button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("4");
            List<UIElement> result = repo.Output(4);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task5button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("5");
            List<UIElement> result = repo.Output(5);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task6button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("6");
            List<UIElement> result = repo.Output(6);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task7button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("7");
            List<UIElement> result = repo.Output(7);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task8button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("8");
            List<UIElement> result = repo.Output(8);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task9button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("9");
            List<UIElement> result = repo.Output(9);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task10button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("10");
            List<UIElement> result = repo.Output(10);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task11button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("11");
            List<UIElement> result = repo.Output(11);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task12button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("12");
            List<UIElement> result = repo.Output(12);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task13button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("13");
            List<UIElement> result = repo.Output(13);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task14button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("14");
            List<UIElement> result = repo.Output(14);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task15button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("15");
            List<UIElement> result = repo.Output(15);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task16button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("16");
            List<UIElement> result = repo.Output(16);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }
    

        private void Task17button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("17");
            List<UIElement> result = repo.Output(17);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

    private void Task18button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("18");
            List<UIElement> result = repo.Output(18);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }

        private void Task19button_Click(object sender, RoutedEventArgs e)
        {
            Exercise window = new Exercise();
            window.Show();
            window.listBox.Items.Add("19");
            List<UIElement> result = repo.Output(19);
            foreach (var item in result)
                window.outputStackPanel.Children.Add(item);
        }
    }
}
