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
        public Logowanie()
        {
            InitializeComponent();
        }

        public event Func<bool> SqlConnection;

        private void Logowanie_Load(object sender, EventArgs e)
        {
            

            if (SqlConnection() == true) MessageBox.Show("OK");
            else MessageBox.Show("NOT OK");
        }
    }
}
