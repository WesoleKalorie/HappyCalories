using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface IRejestracja
    {
        // eventy Rejestracja.cs
        event Action ChangeLogin;
        event Func<string, bool> Register;

        //eventy Edycja.cs
        event Func<string, string, int, int, int, int, string, bool> AddUser_Edycja;
    }
}
