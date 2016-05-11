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
    public partial class UserControl_Reserve_Add_Remove : UserControl
    {
        public UserControl_Reserve_Add_Remove()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Name.Text = listView1.SelectedItems[0].Text;
        }

        private void listView13_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
