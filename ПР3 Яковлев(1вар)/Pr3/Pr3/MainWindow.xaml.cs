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

namespace Pr3
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
            double x0 = double.Parse(txtX0.Text);
            double xK = double.Parse(txtXk.Text);
            double dx = double.Parse(txtDk.Text);
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double c = double.Parse(txtc.Text);

            lstResult.Items.Clear();
            lstResult.Items.Add("Значения функции  y = Math.Pow(10,-2)*b*c/x+Math.Cos(Math.Sqrt(a*a*a*x)):");
            lstResult.Items.Add($"x\t\t|\ty");

            for (double x = x0; x <= xK; x += dx)
            {
                double y = Math.Pow(10,-2)*b*c/x+Math.Cos(Math.Sqrt(a*a*a*x));
                lstResult.Items.Add($"{x:F2}\t\t|\t{y:F4}");
            }

        }
    }
}
