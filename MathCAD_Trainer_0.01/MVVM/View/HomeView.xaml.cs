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

namespace MathCAD_Trainer_0._01.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void UsefulMaterialBorder_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textPanel.Visibility = Visibility.Visible;

            textPanel.Background = UsefulMaterialBorder_2.Background;

            usefulMaterialTextBlock.Text = "Текст номер 2";
        }

        private void UsefulMaterialBorder_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textPanel.Visibility = Visibility.Visible;

            textPanel.Background = UsefulMaterialBorder_1.Background;

            usefulMaterialTextBlock.Text =
                  "     Mathcad применяется для выполнения, документирования и совместного использования вычислений и инженерных расчетов. Mathcad позволяет объединить инженерно-ориентированные математические записи, форматированные тексты, графики и изображения в единый документ, что облегчает визуализацию, проверку и документирование знаний и совместное выполнение работы. При вводе уравнений в документ результаты рассчитываются автоматически."
                + "\n     Mathcad отличается надежностью и обладает всеми функциональными возможностями, необходимыми для вычислений, обработки данных и инженерных расчетов."
                + "\n     Mathcad позволяет брать производные, рассчитывать корни уравнений, анализировать данные, решать системы уравнений и обыкновенные дифференциальные уравнения. При изменении любого числа, переменной или уравнения выполняется мгновенный перерасчет всех данных в документе."
                + "\n     С помощью Mathcad можно легко выполнять преобразование единиц измерения из одной системы в другую. Mathcad помогает находить ошибки, сделанные в единицах измерения, используемых в вычислениях. Единицы измерения поддерживаются в функциях, графиках и массивах."
                + "\n     Данные можно импортировать из таблиц Excel, анализировать и экспортировать обратно в Excel. Mathcad легко интегрируется с другими инженерными приложениями PTC. Математические расчеты можно переносить в Pro/ENGINEER и применять результаты к конструкциям. Для распространения документов и расчетов можно использовать программу Windchill Workgroup Manager.";

        }

        private void UsefulMaterialBorder_3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textPanel.Visibility = Visibility.Visible;

            textPanel.Background = UsefulMaterialBorder_3.Background;

            usefulMaterialTextBlock.Text = "Текст номер 3";
        }

        private void UsefulMaterialBorder_4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textPanel.Visibility = Visibility.Visible;

            textPanel.Background = UsefulMaterialBorder_4.Background;

            usefulMaterialTextBlock.Text = "Текст номер 4";
        }
    }
}
