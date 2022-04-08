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
    /// Логика взаимодействия для AuthorWindow.xaml
    /// </summary>
    public partial class AuthorWindow : Window
    {
        public AuthorWindow()
        {
            InitializeComponent();
            OdbConnectHelper.entobj = new AutoPartsEntities4();
        }

        private void Autoriz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = OdbConnectHelper.entobj.User.FirstOrDefault(
                    x => x.login == Login.Text && x.password == Password.Password);
                if (userObj == null)
                    MessageBox.Show("Неверный логин или пароль",
                                    "Уведомление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Warning);
                else
                {
                    if (userObj.idRole == 1)
                    {
                        AdminWindow aw = new AdminWindow(userObj);
                        aw.Show();
                        this.Close();
                    }
                    else if (userObj.idRole == 2)
                    {
                        MainWindow mw = new MainWindow(userObj);
                        mw.Show();
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой в работе приложения: " + ex.Message.ToString(),
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }
    }
}
