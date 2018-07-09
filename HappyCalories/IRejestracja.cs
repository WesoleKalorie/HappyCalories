using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface IRejestracja
    {
        event Action ChangeLogin;
        event Func<string, bool> Register;
    }
}
