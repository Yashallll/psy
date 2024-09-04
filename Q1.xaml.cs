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

namespace ООО_ПРОЕКТ
{
    /// <summary>
    /// Логика взаимодействия для Q1.xaml
    /// </summary>
    public partial class Q1 : Page
    {
        public int count_q = 0;
        public string name;
        public Q1(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void No_go_Click(object sender, RoutedEventArgs e)
        {
            if (incorr1.IsChecked == false && corr2.IsChecked == true && incorr3.IsChecked == false && incorr4.IsChecked == false) count_q += 1;
            NavigationService.Navigate(new Q2(count_q, name));
        }
    }
}
