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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private Controller.ControllerPerson controllerPerson;

        public Login()
        {
            InitializeComponent();

            txtUsername.Focus();

            controllerPerson = new Controller.ControllerPerson(this);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            controllerPerson.LoginCheck();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.CreateAccount());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.LoginAs());
        }
    }
}
