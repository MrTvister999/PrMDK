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

namespace WpfApp1.pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtX.Text);
            double y = Convert.ToDouble(TxtY.Text);
            double z = Convert.ToDouble(TxtZ.Text);

            double u = Math.Sqrt(10 * (Math.Pow(x, 1 / 3) + Math.Pow(x, y + 2))) * (Math.Asin(z)* Math.Asin(z) - Math.Abs(x - y));
            LstResult.Items.Add("ПР1 BCG 21.1зОРИН яКОВЛЕВ");
            LstResult.Items.Add($"X={x}");
            LstResult.Items.Add($"Y={y}");
            LstResult.Items.Add($"Z={z}");
            LstResult.Items.Add($"Результат u={u}");
          
        }
        private void BtnSolve_Click1(object sender, RoutedEventArgs e)
        {
            clases.ClassFrame.frmObj.Navigate(new pages.Pr6());
        }
    }
}
