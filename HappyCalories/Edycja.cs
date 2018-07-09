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
    public partial class Edycja : Form, IEdycja
    {
        private string password;

        public Edycja()
        {
            InitializeComponent();
        }

        public event Func<string, string,int, int, int, int, string, bool> AddUser;

        public string Login
        {
            get { return label_nick.Text; }
            set { label_nick.Text = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            string login = Login;
            string passwd = Password;
            int weight = Convert.ToInt16(numericUpDown_waga.Value);
            int height = Convert.ToInt16(numericUpDown_wzrost.Value);
            int lifeStyle = comboBox_tryb.SelectedIndex + 1;
            int age = DateTime.Today.Year - dateTimePicker_urodziny.Value.Year;
            string allergens = "";

            bool goodAdd = false;

            if (checkBox_A1.Checked == true && allergens == "") allergens += "A1";
            else if (checkBox_A1.Checked == true && allergens != "") allergens += "," + "A1";

            if (checkBox_A2.Checked == true && allergens == "") allergens += "A2";
            else if (checkBox_A2.Checked == true && allergens != "") allergens += "," + "A2";

            if (checkBox_A3.Checked == true && allergens == "") allergens += "A3";
            else if (checkBox_A3.Checked == true && allergens != "") allergens += "," + "A3";

            if (checkBox_A4.Checked == true && allergens == "") allergens += "A4";
            else if (checkBox_A4.Checked == true && allergens != "") allergens += "," + "A4";

            if (checkBox_A5.Checked == true && allergens == "") allergens += "A5";
            else if (checkBox_A5.Checked == true && allergens != "") allergens += "," + "A5";

            if (checkBox_A6.Checked == true && allergens == "") allergens += "A6";
            else if (checkBox_A6.Checked == true && allergens != "") allergens += "," + "A6";

            if (checkBox_A7.Checked == true && allergens == "") allergens += "A7";
            else if (checkBox_A7.Checked == true && allergens != "") allergens += "," + "A7";

            if (checkBox_A8.Checked == true && allergens == "") allergens += "A8";
            else if (checkBox_A8.Checked == true && allergens != "") allergens += "," + "A8";

            if (checkBox_A9.Checked == true && allergens == "") allergens += "A9";
            else if (checkBox_A9.Checked == true && allergens != "") allergens += "," + "A9";

            if (checkBox_A10.Checked == true && allergens == "") allergens += "A10";
            else if (checkBox_A10.Checked == true && allergens != "") allergens += "," + "A10";

            if (checkBox_A11.Checked == true && allergens == "") allergens += "A11";
            else if (checkBox_A11.Checked == true && allergens != "") allergens += "," + "A11";

            if (checkBox_A12.Checked == true && allergens == "") allergens += "A12";
            else if (checkBox_A12.Checked == true && allergens != "") allergens += "," + "A12";

            if (checkBox_A13.Checked == true && allergens == "") allergens += "A13";
            else if (checkBox_A13.Checked == true && allergens != "") allergens += "," + "A13";

            if (checkBox_A14.Checked == true && allergens == "") allergens += "A14";
            else if (checkBox_A14.Checked == true && allergens != "") allergens += "," + "A14";


            if (comboBox_tryb.SelectedText != null)
            {
                goodAdd = AddUser(login, passwd, age, weight, height, lifeStyle, allergens);

                Application.Restart();
                Environment.Exit(0);
            }
            else
                MessageBox.Show("Nalezy wybrac poziom trybu zycia!");

        }
    }
}
