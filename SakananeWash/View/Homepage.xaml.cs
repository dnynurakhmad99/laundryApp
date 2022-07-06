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
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page
    {
        private Controller.ControllerLaundry controllerLaundry;

        public Homepage()
        {
            InitializeComponent();

            lblName.Content = Model.ModelPerson.memberName;

            controllerLaundry = new Controller.ControllerLaundry(this);
        }

        private void btnCuci_Click(object sender, RoutedEventArgs e)
        {
            controllerLaundry.Laundry1();
            controllerLaundry.Laundry2();
            controllerLaundry.Laundry3();
            controllerLaundry.Laundry4();
            controllerLaundry.Laundry5();
            controllerLaundry.Laundry6();

            this.NavigationService.Navigate(new View.ListLaundry());
        }

        private void btnProgress_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Progress());
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.EditProfile());
        }

        private void btnChat_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Chat());
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.History());
        }
    }
}
