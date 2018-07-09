using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface IKalkulatorKalorii
    {
        event Func<string[]> GetAllNameOfProduct;
        event Func<string[]> GetAllCaloriesOfProduct;
        event Action Cancel;
    }
}
