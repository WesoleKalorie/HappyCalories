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
    public partial class KalkulatorKalorii : Form, IKalkulatorKalorii
    {
        public event Func<string[]> GetAllNameOfProduct;
        public event Func<string[]> GetAllCaloriesOfProduct;
        public event Action Cancel;

        public KalkulatorKalorii()
        {
            InitializeComponent();
        }

        private void KalkulatorKalorii_Load(object sender, EventArgs e)
        {
            string[] names = new string[791];
            names = GetAllNameOfProduct();

            string[] calories = new string[791];
            calories = GetAllCaloriesOfProduct();

            for (int i = 0; i < 791; i++)
                listView_listaproduktow.Items.Add(names[i]).SubItems.Add(calories[i]);
        }

        private void listView_listaproduktow_SelectedIndexChanged(object sender, EventArgs e)
        {
            double result;
            int calories;

            if (listView_listaproduktow.SelectedItems.Count > 0)
            {
                calories = Convert.ToInt16(listView_listaproduktow.SelectedItems[0].SubItems[1].Text);
                result = calories * (Convert.ToDouble(numericUpDown_gramatura.Value) / 100);
                label_kalprod.Text = result.ToString();
            }
        }

        private void textBox_produkt_TextChanged(object sender, EventArgs e)
        {
            ListViewItem foundItem = listView_listaproduktow.FindItemWithText(textBox_produkt.Text, false, 0, true);

            if (foundItem != null) listView_listaproduktow.TopItem = foundItem;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
