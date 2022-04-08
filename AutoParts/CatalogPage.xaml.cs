using System;
using System.Data.Entity;
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
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        
        AutoPartsEntities4 db;
        public CatalogPage()
        {
            InitializeComponent();
            db = new AutoPartsEntities4();
            db.AutoPart.Load();
            db.BrandCar.Load();
            db.YearCar.Load();
            db.Manufacturer.Load();
            Parts.ItemsSource = db.AutoPart.Local.ToBindingList();
            foreach (var a in db.BrandCar.Local.ToBindingList())
                CarBrand.Items.Add(a.brand);
            foreach (var a in db.Manufacturer.Local.ToBindingList())
                PartBrand.Items.Add(a.name);
            foreach (var a in db.YearCar.Local.ToBindingList())
                CarYear.Items.Add(a.year);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db = new AutoPartsEntities4();
            db.AutoPart.Where(u => CarBrand.Text != "" ? u.Car.ModelCar.BrandCar.brand == CarBrand.Text : true).Where(u => CarModel.Text!="" ? u.Car.ModelCar.model == CarModel.Text : true).Where(u => CarYear.Text != "" ? u.Car.YearCar.year.ToString() == CarYear.Text : true).Where(u => PartBrand.Text != "" ? u.Manufacturer.name.ToString() == PartBrand.Text : true).Load();
            Parts.ItemsSource = db.AutoPart.Local.ToBindingList();
        }

        private void CarBrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CarBrand.Text != null)
            {
                db = new AutoPartsEntities4();
                CarModel.Items.Clear();
                CarModel.IsEnabled = true;
                db.ModelCar.Where(u => u.BrandCar.brand == CarBrand.SelectedValue.ToString()).Load();
                foreach (var a in db.ModelCar.Local.ToBindingList())
                    CarModel.Items.Add(a.model);
            }
            else
            {
                CarModel.IsEnabled = false;
            }
        }

        private void CarModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            db = new AutoPartsEntities4();
            AutoPart ap = Parts.SelectedItem as AutoPart;
            db.AutoPart.Where(u => u.id == ap.id).Load();
            FrameApp.frmObj.Navigate(new PartPage(db.AutoPart.Local.ToBindingList()[0]));
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (GridSorting.Visibility == Visibility.Visible)
            {
                GridSorting.Visibility = Visibility.Hidden;
                Grid.SetRow(GridProducts, 1);
            }
            else
            {
                GridSorting.Visibility = Visibility.Visible;
                Grid.SetRow(GridProducts, 2);
            }
        }
    }
}
