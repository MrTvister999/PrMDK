using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Pr6.xaml
    /// </summary>
    public partial class Pr6 : Page
    {
        public Pr6()
        {
            InitializeComponent();
        }

        private void btnListFromeFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                lstInput.Items.Add(sr.ReadLine());
            }
        }

        private void btnRezult_Click(object sender, RoutedEventArgs e)
        {
            int index = lstInput.SelectedIndex;
            string Line = lstInput.SelectedItem.ToString();
                string[] reverseLine = Line.Split();
            txtRezult.Text = Line.Replace("А","*");

            StreamWriter sw = new StreamWriter(@"Rezult.txt");
            sw.WriteLine($"Номер строки: { index}");
            sw.WriteLine($"Исходная строка: {Line}");
            sw.WriteLine($"Новая строка: {txtRezult.Text}");
            sw.Close();



        }
    }
}
