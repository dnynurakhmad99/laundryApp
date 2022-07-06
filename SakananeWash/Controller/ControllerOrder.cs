using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SakananeWash.Controller
{
    class ControllerOrder
    {
        public Model.ModelOrder cucian;
        private View.DetailOrder detailCucian;

        public ControllerOrder(View.DetailOrder detailCucian)
        {
            this.detailCucian = detailCucian;
            cucian = new Model.ModelOrder();
        }

        public void Orderan()
        {
            cucian.BeratCucian = detailCucian.txtBerat.Text;

            bool result = cucian.Orderan();
            if (result == true)
            {
                cucian.Bayar();

                MessageBox.Show("Orderan Success!");

                detailCucian.NavigationService.Navigate(new View.Progress());

            }

            else
            {
                MessageBox.Show("Silahkan isi berat cucian dan antar jemput.");
            }
        }
    }
}
