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
    /// Interaction logic for LoginAs.xaml
    /// </summary>
    public partial class LoginAs : Page
    {
        public LoginAs()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Login());
        }
    }
}
