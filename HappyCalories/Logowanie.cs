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
    public partial class Logowanie : Form, ILogowanie
    {
        Rejestracja rejs = new Rejestracja();
        Konto konto = new Konto();
       
        // eventy Logowanie.cs
        public event Func<bool> SqlConnection;
        public event Func<string, string, bool> Login;

        // eventy Rejestracja.cs
        public event Func<string, bool> Register_Rejestracja;

        // eventy Edycja.cs
        public event Func<string, string, int, int, int, int, string, bool> AddUser_Edycja;

        // eventy Konto.cs
        public event Func<string, string, string[]> LoadUserData;

        // events KalkulatorKalorii.cs
        public event Func<string[]> GetAllNameOfProduct;
        public event Func<string[]> GetAllCaloriesOfProduct;

        //eventy GeneratorDiety.cs
        public event Func<string, string[]> GetProducts;
        public event Func<List<string[]>> GetDishes;

        public Logowanie()
        {
            InitializeComponent();

            rejs.ChangeLogin += Rejs_ChangeLogin;
            rejs.Register += Rejs_Register;
            rejs.AddUser_Edycja += Rejs_AddUser_Edycja;
            konto.LoadUserData += Konto_LoadUserData;
            konto.GetAllCaloriesOfProduct += Konto_GetAllCaloriesOfProduct;
            konto.GetAllNameOfProduct += Konto_GetAllNameOfProduct;
            konto.GetProducts += Konto_GetProducts;
            konto.GetDishes += Konto_GetDishes;
          
        }

        private List<string[]> Konto_GetDishes()
        {
            return GetDishes();
        }

        private string[] Konto_GetProducts(string login)
        {
            return GetProducts(login);
        }

        private string[] Konto_GetAllNameOfProduct()
        {
            return GetAllNameOfProduct();
        }

        private string[] Konto_GetAllCaloriesOfProduct()
        {
            return GetAllCaloriesOfProduct();
        }

        private string[] Konto_LoadUserData(string login, string password)
        {
            return LoadUserData(login, password);
        }

        private bool Rejs_AddUser_Edycja(string login, string password, int age, int weight, int height, int lifeStyle, string allergens)
        {
            return AddUser_Edycja(login, password, age, weight, height, lifeStyle, allergens);
        }

        private bool Rejs_Register(string login)
        {
            return Register_Rejestracja(login);
        }

        private void Rejs_ChangeLogin()
        {
            this.Show();
        }
        
        private void Logowanie_Load(object sender, EventArgs e)
        {
            if (SqlConnection() != true) MessageBox.Show("NOT OK"); 
            
        }

        private void button_zaloguj_Click(object sender, EventArgs e)
        {
            string login = textBox_Login.Text.Trim(' ');
            string password = textBox_Haslo.Text.Trim(' ');
            bool goodPass;

            if (login != "" && password != "")
            {
                goodPass = Login(login, password);

                if (goodPass == true)
                {
                    konto.Login = login;
                    konto.Password = password;

                    konto.Show();
                    this.Hide();

                    label_zlehaslo.Visible = false;
                }
                else
                {
                    label_zlehaslo.Visible = true;
                    textBox_Haslo.Clear();
                    textBox_Login.Clear();
                }
            }
            else
                MessageBox.Show("Nalezy wypełnić pole: login i hasło");
        }

        private void label_dorejestracji_Click(object sender, EventArgs e)
        {
            rejs.Show();
            this.Hide();
        }
    }
}
