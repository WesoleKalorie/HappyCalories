using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    class LoginViewPresenter
    {
        IView view;
        Model model;

        public LoginViewPresenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;

            //view.SqlConnection += View_SqlConnection;
        }

       /* private bool View_SqlConnection()
        {

            // komentarz sobie dodam
            //return model.MySqlConnection();
        } */
    }
}
