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
    /// Логика взаимодействия для Q_Q.xaml
    /// </summary>
    public partial class Q_Q : Page
    {
        public string name;
        public int count;
        public Q_Q(int a, string n)
        {
            InitializeComponent();
            name = n;
            count = a;
            bab.Content = n + ", твой результат " + a.ToString() + " баллов из 15 возможных!" + '\n' + "Продолжай в том же духе!";
            nobody();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.wert.Content = "Молодчина!";
            menu.Show();
            Test.Instance2.Close();
        }

        public void nobody()
        {
            StringBuilder Data = new StringBuilder();
            string item = string.Join("|", name, count);
            Data.AppendLine(item);
            File.AppendAllText("stat.txt", Data.ToString());
        }
    }
}
