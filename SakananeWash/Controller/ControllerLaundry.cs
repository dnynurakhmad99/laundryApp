using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SakananeWash.Controller
{
    class ControllerLaundry
    {
        private Model.ModelLaundry laundry;
        private View.ListLaundry list;
        private View.ListLaundry1 list1;
        private View.Homepage home;

        public ControllerLaundry(View.ListLaundry list)
        {
            this.list = list;
            laundry = new Model.ModelLaundry();
        }

        public ControllerLaundry(View.ListLaundry1 list1)
        {
            this.list1 = list1;
            laundry = new Model.ModelLaundry();
        }

        public ControllerLaundry(View.Homepage home)
        {
            this.home = home;
            laundry = new Model.ModelLaundry();
        }

        public void Laundry1()
        {
            laundry.Laundry1();
        }

        public void Laundry2()
        {
            laundry.Laundry2();
        }

        public void Laundry3()
        {
            laundry.Laundry3();
        }

        public void Laundry4()
        {
            laundry.Laundry4();
        }

        public void Laundry5()
        {
            laundry.Laundry5();
        }

        public void Laundry6()
        {
            laundry.Laundry6();
        }
    }
}
