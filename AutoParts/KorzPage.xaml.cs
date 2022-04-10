using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Word = Microsoft.Office.Interop.Word;

namespace AutoParts
{
    /// <summary>
    /// Логика взаимодействия для KorzPage.xaml
    /// </summary>
    public partial class KorzPage : Page
    {
        decimal cost;
        public KorzPage()
        {
            InitializeComponent();
            if (Cart.Parts.Count == 0)
            {
                wordBtn.IsEnabled = false;
            }
            Parts.ItemsSource = Cart.Parts;
            cost = 0;
            foreach (var a in Cart.Parts)
                cost += a.price;
            CostLb.Content += cost.ToString() + "руб.";
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var application = new Word.Application();
            Word.Document document = application.Documents.Add();
            Word.Paragraph paragraph = document.Paragraphs.Add();
            Word.Range userRange = paragraph.Range;
            userRange.Text = "Накладная деталей";
            try
            {
                userRange.set_Style("Цитата 2");
            }
            catch
            {

            }
            userRange.Font.Color = Word.WdColor.wdColorBlack; 
            userRange.InsertParagraphAfter();
            
            Word.Paragraph tableparagraph = document.Paragraphs.Add();
            Word.Range tableRange = tableparagraph.Range;
            Word.Table infoTable = document.Tables.Add(tableRange, Cart.Parts.Count + 1, 4);
            infoTable.Borders.InsideLineStyle = infoTable.Borders.OutsideLineStyle
                    = Word.WdLineStyle.wdLineStyleSingle;
            infoTable.Range.Cells.VerticalAlignment
                    = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            Word.Range cellRange;
            cellRange = infoTable.Cell(1, 1).Range;
            cellRange.Text = "Номер детали";
            cellRange = infoTable.Cell(1, 2).Range;
            cellRange.Text = "Название";
            cellRange = infoTable.Cell(1, 3).Range;
            cellRange.Text = "Производитель";
            cellRange = infoTable.Cell(1, 4).Range;
            cellRange.Text = "Цена";
            infoTable.Rows[1].Range.Bold = 1;
            for (int i = 0; i < Cart.Parts.Count; i++)
            {
                cellRange = infoTable.Cell(i + 2, 1).Range;
                cellRange.Text = Cart.Parts[i].id.ToString();
                cellRange = infoTable.Cell(i + 2, 2).Range;
                cellRange.Text = Cart.Parts[i].name.ToString();
                cellRange = infoTable.Cell(i + 2, 3).Range;
                cellRange.Text = Cart.Parts[i].Manufacturer.name.ToString();
                cellRange = infoTable.Cell(i + 2, 4).Range;
                cellRange.Text = Cart.Parts[i].price.ToString() + "руб.";

            }
            tableRange.InsertParagraphAfter();

            Word.Paragraph paragraph1 = document.Paragraphs.Add();
            Word.Range costRange = paragraph1.Range;
            costRange.Text = "Итого " + cost.ToString() + "руб.";

            application.Visible = true;
            document.SaveAs2(@"Receipt.docx");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListBoxItem listBoxItem1 = (ListBoxItem)Parts.ContainerFromElement((DependencyObject)sender);
            var ap = Parts.SelectedItem as AutoPart;
            Cart.Parts.Remove(ap);
            FrameApp.frmObj.Navigate(new KorzPage());
        }
    }
}
