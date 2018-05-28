using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface IView
    {
        // eventy LoginView;
        event Func<bool> SqlConnection;
    }
}
