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
    public partial class UserControl_Menu : UserControl
    {
        public UserControl_Menu()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            userControl_Add_Menu1.Visible = true;
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            userControl_Modify_Menu1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_Menu_Enter(object sender, EventArgs e)
        {

        }
    }
}
