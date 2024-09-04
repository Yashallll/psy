
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
using System.IO;

namespace ООО_ПРОЕКТ
{
    /// <summary>
    /// Логика взаимодействия для Entry.xaml
    /// </summary>
    public partial class Entry : Window
    {
        public string mname { get; set; }
        public Entry()
        {
            InitializeComponent();
        }

        private void Bt_entry_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private void Bt_entry_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "" || Pass1.Password == "") MessageBox.Show("Поля не могут быть пустыми!");
            else
            {
                //чтение файла построчно
                List<string> list = new List<string>();
                foreach (string line in File.ReadLines("users.txt"))
                    list.Add(line);
                //разбиваем строку и ищем логин и пароль, проверяем вход
                int count = list.Count;
                string[] mas = null;
                for (int i = 0; i < count; i++)
                {
                    mas = list[i].Split('|');
                    if (mas[1] == TextBox1.Text && mas[2] == Pass1.Password)
                    {
                        mname = mas[0];

                        Menu menu = new Menu(mname);
                        menu.wert.Content = "Добро пожаловать, " + mname + "!";
                        menu.Show();
                        Close();
                        break;
                    }
                }
                for (int k = 0; k < count; k++)
                {
                    if (mas[1] != TextBox1.Text || mas[2] != Pass1.Password)
                    {
                        MessageBox.Show("Данные введены неверно, повторите ввод!");
                        break;
                    }
                }
            }
        }
    }
}
