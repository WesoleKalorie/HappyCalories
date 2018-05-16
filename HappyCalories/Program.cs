using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyCalories
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginView loginView = new LoginView();
            Model model = new Model();
            LoginViewPresenter loginViewPresenter = new LoginViewPresenter(model, loginView);
            Application.Run(loginView);
        }
    }
}
