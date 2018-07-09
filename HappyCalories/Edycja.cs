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
    public partial class Edycja : Form
    {
        private string password;

        public Edycja()
        {
            InitializeComponent();
        }

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


    }
}
