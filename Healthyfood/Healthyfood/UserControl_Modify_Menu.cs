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
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UserControl_Modify_Menu_Enter(object sender, EventArgs e)
        {
            
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }
        #region Calendar
        private void textBox_e_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
            monthCalendar1.Visible = false;
        }

        private void textBox_b_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar2.Visible = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_b.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_e.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }
        #endregion
    }
}
