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

namespace MathCAD_Trainer_0._01.MVVM.View.Test
{
    /// <summary>r
    /// Interaction logic for Test_1.xaml
    /// </summary>
    public partial class TestView_1 : UserControl
    {

        public TestView_1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Visibility = Visibility.Visible;

            if (num1.Text == "3")
            {
                num1Border.Background = Brushes.Green;
            }
            else
            {
                num1Border.Background = Brushes.Yellow;
            }

            if (num2.Text == "36")
            {
                num2Border.Background = Brushes.Green;
            }
            else
            {
                num2Border.Background = Brushes.Yellow;
            }

            if (num2.Text != "36" && num1.Text != "3")
            {
                num1Border.Background = Brushes.Red;
                num2Border.Background = Brushes.Red;

                resultTextBlock.Text = "Ни один из вариантов ответов неверен!";
            }
            else if (num2.Text == "36" & num1.Text == "3")
            {
                resultTextBlock.Text = "Тест решен верно!";
            }
            else
            {
                resultTextBlock.Text = "Есть неправильный вариант ответа.";
            }
            
        }
    }
}

