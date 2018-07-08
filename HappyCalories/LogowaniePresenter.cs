using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    class LogowaniePresenter
    {
        ILogowanie view;
        Model model;

        public LogowaniePresenter(Model model, ILogowanie view)
        {
            this.model = model;
            this.view = view;

            view.SqlConnection += View_SqlConnection;
        }

        private bool View_SqlConnection()
        {

           return model.MySqlConnection();
        } 
    }
}
