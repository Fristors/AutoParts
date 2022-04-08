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
    /// Логика взаимодействия для AddCarPage.xaml
    /// </summary>
    public partial class AddCarPage : Page
    {
        AutoPartsEntities4 db;
        public AddCarPage()
        {
            InitializeComponent();
            db = new AutoPartsEntities4();
            db.BrandCar.Load();
            db.ModelCar.Load();
            db.YearCar.Load();
            foreach (var a in db.BrandCar.Local.ToBindingList())
                CarBrand.Items.Add(a.brand);
            foreach (var a in db.ModelCar.Local.ToBindingList())
                CarModelCar.Items.Add(a.model);
            foreach (var a in db.YearCar.Local.ToBindingList())
                CarYearCar.Items.Add(a.year);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CarBrandTB.Text == null && CarBrandTB.Text == "" && CarBrandTB.Text == " ")
            {
                MessageBox.Show("Введите марку авто", "Уведомление");
                CarBrandTB.Focus();
                return;
            }
            try
            {
                var a = db.BrandCar.Local.ToBindingList();
                BrandCar bc = new BrandCar()
                {
                    id = a.Count + 1,
                    brand = CarBrandTB.Text
                };
                db.BrandCar.Add(bc);
                db.SaveChangesAsync();
            }
            catch
            {

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CarBrand.Text == "")
            {
                MessageBox.Show("Выберите марку авто", "Уведомление");
                CarBrand.Focus();
                return;
            }
            if (CarModelTB.Text == null && CarModelTB.Text == "" && CarModelTB.Text == " ")
            {
                MessageBox.Show("Введите модель авто", "Уведомление");
                CarModelTB.Focus();
                return;
            }
            var a = db.ModelCar.Local.ToBindingList();
            BrandCar bc= new BrandCar();
            foreach (var b in db.BrandCar.Local.ToBindingList())
                if (b.brand == CarBrand.Text)
                    bc = b;
            ModelCar mc = new ModelCar()
            {
                id = a.Count + 1,
                idBrand = bc.id,
                model = CarModelTB.Text
            };
            db.ModelCar.Add(mc);
            db.SaveChangesAsync();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (CarModelCar.Text == null && CarModelCar.Text == "" && CarModelCar.Text == " ")
            {
                MessageBox.Show("Выберите модель авто", "Уведомление");
                CarModelCar.Focus();
                return;
            }
            if (CarYearCar.Text == null && CarYearCar.Text == "" && CarYearCar.Text == " ")
            {
                MessageBox.Show("Выберите год авто", "Уведомление");
                CarYearCar.Focus();
                return;
            }
            var a = db.Car.Local.ToBindingList();
            Car c = new Car();
            c.id = a.Count + 1;
            foreach (var b in db.ModelCar.Local.ToBindingList())
                if (b.model == CarModelCar.Text)
                    c.idModel = b.id;
            foreach (var b in db.YearCar.Local.ToBindingList())
                if (b.year.ToString() == CarYearCar.Text)
                    c.idYear = b.id;
            db.Car.Add(c);
            db.SaveChangesAsync();
        }
    }
}
