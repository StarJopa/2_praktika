using System;
using System.Windows;

namespace WpfTasks
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonTask1_Click(object sender, RoutedEventArgs e) { new Task1Window().ShowDialog(); }
        private void ButtonTask2_Click(object sender, RoutedEventArgs e) { new Task2Window().ShowDialog(); }
        private void ButtonTask3_Click(object sender, RoutedEventArgs e) { new Task3Window().ShowDialog(); }
        private void ButtonTask4_Click(object sender, RoutedEventArgs e) { new Task4Window().ShowDialog(); }
    }
}