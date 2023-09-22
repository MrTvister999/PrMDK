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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = TxtLogin.Text;
            string password = PsbPassword.Password;
            if (login == "YZ" && password == "1")
            {
                MessageBox.Show("вход выполнен");
                clases.ClassFrame.frmObj.Navigate(new pages.Page2());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private void BtnEnter_Click1(object sender, RoutedEventArgs e)
        {
            clases.ClassFrame.frmObj.Navigate(new pages.Pr7());
        }

    }
}
