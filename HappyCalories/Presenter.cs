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
