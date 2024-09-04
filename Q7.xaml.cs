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
    /// Логика взаимодействия для Q7.xaml
    /// </summary>
    public partial class Q7 : Page
    {
        public int count_q;
        public string name;
        public Q7(int a, string n)
        {
            InitializeComponent();
            count_q = a;
            name = n;
        }

        private void No_go_Click(object sender, RoutedEventArgs e)
        {
            if (num1.Text == "Метапсихологической" || num1.Text == "метапсихологической") count_q += 1;
            NavigationService.Navigate(new Q8(count_q, name));
        }
    }
}
