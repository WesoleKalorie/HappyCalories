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
    public partial class Rejestracja : Form, IRejestracja
    {
        Edycja edit = new Edycja();

        public Rejestracja()
        {
            InitializeComponent();

            edit.AddUser += Edit_AddUser;
        }

        private bool Edit_AddUser(string login, string password, int age, int weight, int height , int lifeStyle, string allergens)
        {
            return AddUser_Edycja(login, password, age, weight, height, lifeStyle, allergens);
        }

        public event Action ChangeLogin;
        public event Func<string, bool> Register;
        public event Func<string, string,int,  int, int, int, string, bool> AddUser_Edycja;

        private void label_dologowania_Click(object sender, EventArgs e)
        {
            ChangeLogin();
            this.Hide();

        }

        private void button_zarejestruj_Click(object sender, EventArgs e)
        {
            string login = textBox_Login.Text.Trim(' ');
            string passwd = textBox_haslo.Text.Trim(' ');

            if (login != "" && passwd != "")
            {
                if (Register(login) == true)
                {
                    edit.Show();

                    edit.Login = login;
                    edit.Password = passwd;

                    this.Hide();
                }
                else MessageBox.Show("Taki login juz istnieje");
            }
            else
                MessageBox.Show("Musisz wypełnić oba pola!");
        }
       
        
    }
}
