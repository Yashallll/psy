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
    /// Логика взаимодействия для Stat.xaml
    /// </summary>
    public partial class Stat : Window
    {
        public Stat()
        {
            InitializeComponent();
            List<Class1> list = TextInGrid();
            DataGrid1.ItemsSource = list;
        }
        public List<string> TextReader()
        {
            List<string> s = new List<string>();
            foreach (string line in File.ReadLines("stat.txt"))
            {
                s.Add(line);
            }
            return s;
        }

        private List<Class1> TextInGrid()
        {
            List<Class1> elem = new List<Class1>();
            for (int i = 0; i < TextReader().Count; i++)
            {
                string[] mas = TextReader()[i].Split('|');
                Class1 element = new Class1
                {
                    Name = mas[0],
                    Mark = mas[1],
                };
                elem.Add(element);
            }
            return elem;
        }
    }
}
