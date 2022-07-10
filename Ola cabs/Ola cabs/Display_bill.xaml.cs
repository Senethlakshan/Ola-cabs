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

namespace Ola_cabs
{
    /// <summary>
    /// Interaction logic for Display_bill.xaml
    /// </summary>
    public partial class Display_bill : Window
    {
        public Display_bill()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            string plocate = UserControl1.picklocate;
            string droplocate= UserControl1.droplocate;
            string km3 = UserControl1.kmofcus;
            double boll1 = UserControl1.billa;

            pick.Content = plocate;
            drop.Content = droplocate;
            num_km.Content = km3;
            bill.Content = Convert.ToString(boll1);

            string qr=plocate+droplocate+km3+ Convert.ToString(boll1);

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(qr, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            QR_IMAGE.Source=ConvertImage.bitmapImage(code.GetGraphic(50));
           
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void payment_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, " Payment sucsessfully !  ", "info", MessageBoxButton.OK);
        }
    }
}


