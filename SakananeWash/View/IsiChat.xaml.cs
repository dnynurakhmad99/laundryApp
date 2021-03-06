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
    /// Interaction logic for IsiChat.xaml
    /// </summary>
    public partial class IsiChat : Page
    {
        private Controller.ControllerChat controller;

        public IsiChat()
        {
            InitializeComponent();

            txtChat.Focus();

            lblLaundry.Content = Model.ModelLaundry.laundryAll;
            lblChat.Content = Model.ModelChat.teksChat;

            controller = new Controller.ControllerChat(this);
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            controller.TeksChat();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new View.Chat());
        }
    }
}
