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
    public partial class LoginView : Form, IView
    {
        
        public LoginView()
        {
            InitializeComponent();
        }

        public event Func<bool> SqlConnection;

        private void LoginView_Load(object sender, EventArgs e)
        {
            bool sqlConnect = SqlConnection();

            if (sqlConnect == true) MessageBox.Show("Udało nawiązać się połączenie z bazą danych");
            else MessageBox.Show("Nie udało nawiązać się połączenie z bazą danych");
        }
        
       
    }
}
