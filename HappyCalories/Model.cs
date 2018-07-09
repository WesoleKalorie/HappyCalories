using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace HappyCalories
{
    class Model
    {
        MySqlConnection connect;
        string connectString;

        // Logowanie.cs funcs

        public bool MySqlConnection()
        {
            connectString = "SERVER=localhost;PORT=3306;DATABASE=happycalories;UID=root;PASSWORD=;SSLMODE=none";

            try
            {
                connect = new MySqlConnection();
                connect.ConnectionString = connectString;
                connect.Open();

                

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool Login(string log, string password)
        {
            string login = log.Insert(0, '"'.ToString()).Insert(log.Count() + 1, '"'.ToString());
            string pass = password.Insert(0, '"'.ToString()).Insert(password.Count()+1, '"'.ToString());

            bool loginGood = false;

            MySqlCommand comm = connect.CreateCommand();
            comm.CommandText = "Select login from uzytkownicy where login LIKE "+login+" AND haslo LIKE "+pass+";";

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                if (reader["login"].ToString() != null) loginGood = true;
                else
                    loginGood = false;
            }

            if (loginGood == true)
            {
                reader.Close();
                return loginGood;
            }
            else
            {
                reader.Close();
                return loginGood;
            }
            
        }

        public bool Registr(string log)
        {
            string login = log.Insert(0, '"'.ToString()).Insert(log.Count() + 1, '"'.ToString());
            
            bool loginGood = true;

            MySqlCommand comm = connect.CreateCommand();
            comm.CommandText = "Select login from uzytkownicy where login LIKE " + login +";";

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                if (reader["login"].ToString() != null) loginGood = false;
                else
                    loginGood = true;
            }

            if (loginGood == true)
            {
                reader.Close();
                return loginGood;
            }
            else
            {
                reader.Close();
                return loginGood;
            }
        }
     }

    
        
}
