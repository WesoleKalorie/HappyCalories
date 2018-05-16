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
        }
    }
}
