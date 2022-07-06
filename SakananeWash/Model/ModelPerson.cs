using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SakananeWash.Model
{
    class ModelPerson
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private bool result;

        public static string memberName, memberPhone;
        public static int memberNumber;

        public ModelPerson()
        {
            connection = DBConnection.GetConnection();
        }

        private int idMember;
        private string namaMember, noHp, email, password;

        public int IdMember { get { return idMember; } set { idMember = value; } }
        public string NamaMember { get { return namaMember; } set { namaMember = value; } }
        public string NoHp { get { return noHp; } set { noHp = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }

        public bool LoginCheck()
        {
            query = "SELECT email, password, nama_member, no_hp, id_member FROM member WHERE nama_member = '" + namaMember + "' OR email = '" + email + "' AND password = '" + password + "'";

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if ((dataReader.GetString(0).ToString() == email || dataReader.GetString(2).ToString() == namaMember) && dataReader.GetString(1).ToString() == password)
                {
                    result = true;
                    memberName = dataReader.GetString(2).ToString();
                    memberPhone = dataReader.GetString(3).ToString();
                    memberNumber = dataReader.GetInt16(4);
                }

                else
                {
                    result = false;
                }
            }

            connection.Close();

            return result;
        }

        public bool InsertPerson()
        {
            result = false;

            try
            {
                query = "INSERT INTO member Values ('" + namaMember + "', '" + noHp + "', '" + email + "', '" + password + "')";

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

            return result;
        }

        public bool EditPerson()
        {
            result = false;

            if (namaMember == "" || noHp == "" || email == "" || password == "")
            {
                result = false;
            }

            else
            {
                try
                {
                    query = "UPDATE member set nama_member = '" + namaMember + "', no_hp = '" + noHp + "', email = '" + email + "', password = '" + password + "' WHERE id_member = " + memberNumber + "";

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

                query = "SELECT email, password, nama_member, id_member FROM member WHERE nama_member = '" + namaMember + "' OR email = '" + email + "' AND password = '" + password + "'";

                connection.Open();

                SqlCommand command1 = connection.CreateCommand();
                command1.CommandText = query;

                SqlDataReader dataReader = command1.ExecuteReader();

                dataReader.Read();

                memberName = dataReader.GetString(2).ToString();

                connection.Close();
            }

            return result;
        }
    }
}
