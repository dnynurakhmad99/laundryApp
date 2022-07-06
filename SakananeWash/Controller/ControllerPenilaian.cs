using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SakananeWash.Controller
{
    class ControllerPenilaian
    {
        private Model.ModelPenilaian penilaian;
        private View.Penilaian penilaianPage;

        public ControllerPenilaian(View.Penilaian penilaianPage)
        {
            this.penilaianPage = penilaianPage;
            penilaian = new Model.ModelPenilaian();
        }

        public void Penilaian()
        {
            penilaian.Ulasan = penilaianPage.txtPenilaian.Text;

            bool result = penilaian.Penilaian();
            if (result == true)
            {
                MessageBox.Show("Penilaian Success!");

                penilaianPage.NavigationService.Navigate(new View.History());
            }

            else
            {
                MessageBox.Show("Silahkan pilih bintang dan isi penilaian.");
            }
        }
    }
}
