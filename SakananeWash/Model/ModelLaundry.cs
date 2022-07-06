using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;

namespace SakananeWash.Model
{
    class ModelLaundry
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private bool result;

        public static string laundryAll, laundryName1, laundryName2, laundryName3, laundryName4, laundryName5, laundryName6, laundryAddress, laundryPhone;
        public static int laundryNumber, laundryPrice, laundryPrice1, laundryPrice2, laundryPrice3, laundryPrice4, laundryPrice5, laundryPrice6, laundryDelivery;

        public ModelLaundry()
        {
            connection = DBConnection.GetConnection();
        }

        private int idLaundry;
        private string namaLaundry, namaPemilik, email, password, alamat, noHp, antarJemput;

        public int IdLaundry { get { return idLaundry; } set { idLaundry = value; } }
        public string NamaLaundry { get { return namaLaundry; } set { namaLaundry = value; } }
        public string NamaPemilik { get { return namaPemilik; } set { namaPemilik = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Alamat { get { return alamat; } set { alamat = value; } }
        public string NoHp { get { return noHp; } set { noHp = value; } }
        public string AntarJemput { get { return antarJemput; } set { antarJemput = value; } }

        public void Laundry1()
        {
            query = "SELECT nama_laundry, alamat, harga, antar_jemput, no_hp, id_laundry FROM laundry WHERE id_laundry = 1";

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            laundryAll = dataReader.GetString(0).ToString();
            laundryPrice = dataReader.GetInt16(2);
            laundryName1 = dataReader.GetString(0).ToString();
            laundryAddress = dataReader.GetString(1).ToString();
            laundryPrice1 = dataReader.GetInt16(2);
            laundryDelivery = dataReader.GetInt16(3);
            laundryPhone = dataReader.GetString(4).ToString();
            laundryNumber = dataReader.GetInt16(5);

            connection.Close();
        }

        public void Laundry2()
        {
            query = "SELECT nama_laundry, alamat, harga, antar_jemput, no_hp, id_laundry FROM laundry WHERE id_laundry = 2";

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            laundryAll = dataReader.GetString(0).ToString();
            laundryPrice = dataReader.GetInt16(2);
            laundryName2 = dataReader.GetString(0).ToString();
            laundryAddress = dataReader.GetString(1).ToString();
            laundryPrice2 = dataReader.GetInt16(2);
            laundryDelivery = dataReader.GetInt16(3);
            laundryPhone = dataReader.GetString(4).ToString();
            laundryNumber = dataReader.GetInt16(5);

            connection.Close();
        }

        public void Laundry3()
        {
            query = "SELECT nama_laundry, alamat, harga, antar_jemput, no_hp, id_laundry FROM laundry WHERE id_laundry = 3";

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            laundryAll = dataReader.GetString(0).ToString();
            laundryPrice = dataReader.GetInt16(2);
            laundryName3 = dataReader.GetString(0).ToString();
            laundryAddress = dataReader.GetString(1).ToString();
            laundryPrice3 = dataReader.GetInt16(2);
            laundryDelivery = dataReader.GetInt16(3);
            laundryPhone = dataReader.GetString(4).ToString();
            laundryNumber = dataReader.GetInt16(5);

            connection.Close();
        }

        public void Laundry4()
        {
            query = "SELECT nama_laundry, alamat, harga, antar_jemput, no_hp, id_laundry FROM laundry WHERE id_laundry = 4";

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            laundryAll = dataReader.GetString(0).ToString();
            laundryPrice = dataReader.GetInt16(2);
            laundryName4 = dataReader.GetString(0).ToString();
            laundryAddress = dataReader.GetString(1).ToString();
            laundryPrice4 = dataReader.GetInt16(2);
            laundryDelivery = dataReader.GetInt16(3);
            laundryPhone = dataReader.GetString(4).ToString();
            laundryNumber = dataReader.GetInt16(5);

            connection.Close();
        }

        public void Laundry5()
        {
            query = "SELECT nama_laundry, alamat, harga, antar_jemput, no_hp, id_laundry FROM laundry WHERE id_laundry = 5";

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            laundryAll = dataReader.GetString(0).ToString();
            laundryPrice = dataReader.GetInt16(2);
            laundryName5 = dataReader.GetString(0).ToString();
            laundryAddress = dataReader.GetString(1).ToString();
            laundryPrice5 = dataReader.GetInt16(2);
            laundryDelivery = dataReader.GetInt16(3);
            laundryPhone = dataReader.GetString(4).ToString();
            laundryNumber = dataReader.GetInt16(5);

            connection.Close();
        }

        public void Laundry6()
        {
            query = "SELECT nama_laundry, alamat, harga, antar_jemput, no_hp, id_laundry FROM laundry WHERE id_laundry = 6";

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            laundryAll = dataReader.GetString(0).ToString();
            laundryPrice = dataReader.GetInt16(2);
            laundryName6 = dataReader.GetString(0).ToString();
            laundryAddress = dataReader.GetString(1).ToString();
            laundryPrice6 = dataReader.GetInt16(2);
            laundryDelivery = dataReader.GetInt16(3);
            laundryPhone = dataReader.GetString(4).ToString();
            laundryNumber = dataReader.GetInt16(5);

            connection.Close();
        }
    }
}
