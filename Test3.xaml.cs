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
    /// Логика взаимодействия для Test3.xaml
    /// </summary>
    public partial class Test3 : Page
    {
        public Test3()
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
            if (corr1.IsChecked == true && incorr1.IsChecked == false) count += 1;
            if (corr21.IsChecked == true && corr22.IsChecked == true && incorr23.IsChecked == false && corr24.IsChecked == true) count += 1;
            if (num3.Text == "Подавление" || num3.Text == "подавление.") count += 1;
            if (num4.Text == "Регрессия" || num4.Text == "регрессия") count += 1;
            if (corr5.IsChecked == true && incorr51.IsChecked == false && incorr52.IsChecked == false && incorr53.IsChecked == false) count += 1;
            MessageBox.Show("Количество баллов: " + count);
        }
    }
}
