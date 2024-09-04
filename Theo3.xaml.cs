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
using System.IO;

namespace ООО_ПРОЕКТ
{
    /// <summary>
    /// Логика взаимодействия для Theo3.xaml
    /// </summary>
    public partial class Theo3 : Page
    {
        public Theo3()
        {
            InitializeComponent();
            ReadF();
        }
        public void ReadF()
        {
            List<string> text = new List<string>();
            foreach (string s in File.ReadLines("theory3.txt"))
            {
                text.Add(s);
            }
            for (int i = 0; i < text.Count; i++)
            {
                t3.Text += " " + text[i] + "\n";
            }
        }

        private void Bt_exit_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.wert.Content = "Пройдем тестик?";
            menu.Show();
            Theory.Instance.Close();
        }

        private void Bt_test_Click(object sender, RoutedEventArgs e)
        {
            Test test = new Test();
            test.InputTest.Content = new Test3();
            test.Show();
            Theory.Instance.Close();
        }
    }
}
