using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    class Presenter
    {
        ILogowanie view;
        Model model;

        public Presenter(Model model, ILogowanie view)
        {
            this.model = model;
            this.view = view;

            view.SqlConnection += View_SqlConnection;
            view.Login += View_Login;
            view.Register_Rejestracja += View_Register_Rejestracja;
            view.AddUser_Edycja += View_AddUser_Edycja;
            view.LoadUserData += View_LoadUserData;
            view.GetAllNameOfProduct += View_GetAllNameOfProduct;
            view.GetAllCaloriesOfProduct += View_GetAllCaloriesOfProduct;

        }

        private string[] View_GetAllCaloriesOfProduct()
        {
            return model.GetCalories();
        }

        private string[] View_GetAllNameOfProduct()
        {
            return model.GetNames();
        }

        private string[] View_LoadUserData(string login, string password)
        {
            return model.LoadData(login, password);
        }

        private bool View_AddUser_Edycja(string login, string password, int age, int weight, int height, int lifeStyle, string allergens)
        {
            return model.AddUser(login, password, age, weight, height, lifeStyle, allergens);
        }

        private bool View_Register_Rejestracja(string login)
        {
            return model.Registr(login);
        }

        private bool View_Login(string login, string password)
        {
            return model.Login(login, password);
        }

        private bool View_SqlConnection()
        {

           return model.MySqlConnection();
        } 
    }
}
