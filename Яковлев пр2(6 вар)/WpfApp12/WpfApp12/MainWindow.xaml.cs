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

namespace WpfApp12
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
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double b = double.Parse(txtY.Text);
           
            double g;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Яковлев.А.А");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"b={b}");
            
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if ((x * b) > 0.5&& (x * b) < 10) g =   Math.Pow(Math.E,Math.Sin(x)-Math.Abs(b));
                    else if ((x * b) < 0.5&& ((x * b) < 0.1)) g = Math.Sqrt(Math.Abs(Math.Sin(x) + b));
                    else g = 2 * Math.Sin(x) * Math.Sin(x);
                    lstResult.Items.Add($"Результат g={Math.Round(g, 3)}");
                    break;
                case 1:
                    if ((x * b) > 0.5 && (x * b) < 10) g = Math.Pow(Math.E, Math.Cos(x) - Math.Abs(b));
                    else if ((x * b) < 0.5 && ((x * b) < 0.1)) g = Math.Sqrt(Math.Abs(Math.Cos(x) + b));
                    else g = 2 * Math.Cos(x) * Math.Cos(x);
                    lstResult.Items.Add($"Результат g={Math.Round(g, 3)}");
                    break;
                case 2:
                    if ((x * b) > 0.5 && (x * b) < 10) g = Math.Pow(Math.E, Math.Exp(x) - Math.Abs(b));
                    else if ((x * b) < 0.5 && ((x * b) < 0.1)) g = Math.Sqrt(Math.Abs(Math.Exp(x) + b));
                    else g = 2 * Math.Exp(x) * Math.Exp(x);
                    lstResult.Items.Add($"Результат g={Math.Round(g, 3)}");
                    break;

                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;

            }




        }
        /// <summary>
        /// Очистить поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
       
            lstResult.Items.Clear();
        }
    }
}
