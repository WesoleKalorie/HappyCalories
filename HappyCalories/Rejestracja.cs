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
        }

        public event Action ChangeLogin;
        public event Func<string, bool> Register;

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
