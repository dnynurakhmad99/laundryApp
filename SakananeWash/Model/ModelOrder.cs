using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SakananeWash.Model
{
    class ModelOrder
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private bool result;

        public ModelOrder()
        {
            connection = DBConnection.GetConnection();
        }

        public string beratCucian;
        public char antarJemput;

        public string BeratCucian { get { return beratCucian; } set { beratCucian = value; } }
        public char AntarJemput { get { return antarJemput; } set { antarJemput = value; } }

        public bool Orderan()
        {
            result = false;

            if (beratCucian == "" || View.DetailOrder.jemput == ' ')
            {
                result = false;
            }

            else
            {
                try
                {
                    query = "INSERT INTO order_cucian Values (" + beratCucian + ", '" + View.DetailOrder.jemput + "', " + Model.ModelLaundry.laundryNumber + ", " + Model.ModelPerson.memberNumber + ")";

                    connection.Open();

                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    result = true;

                    connection.Close();
                }

                catch (SqlException)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public bool Bayar()
        {
            result = false;

            if (View.DetailOrder.jemput == 'Y')
            {
                try
                {
                    query = "INSERT INTO pembayaran Values ((" + Model.ModelLaundry.laundryPrice + " * " + beratCucian + ") + " + Model.ModelLaundry.laundryDelivery + ", '" + View.DetailOrder.via + "', " + Model.ModelLaundry.laundryNumber + ", " + Model.ModelPerson.memberNumber + ")";

                    connection.Open();

                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    result = true;

                    connection.Close();
                }

                catch (SqlException)
                {

                }
            }

            else
            {
                try
                {
                    query = "INSERT INTO pembayaran Values ((" + Model.ModelLaundry.laundryPrice + " * " + beratCucian + "), '" + View.DetailOrder.via + "', " + Model.ModelLaundry.laundryNumber + ", " + Model.ModelPerson.memberNumber + ")";

                    connection.Open();

                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    result = true;

                    connection.Close();
                }

                catch (SqlException)
                {

                }
            }

            return result;
        }
    }
}
