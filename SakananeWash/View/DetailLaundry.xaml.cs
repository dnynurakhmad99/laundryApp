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
    /// Interaction logic for DetailLaundry.xaml
    /// </summary>
    public partial class DetailLaundry : Page
    {
        public DetailLaundry()
        {
            InitializeComponent();

            lblLaundry.Content = Model.ModelLaundry.laundryAll;
            lblJalan.Content = Model.ModelLaundry.laundryAddress;
            lblHarga.Content = "Rp. " + Model.ModelLaundry.laundryPrice + "/Kg";
            lblHp.Content = Model.ModelLaundry.laundryPhone;
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.DetailOrder());
        }

        private void btnChat_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.IsiChat());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.ListLaundry());
        }
    }
}
