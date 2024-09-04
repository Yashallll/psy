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
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Page
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void Bt_menu_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.wert.Content = "Уже все?";
            menu.Show();
            Test.Instance2.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if (num1.Text == "Физиогномика"||num1.Text == "физиогномика") count += 1;
            if(corr2.IsChecked == true && incorr21.IsChecked == false && incorr23.IsChecked == false && incorr24.IsChecked == false) count += 1;
            if(corr3.IsChecked == true && incorr31.IsChecked == false && incorr33.IsChecked == false && incorr34.IsChecked == false) count += 1;
            if(corr41.IsChecked == true && corr42.IsChecked == true && corr43.IsChecked == true && incorr4.IsChecked == false) count += 1;
            if (num5.Text == "Невербальное общение"||num5.Text == "невербальное общение") count += 1;
            MessageBox.Show("Количество баллов: " + count);
        }
    }
}
