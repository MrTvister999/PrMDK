using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для Pr7.xaml
    /// </summary>
    public partial class Pr7 : Page
    {
        public int max;
        public int num;
        public Pr7()
        {
           
            InitializeComponent();
            string[] meArr = new string[20];
            Random rand = new Random();
            for(int i = 0; i < 20; i++)
            {
                FontsList.Items.Add(rand.Next(0,99).ToString());
                if (i != 0)
                {
                    if (Convert.ToInt32(FontsList.Items[i]) > max)
                    {

                        max = Convert.ToInt32(FontsList.Items[i]);
                        num = i;
                    }
                }
            }
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            string m = FontsList.Items[0].ToString();
            FontsList.Items[0] = max;
            FontsList.Items[num] = m;




            }
        }
    }

