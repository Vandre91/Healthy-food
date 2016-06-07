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
    public partial class UserControl_Your_Recipes : UserControl
    {
        public UserControl_Your_Recipes()
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

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string name = listView1.SelectedItems[0].SubItems[0].Text;
            Recipe recipe = Root.Healthy.AllRecipe.FindHealthyrecipe(name);

            label_Describes.Text = recipe.Name;
            StringBuilder builder = new StringBuilder();
            foreach (var p in recipe.IRecipe)
            {
                builder.Append(p.Balance).Append(" ");
                builder.Append(p.Name).Append('\n');
            }
            string result = builder.ToString();
            richTextBox1.Text = result;
            richTextBox2.Text = recipe.Describe;
            panel_Show_Recipes.Visible = true;
            panel_Show_Recipes.Focus();
        }

        private void UserControl_Your_Recipes_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var p in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                bool toutfrigo = true;
                foreach (var r in p.IRecipe)
                {
                    bool inginfrigo = false;
                    foreach (var s in Root.Healthy.Stocks.IStock)
                    {
                        if (r.Name == s.Name)
                        {
                            inginfrigo= true;
                            break;
                        }
                    }
                    if (!inginfrigo)
                    {
                        toutfrigo = false;
                        break;
                    }

                }
                if (toutfrigo)
                {
                    string[] row = { p.Name, p.Describe };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
