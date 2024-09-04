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
    /// Логика взаимодействия для Record.xaml
    /// </summary>
    public partial class Record : Window
    {
        public string mname;
        public Record()
        {
            InitializeComponent();
        }
        private void Bt_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        //вынести регистрацию
        private void Bt_entry_Click(object sender, RoutedEventArgs e)
        {
            //если поля пустые
            StringBuilder Data = new StringBuilder();
            if (name.Text == "" || login.Text == "" || password.Text == "" || password1.Text == "") MessageBox.Show("Поля не могут быть пустыми!");
            else
            {
                //чтение файла построчно
                List<string> list = new List<string>();
                foreach (string line in File.ReadLines("users.txt"))
                    list.Add(line);
                string[] str = File.ReadAllLines("users.txt");
                if (str.Length != 0)
                {
                    //разбиваем строку и ищем логин, проверяем, совпадает или нет
                    int count = list.Count;
                    string[] mas = null;
                    for (int i = 0; i < count; i++)
                    {
                        mas = list[i].Split('|');
                        if (mas[1] == login.Text)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует!");
                            break;
                        }
                    }
                    if (mas[1] != login.Text)
                    {
                        // если пароли совпадают записать в файл
                        if (password.Text == password1.Text)
                        {
                            string item = string.Join("|", name.Text, login.Text, password.Text);
                            Data.AppendLine(item);
                            File.AppendAllText("users.txt", Data.ToString());
                            mname = name.Text;
                            Menu menu = new Menu(mname);
                            menu.wert.Content = "Добро пожаловать, " + mname + "!";
                            menu.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают!");
                        }
                    }
                }
                else
                {
                    // если пароли совпадают записать в файл
                    if (password.Text == password1.Text)
                    {
                        string item = string.Join("|", name.Text, login.Text, password.Text);
                        Data.AppendLine(item);
                        File.AppendAllText("users.txt", Data.ToString());
                        Menu menu = new Menu(mname);
                        menu.wert.Content = "Добро пожаловать, " + name.Text + "!";
                        menu.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!");
                    }
                }
                
            }
        }
    }
}
