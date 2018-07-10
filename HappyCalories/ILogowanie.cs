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

        // eventy Konto.cs
        event Func<string, string, string[]> LoadUserData;

        // events KalkulatorKalorii.cs
        event Func<string[]> GetAllNameOfProduct;
        event Func<string[]> GetAllCaloriesOfProduct;

        //eventy GeneratorDiety.cs
        event Func<string, string[]> GetProducts;
        event Func<List<string[]>> GetDishes;
    }
}
