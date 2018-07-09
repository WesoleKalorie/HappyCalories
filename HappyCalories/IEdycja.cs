using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface IEdycja
    {
        event Func<string, string,int, int, int, int, string, bool> AddUser;
    }
}
