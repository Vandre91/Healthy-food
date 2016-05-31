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
                string[] row = { p.Name, p.Describe };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }

        }
    }
}
