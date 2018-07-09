using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface ILogowanie
    {
        // eventy Logowanie.cs
        event Func<bool> SqlConnection;
        event Func<string, string, bool> Login;

        // eventy Rejestracja.cs
        event Func<string, bool> Register_Rejestracja;

        // eventy Edycja.cs
        event Func<string, string, int, int, int, int, string, bool> AddUser_Edycja;
    }
}
