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
using System.IO;

namespace Healthyfood
{
    public partial class UserControl_Recipe_Healthy : UserControl
    {
        
        public UserControl_Recipe_Healthy()
        {
            InitializeComponent();
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            string name = listView1.SelectedItems[0].SubItems[0].Text;
            Recipe recipe = Root.Healthy.AllRecipe.FindHealthyrecipe(name);

            label_Name.Text = recipe.Name;
            StringBuilder builder = new StringBuilder();
            foreach (var p in recipe.IRecipe)
            {
                builder.Append(p.Balance).Append(" ");
                builder.Append(p.Name).Append('\n');
            }
            string result = builder.ToString();
            richTextBox1.Text = result;
            richTextBox_Describe.Text = recipe.Describe;
            panel_Show_Recipes.Visible = true;
            panel_Show_Recipes.Focus();
            
        }

        private void button_Back_Panel_Click(object sender, EventArgs e)
        {
            panel_Show_Recipes.Visible = false;
        }

        private void button_Read_Click(object sender, EventArgs e)
        {

        }

        private void button_Heat_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_Recipe_Healthy_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            foreach (var p in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                double _allcalories = 0.0;
                int _light = 0;
                int _normal = 0;
                int _fat = 0;
                foreach (var r in p.IRecipe)
                {
                    foreach (KeyValuePair<string, int> Currentpair in Root.Healthy.Calories.Cal )
                    {
                        if (Currentpair.Key == r.Name)
                        {
                            double cal = Currentpair.Value;
                            double quantity = r.Balance;
                            double allcal = Root.Healthy.CalculCal(quantity,cal);
                            _allcalories += allcal;
                            break;
                        }
                    }

                }
                if(Root.Healthy.Profil.Imc <= 18)
                {
                    _light = 1;
                }
                else if (Root.Healthy.Profil.Imc <= 25 && Root.Healthy.Profil.Imc >= 19)
                {
                    _normal = 1;
                }
                else if (Root.Healthy.Profil.Imc > 25)
                {
                    _fat = 1;
                }

                if(_light == 1 && _allcalories > 2700)
                {
                    string[] row = { p.Name, p.Describe, _allcalories.ToString() };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                }
                if (_normal == 1 && _allcalories > 2000 && _allcalories <2700)
                {
                    string[] row = { p.Name, p.Describe, _allcalories.ToString() };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                }
                if (_fat == 1 && _allcalories < 2000)
                {
                    string[] row = { p.Name, p.Describe, _allcalories.ToString() };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                }
            }

        }
    }
}
