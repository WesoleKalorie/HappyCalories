using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    interface IKonto
    {
        // events Konto.cs
        event Func<string, string, string[]> LoadUserData;

        // events KalkulatorKalorii.cs
        event Func<string[]> GetAllNameOfProduct;
        event Func<string[]> GetAllCaloriesOfProduct;

        //eventy GeneratorDiety.cs
        event Func<string, string[]> GetProducts;
        event Func<List<string[]>> GetDishes;


    }
}
