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

        public bool AddUser(string login, string password, int age, int weight, int height, int lifeStyle, string allergens)
        {
            MySqlCommand comm = connect.CreateCommand();

            User user = new User(login, password, age, weight, height, lifeStyle, allergens);

            comm.CommandText = "INSERT INTO uzytkownicy(login,haslo,wiek,waga,wzrost,tryb_zycia,alergeny)" +
                                " VALUES(@login, @haslo, @wiek, @waga, @wzrost, @tryb_zycia, @alergeny)";
            comm.Parameters.AddWithValue("@login",user.Login);
            comm.Parameters.AddWithValue("@haslo", user.Password);
            comm.Parameters.AddWithValue("@wiek", user.Age);
            comm.Parameters.AddWithValue("@waga", user.Weight);
            comm.Parameters.AddWithValue("@wzrost", user.Height);
            comm.Parameters.AddWithValue("@tryb_zycia", user.LifeStyle);
            comm.Parameters.AddWithValue("@alergeny", user.Allergens);
            comm.ExecuteNonQuery();
            comm.Parameters.Clear();

            return true;
        }

        public string[] LoadData(string login, string password)
        {
            string log = login.Insert(0, '"'.ToString()).Insert(login.Count() + 1, '"'.ToString());
            string passwd = password.Insert(0, '"'.ToString()).Insert(password.Count() + 1, '"'.ToString());
            string[] data = new string[6];

            MySqlCommand comm = connect.CreateCommand();

            comm.CommandText = "SELECT login,wiek,wzrost,waga,tryb_zycia,alergeny FROM uzytkownicy WHERE login LIKE "+log+" AND haslo LIKE "+passwd+";";
            MySqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                data[0] = reader["login"].ToString();
                data[1] = reader["wiek"].ToString();
                data[2] = reader["wzrost"].ToString();
                data[3] = reader["waga"].ToString();
                data[4] = reader["tryb_zycia"].ToString();
                data[5] = reader["alergeny"].ToString();
            }

            reader.Close();

            return data;
        }

        public string[] GetNames()
        {
            string[] names = new string[791];
            int i = 0;

            MySqlCommand comm = connect.CreateCommand();

            comm.CommandText = "SELECT nazwa FROM produkty;";

            MySqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                names[i] = reader["nazwa"].ToString();
                i++;
            }

            reader.Close();

            return names;
        }

        public string[] GetCalories()
        {
            string[] calories = new string[791];
            int i = 0;

            MySqlCommand comm = connect.CreateCommand();

            comm.CommandText = "SELECT kalorycznosc FROM produkty;";

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                calories[i] = reader["kalorycznosc"].ToString();
                i++;
            }

            reader.Close();

            return calories;
        }

        public string[] GetProducts(string login)
        {
            string[] names;
            string log = login.Insert(0, '"'.ToString()).Insert(login.Count() + 1, '"'.ToString());
            int counter = 0;
            int i = 0;

            MySqlCommand comm = connect.CreateCommand();
            comm.CommandText = "SELECT p.nazwa, p.alergeny FROM produkty p, uzytkownicy u WHERE u.login LIKE " +log+ " AND p.alergeny NOT LIKE u.alergeny; ";

            MySqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                counter++;
            }

            reader.Close();

            MySqlCommand comm2 = connect.CreateCommand();
            comm2.CommandText = "SELECT p.nazwa, p.alergeny FROM produkty p, uzytkownicy u WHERE u.login LIKE " + log + " AND p.alergeny NOT LIKE u.alergeny; ";

            MySqlDataReader reader2 = comm.ExecuteReader();

            names = new string[counter];

            while(reader2.Read())
            {
                names[i] = reader2["nazwa"].ToString();
                i++;
            }

            reader2.Close();

            return names;
        }

        public List<string[]> GetDishes()
        {
            List<string[]> dishes = new List<string[]>();

            string[] names = new string[35];
            string[] products = new string[35];
            string[] content = new string[35];
            string[] type = new string[35];

            int i = 0;

            MySqlCommand comm = connect.CreateCommand();
            comm.CommandText = "SELECT nazwa, produkty, zawartosc, typ FROM dania";

            MySqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                names[i] = reader["nazwa"].ToString();
                products[i] = reader["produkty"].ToString();
                content[i] = reader["zawartosc"].ToString();
                type[i] = reader["typ"].ToString();

                i++;
            }

            reader.Close();

            dishes.Add(names);
            dishes.Add(products);
            dishes.Add(content);
            dishes.Add(type);

            return dishes;
        }

    }

    
        
}
