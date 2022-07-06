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

namespace SakananeWash.View
{
    /// <summary>
    /// Interaction logic for DetailOrder.xaml
    /// </summary>
    public partial class DetailOrder : Page
    {
        private Controller.ControllerOrder controller;

        public static char jemput = ' ';
        public static string via = "";

        public DetailOrder()
        {
            InitializeComponent();

            txtBerat.Focus();

            lblLaundry.Content = Model.ModelLaundry.laundryAll;
            lblHarga.Content = "Rp. " + Model.ModelLaundry.laundryPrice + "/Kg";

            lblName.Content = Model.ModelPerson.memberName;
            lblHp.Content = Model.ModelPerson.memberPhone;

            controller = new Controller.ControllerOrder(this);
        }

        private void btnSelesai_Click(object sender, RoutedEventArgs e)
        {
            controller.Orderan();
        }

        private void btnJemput1_Click(object sender, RoutedEventArgs e)
        {
            jemput = 'Y';
        }

        private void btnJemput2_Click(object sender, RoutedEventArgs e)
        {
            jemput = 'T';
        }

        private void btnDigital1_Click(object sender, RoutedEventArgs e)
        {
            via = "E-Money";
        }

        private void btnDigital2_Click(object sender, RoutedEventArgs e)
        {
            via = "E-Money";
        }

        private void btnDigital3_Click(object sender, RoutedEventArgs e)
        {
            via = "E-Money";
        }

        private void btnCod_Click(object sender, RoutedEventArgs e)
        {
            via = "Tunai";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.DetailLaundry());
        }
    }
}
