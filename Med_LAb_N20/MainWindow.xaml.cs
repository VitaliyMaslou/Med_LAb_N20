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

namespace Med_LAb_N20
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            var result =DB.entities.admin.FirstOrDefault(x=>x.login==logtb.Text && x.password==passtb.Password);
            if(result != null)
            {
                GlobalWindow globalWindow = new GlobalWindow(1, "Администратор");
                globalWindow.Show();
                this.Close();
                return;
            }
            var result2 = DB.entities.Laborant_Data.FirstOrDefault(x => x.login == logtb.Text && x.password == passtb.Password);
            if (result2 != null)
            {
                GlobalWindow globalWindow = new GlobalWindow(2, result2.fio);
                globalWindow.Show();
                this.Close();
                return;
            }
            var result3 = DB.entities.Buhgalter.FirstOrDefault(x => x.login == logtb.Text && x.password == passtb.Password);
            if (result3 != null)
            {
                GlobalWindow globalWindow = new GlobalWindow(3, result3.fio);
                globalWindow.Show();
                this.Close();
                return;
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (passtb.Visibility == Visibility.Hidden)
                passtb.Visibility = Visibility.Visible;
            else
                passtb.Visibility = Visibility.Hidden;
        }
    }
}
