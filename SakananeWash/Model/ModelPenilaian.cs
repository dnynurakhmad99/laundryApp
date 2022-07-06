using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SakananeWash.Model
{
    class ModelPenilaian
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private bool result;

        public static string teksUlasan;
        public static int laundryNumber, laundryRating;

        public ModelPenilaian()
        {
            connection = DBConnection.GetConnection();
        }

        private int kdNilai;
        private string rating, ulasan, idLaundry, idMember;

        public int KdNilai { get { return kdNilai; } set { kdNilai = value; } }
        public string Rating { get { return rating; } set { rating = value; } }
        public string Ulasan { get { return ulasan; } set { ulasan = value; } }
        public string IdLaundry { get { return idLaundry; } set { idLaundry = value; } }
        public string IdMember { get { return idMember; } set { idMember = value; } }

        public bool Penilaian()
        {
            result = false;

            if (View.Penilaian.bintang == 0 || ulasan == "")
            {
                result = false;
            }

            else
            {
                try
                {
                    query = "INSERT INTO penilaian Values (" + View.Penilaian.bintang + ", '" + ulasan + "', " + Model.ModelLaundry.laundryNumber + ", " + Model.ModelPerson.memberNumber + ")";

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

                query = "SELECT rating, ulasan, id_laundry, id_member, kd_nilai FROM penilaian WHERE ulasan = '" + ulasan + "'";

                connection.Open();

                SqlCommand command1 = connection.CreateCommand();
                command1.CommandText = query;

                SqlDataReader dataReader = command1.ExecuteReader();

                dataReader.Read();

                laundryRating = dataReader.GetInt16(0);
                teksUlasan = dataReader.GetString(1).ToString();
                laundryNumber = dataReader.GetInt16(2);

                connection.Close();
            }

            return result;
        }
    }
}
