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
    /// Логика взаимодействия для PartPage.xaml
    /// </summary>
    public partial class PartPage : Page
    {
        AutoPart AP;
        public PartPage(AutoPart ap)
        {
            InitializeComponent();
            var converter = new ImageSourceConverter();
            AP = ap;
            PartName.Content += AP.name;
            PartImg.Source = (ImageSource)converter.ConvertFromString(AP.url);
            CarBrand.Content += AP.Car.ModelCar.BrandCar.brand;
            CarModel.Content += AP.Car.ModelCar.model;
            CarYear.Content += AP.Car.YearCar.year.ToString();
            PartBrand.Content += AP.Manufacturer.name;
            PartPrice.Content += AP.price.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cart.Parts.Add(AP);
            MessageBox.Show("Товар - '" + AP.name + "' добавлен", "Уведомление");
            FrameApp.frmObj.Navigate(new CatalogPage());
        }
    }
}
