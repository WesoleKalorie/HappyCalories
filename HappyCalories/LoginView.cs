using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HappyCalories
{
    public partial class LoginView : Form, IView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection polaczenie = new SqlConnection(@"Data source=ec2-54-75-227-92.eu-west-1.compute.amazonaws.com;
                                                             database=d3smaqev4brg5l;
                                                             User id=dabgiwdzivsnni;
                                                             Password=690ec2917fa7a255c72b411966690ce5836b9e35c41469e64e126cd63a1eeaee;");
                polaczenie.Open();

               
            }
            catch
            {
                string message = "nie udało sie połączyć";
                string caption = "Error";
                var result = MessageBox.Show(message,caption, MessageBoxButtons.OK);
                
                
            }
        }

        // znowu sprawdzam, czy jakoś to działa :)
    }
}
