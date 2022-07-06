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
    /// Interaction logic for ListLaundry.xaml
    /// </summary>
    public partial class ListLaundry : Page
    {
        private Controller.ControllerLaundry controllerLaundry;
        public ListLaundry()
        {
            InitializeComponent();

            lblLaundry1.Content = Model.ModelLaundry.laundryName1;
            lblHarga1.Content = "Rp. " + Model.ModelLaundry.laundryPrice1 + "/Kg";

            lblLaundry2.Content = Model.ModelLaundry.laundryName2;
            lblHarga2.Content = "Rp. " + Model.ModelLaundry.laundryPrice2 + "/Kg";

            controllerLaundry = new Controller.ControllerLaundry(this);
        }

        private void btnLihat1_Click(object sender, RoutedEventArgs e)
        {
            controllerLaundry.Laundry1();

            this.NavigationService.Navigate(new View.DetailLaundry());
        }

        private void btnLihat2_Click(object sender, RoutedEventArgs e)
        {
            controllerLaundry.Laundry2();

            this.NavigationService.Navigate(new View.DetailLaundry());
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.ListLaundry1());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Homepage());
        }
    }
}
