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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bt_entry_Click(object sender, RoutedEventArgs e)
        {
            Entry entryWindow = new Entry();
            entryWindow.Show();
            Close();        
        }

        private void Bt_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Bt_reg_Click(object sender, RoutedEventArgs e)
        {
            Record recordWindow = new Record();
            recordWindow.Show();
            Close();
        }
    }
}
