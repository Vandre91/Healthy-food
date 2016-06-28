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
    public partial class UserControl_Modify_Menu : UserControl
    {
        public UserControl_Modify_Menu()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
