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
            Logowanie view = new Logowanie();
            Model model = new Model();
            LogowaniePresenter presenter = new LogowaniePresenter(model, view);
            Application.Run(view);           
        }
    }
}
