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
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.IO;

namespace ООО_ПРОЕКТ
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public string name;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(string s)
        {
            InitializeComponent();
            name = s;
        }

        private void Bt_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Bt_teo_Click(object sender, RoutedEventArgs e)
        {
            if (Theory.Text == "Физиогномика. Невербальное общение.")
            {
                Theory theory = new Theory();
                theory.InputTheory.Content = new Theo1();
                theory.Show();
                Close();
            }
            else if (Theory.Text == "Глубинная психология. Юнг.")
            {
                Theory theory = new Theory();
                theory.InputTheory.Content = new Theo2();
                theory.Show();
                Close();
            }
            else if (Theory.Text == "Психоанализ. Фрейд.")
            {
                Theory theory = new Theory();
                theory.InputTheory.Content = new Theo3();
                theory.Show();
                Close();
            }
                
        }

        private void Bt_pr_Click(object sender, RoutedEventArgs e)
        {
            if (Exersice.Text == "Тест 1.")
            {
                Test test = new Test();
                test.InputTest.Content = new Test1();
                test.Show();
                Close();
            }
            else if (Exersice.Text == "Тест 2.")
            {
                Test test = new Test();
                test.InputTest.Content = new Test2();
                test.Show();
                Close();
            }
            else if (Exersice.Text == "Тест 3.")
            {
                Test test = new Test();
                test.InputTest.Content = new Test3();
                test.Show();
                Close();
            }
            else if (Exersice.Text == "Практика.")
            {
                Test test = new Test();
                test.InputTest.Content = new MainPage(name);
                test.Show();
                Close();
            }
        }

        private void Bt_history_Click(object sender, RoutedEventArgs e)
        {
            Stat stat = new Stat();
            stat.ShowDialog();
        }
    }


}
