using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface ILogowanie
    {
        // eventy logowania
        event Func<bool> SqlConnection;
        event Func<string, string, bool> Login;

        // eventy 

        event Func<string, bool> Register_Rejestracja;
    }
}
