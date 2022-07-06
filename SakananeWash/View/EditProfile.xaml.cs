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
    /// Interaction logic for EditProfile.xaml
    /// </summary>
    public partial class EditProfile : Page
    {
        private Controller.ControllerPerson controllerPerson;

        public EditProfile()
        {
            InitializeComponent();

            txtName.Focus();

            controllerPerson = new Controller.ControllerPerson(this);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            controllerPerson.EditPerson();
        }

        private void btnProgress_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Progress());
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Homepage());
        }

        private void btnChat_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Chat());
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.History());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Homepage());
        }
    }
}
