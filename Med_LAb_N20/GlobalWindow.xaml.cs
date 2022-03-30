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

namespace Med_LAb_N20
{
    /// <summary>
    /// Логика взаимодействия для GlobalWindow.xaml
    /// </summary>
    public partial class GlobalWindow : Window
    {
        public GlobalWindow(int imageid, string fio)
        {
            InitializeComponent();

            if(imageid == 1)
            {
                img.Source = new BitmapImage(new Uri("Res/Администратор.png", UriKind.Relative));
                fiotb.Text = fio;
                roletb.Text = "Администратор";
            }
            if (imageid == 2)
            {
                img.Source = new BitmapImage(new Uri("Res/laborant_1.jpeg", UriKind.Relative));
                fiotb.Text = fio;
                roletb.Text = "Лаборант";
            }
            if (imageid == 3)
            {
                img.Source = new BitmapImage(new Uri("Res/Бухгалтер.jpeg", UriKind.Relative));
                fiotb.Text = fio;
                roletb.Text = "Бухгалтер";
            }

        }
    }
}
