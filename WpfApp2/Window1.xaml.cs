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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 fr2 = new Window2();
            fr2.Show();
            Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window2 fr2 = new Window2();
            fr2.Show();
            Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow fr = new MainWindow();
            fr.Show();
            Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window1 fr1 = new Window1();
            fr1.Show();
            Hide();
        }
    }
}
