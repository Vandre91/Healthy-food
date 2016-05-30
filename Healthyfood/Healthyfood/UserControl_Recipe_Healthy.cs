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
            panel_Show_Recipes.Visible = true;
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
