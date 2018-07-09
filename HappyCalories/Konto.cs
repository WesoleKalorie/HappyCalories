using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyCalories
{
    public partial class Konto : Form, IKonto
    {
        KalkulatorKalorii calc = new KalkulatorKalorii();
        Dieta dieta = new Dieta();

        private string login;
        private string password;

        public event Func<string, string, string[]> LoadUserData;

        // events KalkulatorKalorii.cs
        public event Func<string[]> GetAllNameOfProduct;
        public event Func<string[]> GetAllCaloriesOfProduct;

        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

         public Konto()
        {
            InitializeComponent();

            calc.GetAllNameOfProduct += Calc_GetAllNameOfProduct;
            calc.GetAllCaloriesOfProduct += Calc_GetAllCaloriesOfProduct;
            calc.Cancel += Calc_Cancel;
            dieta.Cancel += Dieta_Cancel;
        }

        private void Dieta_Cancel()
        {
            this.Show();
            dieta.Hide();
        }

        private void Calc_Cancel()
        {
            this.Show();
            calc.Hide();
        }

        private string[] Calc_GetAllCaloriesOfProduct()
        {
            return GetAllCaloriesOfProduct();
        }

        private string[] Calc_GetAllNameOfProduct()
        {
            return GetAllNameOfProduct();
        }

        private void Konto_Load(object sender, EventArgs e)
        {
            string[] date = new string[6];
            date = LoadUserData(this.login, this.password);

            double lifeStyle = 0;
            
            label_nick.Text = date[0];
            label_wiek.Text = date[1];
            label_wzrost.Text = date[2];
            label_waga.Text = date[3];
            label_alergeny.Text = date[5];

            switch(date[4])
            {
                case "1":
                    label_tryb.Text = "leżący lub siedzący tryb życia, brak aktywności fizycznej";
                    lifeStyle = 1;
                    break;
                case "2":
                    label_tryb.Text = "praca siedząca, aktywność fizyczna na niskim poziomie";
                    lifeStyle = 1.2;
                    break;
                case "3":
                    label_tryb.Text = "praca nie fizyczna, trening 2 razy w tygodniu";
                    lifeStyle = 1.4;
                    break;
                case "4":
                    label_tryb.Text = "lekka praca fizyczna, trening 3-4 razy w tygodniu";
                    lifeStyle = 1.6;
                    break;
                case "5":
                    label_tryb.Text = "praca fizyczna, trening 5 razy w tygodniu";
                    lifeStyle = 1.8;
                    break;
                case "6":
                    label_tryb.Text = "ciężka praca fizyczna, codzienny trening";
                    lifeStyle = 2.0;
                    break;
            }

            double calories = 66.5 + (13.7 * Convert.ToInt16(date[3])) + (5 * Convert.ToInt16(date[2])) - (6.8 * Convert.ToInt16(date[1]));
            calories *= lifeStyle;

            label_DZK.Text = calories.ToString();
        }

        private void button_wyloguj_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button_edytuj_Click(object sender, EventArgs e)
        {
            

        }

        private void button_kalkulator_Click(object sender, EventArgs e)
        {
            calc.Show();
            this.Hide();
        }

        private void button_dieta_Click(object sender, EventArgs e)
        {
            dieta.Show();
            this.Hide();
        }
    }
}
