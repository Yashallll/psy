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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public string name;
        public MainPage(string s)
        {
            InitializeComponent();
            name = s;
            priv.Content = name + ", Вам предлагается пройти тест по прочтенным вами темам."+"\n"+"В тесте 15 вопросов, время не огрничено."+"\n"+"Постарайтесь не спешить и читать вопросы внимательно."+"\n"+"Удачи!";
        }

        private void No_go_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu(name);
            menu.wert.Content = "Устал?";
            menu.Show();
            Test.Instance2.Close();
            
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Q1(name));
        }
    }
}
