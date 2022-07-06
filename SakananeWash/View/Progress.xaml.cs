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
    /// Interaction logic for Progress.xaml
    /// </summary>
    public partial class Progress : Page
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void btnPenilaian_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Penilaian());
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.EditProfile());
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
