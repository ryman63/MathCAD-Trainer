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

using System.ComponentModel;
using System.IO;
using System.IO.IsolatedStorage;

namespace MathCAD_Trainer_0._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int scrollHomeVM = 0;
        public int scrollTestingVM = 0;
        public int scrollReferenceVM = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
                WindowState = WindowState.Normal;
            }

            if (e.RightButton == MouseButtonState.Pressed)
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void ContentPresenter_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {

        }

        private void radioButton1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }

}
