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
    /// Interaction logic for ListLaundry1.xaml
    /// </summary>
    public partial class ListLaundry1 : Page
    {
        private Controller.ControllerLaundry controllerLaundry;

        public ListLaundry1()
        {
            InitializeComponent();

            lblLaundry3.Content = Model.ModelLaundry.laundryName3;
            lblHarga3.Content = "Rp. " + Model.ModelLaundry.laundryPrice3 + "/Kg";

            lblLaundry4.Content = Model.ModelLaundry.laundryName4;
            lblHarga4.Content = "Rp. " + Model.ModelLaundry.laundryPrice4 + "/Kg";

            lblLaundry5.Content = Model.ModelLaundry.laundryName5;
            lblHarga5.Content = "Rp. " + Model.ModelLaundry.laundryPrice5 + "/Kg";

            lblLaundry6.Content = Model.ModelLaundry.laundryName6;
            lblHarga6.Content = "Rp. " + Model.ModelLaundry.laundryPrice6 + "/Kg";

            controllerLaundry = new Controller.ControllerLaundry(this);
        }

        private void btnLihat3_Click(object sender, RoutedEventArgs e)
        {
            controllerLaundry.Laundry3();

            this.NavigationService.Navigate(new View.DetailLaundry());
        }

        private void btnLihat4_Click(object sender, RoutedEventArgs e)
        {
            controllerLaundry.Laundry4();

            this.NavigationService.Navigate(new View.DetailLaundry());
        }

        private void btnLihat5_Click(object sender, RoutedEventArgs e)
        {
            controllerLaundry.Laundry5();

            this.NavigationService.Navigate(new View.DetailLaundry());
        }

        private void btnLihat6_Click(object sender, RoutedEventArgs e)
        {
            controllerLaundry.Laundry6();

            this.NavigationService.Navigate(new View.DetailLaundry());
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.ListLaundry());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Homepage());
        }
    }
}
