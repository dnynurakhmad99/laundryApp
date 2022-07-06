using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SakananeWash.Model
{
    class ModelChat
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private bool result;

        public static string teksChat;

        public ModelChat()
        {
            connection = DBConnection.GetConnection();
        }

        private int kdChat;
        public string isiChat;

        public int KdChat { get { return kdChat; } set { kdChat = value; } }
        public string IsiChat { get { return isiChat; } set { isiChat = value; } }

        public bool TeksChat()
        {
            result = false;

            if (isiChat == "")
            {
                result = false;
            }

            else
            {
                try
                {
                    query = "INSERT INTO chat Values ('" + isiChat + "', " + Model.ModelLaundry.laundryNumber + ", " + Model.ModelPerson.memberNumber + ")";


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

                query = "SELECT isi_chat, kd_chat FROM chat WHERE isi_chat = '" + isiChat + "'";

                connection.Open();

                SqlCommand command1 = connection.CreateCommand();
                command1.CommandText = query;

                SqlDataReader dataReader = command1.ExecuteReader();

                dataReader.Read();

                teksChat = dataReader.GetString(0).ToString();

                connection.Close();
            }

            return result;
        }
    }
}
