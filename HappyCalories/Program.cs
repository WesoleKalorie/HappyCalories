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
            Logowanie view2 = new Logowanie();
            Rejestracja view3 = new Rejestracja();
            Konto view4 = new Konto();
            Edycja view5 = new Edycja();
            KalkulatorKalorii view6 = new KalkulatorKalorii();
            Dieta view7 = new Dieta();
            Model model = new Model();
            LoginViewPresenter loginViewPresenter = new LoginViewPresenter(model, loginView);
            Application.Run(view7);           
        }
    }
}
