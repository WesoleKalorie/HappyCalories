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
    public partial class Dieta : Form, IDieta
    {

        public event Action Cancel;
        public event Func<string, string[]> GetProducts;
        public event Func<List<string[]>> GetDishes;

        private double dzk;
        private string login;
        private List<string[]> dishes;
        private string[] products;

        public double Dzk
        {
            get { return this.dzk; }
            set { this.dzk = value; }
        }

        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public Dieta()
        {
            InitializeComponent();
        }

        private void Dieta_Load(object sender, EventArgs e)
        {
            int breakfast = Convert.ToInt16(dzk * 0.3);
            int soup = Convert.ToInt16(dzk * 0.1);
            int dinner_meal = Convert.ToInt16(dzk * 0.25);
            int dessert = Convert.ToInt16(dzk * 0.15);
            int supper = Convert.ToInt16(dzk * 0.20);

            bool breakfast_check = false;
            bool soup_check = false;
            bool dinner_meal_check = false;
            bool dessert_check = false;
            bool supper_check = false;

            listView_dania.Items[0].SubItems[1].Text = breakfast.ToString();
            listView_dania.Items[1].SubItems[1].Text = soup.ToString();
            listView_dania.Items[2].SubItems[1].Text = dinner_meal.ToString();
            listView_dania.Items[3].SubItems[1].Text = dessert.ToString();
            listView_dania.Items[4].SubItems[1].Text = supper.ToString();

            
            string[] products = new string[791];
            products = GetProducts(this.login);

            this.products = products;

            List<string[]> dishes = new List<string[]>();
            dishes = GetDishes();

            this.dishes = dishes;

        
            for(int i = 0; i < dishes[0].Count(); i++)
            {
                switch(dishes[3][i])
                {
                    case "sniadanie":
                        listView_dania.Items[0].Text = dishes[0][i];
                        break;
                    case "zupa":
                        listView_dania.Items[1].Text = dishes[0][i];
                        break;
                    case "danie główne":
                        listView_dania.Items[2].Text = dishes[0][i];
                        break;
                    case "deser":
                        listView_dania.Items[3].Text = dishes[0][i];
                        break;
                    case "kolacja":
                        listView_dania.Items[4].Text = dishes[0][i];
                        break;
                }
            }
            

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void button_reload_Click(object sender, EventArgs e)
        {

            int rnd;

            for (int i = 0; i < dishes[0].Count(); i++)
            {
                Random random = new Random();

                rnd = random.Next(0, dishes[0].Count());

                switch (dishes[3][rnd])
                {
                    case "sniadanie":
                        listView_dania.Items[0].Text = dishes[0][rnd];
                        break;
                    case "zupa":
                        listView_dania.Items[1].Text = dishes[0][rnd];
                        break;
                    case "danie główne":
                        listView_dania.Items[2].Text = dishes[0][rnd];
                        break;
                    case "deser":
                        listView_dania.Items[3].Text = dishes[0][rnd];
                        break;
                    case "kolacja":
                        listView_dania.Items[4].Text = dishes[0][rnd];
                        break;
                }
            }


        }

        private void listView_dania_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_dania.SelectedItems.Count > 0)
            {
                listView_produkty.Items.Clear();

                int index = 0;

                string name = listView_dania.SelectedItems[0].Text;

                for(int i = 0; i < dishes[0].Count(); i++ )
                {
                    if (name == dishes[0][i]) index = i;
                }

                string[] products = dishes[1][index].Split(',');
                string[] content = dishes[2][index].Split(',');

                int count = content.Count();

                for(int i = 0; i < count; i++)
                {
                    listView_produkty.Items.Add(products[i]);
                    listView_produkty.Items[i].SubItems.Add(content[i]);
                }
                
                
            }
        }
    }
}
