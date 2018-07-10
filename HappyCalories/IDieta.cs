using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface IDieta
    {
        event Action Cancel;
        event Func<string, string[]> GetProducts;
        event Func<List<string[]>> GetDishes;
    }
}
