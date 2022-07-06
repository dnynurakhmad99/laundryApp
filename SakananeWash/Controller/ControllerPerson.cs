using SakananeWash.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace SakananeWash.Controller
{
    class ControllerPerson
    {
        private Model.ModelPerson person;
        private View.Login login;
        private View.CreateAccount create;
        private View.EditProfile edit;

        public ControllerPerson(View.Login login)
        {
            this.login = login;
            person = new Model.ModelPerson();
        }

        public ControllerPerson(View.CreateAccount create)
        {
            this.create = create;
            person = new Model.ModelPerson();
        }

        public ControllerPerson(View.EditProfile edit)
        {
            this.edit = edit;
            person = new Model.ModelPerson();
        }

        public void LoginCheck()
        {
            person.NamaMember = login.txtUsername.Text;
            person.Email = login.txtUsername.Text;
            person.Password = login.txtPassword.Password;

            bool result = person.LoginCheck();
            if (result)
            {
                login.NavigationService.Navigate(new View.Homepage());
            }

            else
            {
                MessageBox.Show("Login failed, check your email & password.");
                login.txtUsername.Text = "";
                login.txtPassword.Password = "";
                login.txtUsername.Focus();
            }
        }

        public void InsertPerson()
        {
            person.NamaMember = create.txtName.Text;
            person.NoHp = create.txtHp.Text;
            person.Email = create.txtEmail.Text;
            person.Password = create.txtPassword.Password;

            bool result = person.InsertPerson();
            if (result == true)
            {
                MessageBox.Show("Register Success!");
                create.NavigationService.Navigate(new View.Login());
            }

            else
            {
                MessageBox.Show("Check your data, make sure you fill all the data correctly.");
            }
        }

        public void EditPerson()
        {
            person.NamaMember = edit.txtName.Text;
            person.NoHp = edit.txtHp.Text;
            person.Email = edit.txtEmail.Text;
            person.Password = edit.txtPassword.Password;

            bool result = person.EditPerson();
            if (result == true)
            {
                MessageBox.Show("Edit Profile Success!");
            }

            else
            {
                MessageBox.Show("Check your data, make sure you fill all the data correctly.");
            }
        }
    }
}
