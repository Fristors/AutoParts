using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для AddPartPage.xaml
    /// </summary>
    public partial class AddPartPage : Page
    {
        AutoPartsEntities4 db;
        public AddPartPage()
        {
            db = new AutoPartsEntities4();
            InitializeComponent();
            db.AutoPart.Load();
            db.Manufacturer.Load();
            Grid.ItemsSource = db.AutoPart.Local.ToBindingList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PartBrandTB.Text == null && PartBrandTB.Text == "" && PartBrandTB.Text == " ")
            {
                MessageBox.Show("Введите производителя детали", "Уведомление");
                PartBrandTB.Focus();
                return;
            }
            try
            {
                var a = db.Manufacturer.Local.ToBindingList();
                Manufacturer bc = new Manufacturer()
                {
                    id = a.Count + 1,
                    name = PartBrandTB.Text
                };
                db.Manufacturer.Add(bc);
                db.SaveChangesAsync();
            }
            catch
            {

            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (Grid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < Grid.SelectedItems.Count; i++)
                {
                    AutoPart us = Grid.SelectedItems[i] as AutoPart;
                    if (us != null)
                    {
                        db.AutoPart.Remove(us);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
