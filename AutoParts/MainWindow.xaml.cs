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

namespace AutoParts
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User User;
        public MainWindow(User usr)
        {
            InitializeComponent();
            User = usr;
            UserName.Content = User.login;
            FrameApp.frmObj = FrmMain;
        }

        private void CatalogBt_Click(object sender, RoutedEventArgs e)
        {
            InfoPage.Content = "Каталог";
            FrmMain.Navigate(new CatalogPage());
        }

        private void KorzBt_Click(object sender, RoutedEventArgs e)
        {
            InfoPage.Content = "Корзина";
            FrmMain.Navigate(new KorzPage());
        }
    }
}
