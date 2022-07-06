using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace SakananeWash.Model
{
    class DBConnection
    {
        //1. Declare object sqlconnection
        private static SqlConnection connection;

        //2. Funtion set connection
        public static SqlConnection GetConnection()
        {
            connection = new SqlConnection();
            //Set
            connection.ConnectionString = "Data Source = LAPTOP-JS0B8SKA\\SQLEXPRESS;" +
                "Initial Catalog = FPSakananeWash;" +
                "Integrated Security = true;";
            return connection;
        }

        //3. Funtion test
        public void TestConnection()
        {
            //Call connection
            GetConnection();
            try
            {
                connection.Open();
                MessageBox.Show("Connection Success");
            }

            catch (SqlException se)
            {
                MessageBox.Show("Connection Failed" + se);
            }

            connection.Close();
        }
    }
}
