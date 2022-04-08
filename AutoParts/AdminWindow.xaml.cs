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

namespace AutoParts
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        User User;
        public AdminWindow(User usr)
        {
            InitializeComponent();
            FrameApp.frmObj = FrmMain;
            User = usr;
            UserName.Content = User.login;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new AddCarPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new AddPartPage());
        }
    }
}
