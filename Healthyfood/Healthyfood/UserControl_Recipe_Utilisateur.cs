using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthyfood
{
    public partial class UserControl_Recipe_Utilisateur : UserControl
    {
        public UserControl_Recipe_Utilisateur()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void label_Beef_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_Drink_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_poultry_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_vegetable_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_fruit_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_Milk_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_feculent_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_grasse_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_dessert_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_crustace_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_plante_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_backerie_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_fish_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
            button_Ok.Visible = false;
            button_back1.Visible = false;
        }
    }
}
