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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Page
    {
        private Controller.ControllerPerson controller;

        public CreateAccount()
        {
            InitializeComponent();

            txtName.Focus();

            controller = new Controller.ControllerPerson(this);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "" || txtName.Text == "" || txtHp.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Check your data, make sure you fill all the data correctly.");
            }

            else
            {
                controller.InsertPerson();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Login());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Login());
        }
    }
}
