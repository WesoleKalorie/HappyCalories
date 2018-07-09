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
       
        // eventy logowanie
        public event Func<bool> SqlConnection;
        public event Func<string, string, bool> Login;

        // eventy Rejestracja
        public event Func<string, bool> Register_Rejestracja;

        public Logowanie()
        {
            InitializeComponent();

            rejs.ChangeLogin += Rejs_ChangeLogin;
            rejs.Register += Rejs_Register;
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
                    MessageBox.Show("Przeszło");
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
