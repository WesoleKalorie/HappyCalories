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

        public bool MySqlConnection()
        {
            connectString = "SERVER=sql7.freemysqlhosting.net;PORT=3306;DATABASE=sql7240215;UID=sql7240215;PASSWORD=U7NDtxxRdE;SSLMODE=none";

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
    }
}
