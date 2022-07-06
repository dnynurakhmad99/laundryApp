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
    /// Interaction logic for Penilaian.xaml
    /// </summary>
    public partial class Penilaian : Page
    {
        private Controller.ControllerPenilaian controller;

        public static int bintang = 0;

        public Penilaian()
        {
            InitializeComponent();

            txtPenilaian.Focus();

            controller = new Controller.ControllerPenilaian(this);
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            controller.Penilaian();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            bintang = 1;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            bintang = 2;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            bintang = 3;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            bintang = 4;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            bintang = 5;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Progress());
        }
    }
}
