using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockFood;

namespace Healthyfood
{
    public partial class UserControl_Reserve_Add_Remove : UserControl
    {
        static int countv = Global.viande.Count;
        static int countd = Global.boisson.Count;
        string[] _beef = new string[countv];
        string[] _drink = new string[countd];


        public UserControl_Reserve_Add_Remove()
        {
            InitializeComponent();
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(textBox_Date.Text);
            int quantity = Int32.Parse(textBox_Quantity.Text);
            Global.Stocks.AddIngredient("viande",textBox_Name.Text,quantity,date);
            textBox_Name.Clear();
            textBox_Quantity.Clear();
            textBox_Date.Clear();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Name.Text = listView1.SelectedItems[0].Text;
        }

        private void button_save_drink_Click(object sender, EventArgs e)
        {

        }

        private void button_back1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UserControl_Reserve_Add_Remove_Enter(object sender, EventArgs e)
        {
            int v = 0;
            int b = 0;
            Global.viande.CopyTo(_beef);
            Global.boisson.CopyTo(_drink);
            foreach (var p in _beef)
            {
                ListViewItem item = new ListViewItem(_beef[v]);
                listView1.Items.Add(item);
                v++;
            }
            foreach (var p in _drink)
            {
                ListViewItem item = new ListViewItem(_drink[b]);
                listView2.Items.Add(item);
                b++;
            }
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Name_drink.Text = listView2.SelectedItems[0].Text;
        }
    }
}
