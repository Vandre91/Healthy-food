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
    public partial class UserControl_Recipe : UserControl
    {
        public UserControl_Recipe()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl_Recipe_Healthy1.Visible = true;
            userControl_Recipe_Healthy1.Focus();
        }

        private void button2_yours_recipes_Click(object sender, EventArgs e)
        {
            userControl_Your_Recipes1.Visible = true;
            userControl_Your_Recipes1.Focus();
        }

        private void button3_world_recipes_Click(object sender, EventArgs e)
        {
            userControl_World_Recipe1.Visible = true;
            userControl_World_Recipe1.Focus();
        }
    }
}
