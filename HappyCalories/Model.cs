using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HappyCalories
{
    class Model
    {
        bool sqlConnection()
        {
            try
            {
                SqlConnection polaczenie = new SqlConnection(@"Data source=SERWER\SQLEXPRESS;
                                                             database=adresy;
                                                             User id=sa;
                                                             Password=haslo;");
                polaczenie.Open();

                return true;

            }
            catch
            {

                return false;
            }
        }

    }
}
