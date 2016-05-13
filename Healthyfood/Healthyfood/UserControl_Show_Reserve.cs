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
    public partial class UserControl_Show_Reserve : UserControl
    {
        
        public UserControl_Show_Reserve()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_Show_Reserve_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (var p in Global.Stocks.IStock)
            {
                string date = Convert.ToString(p.Expiration_Date);
                string[] row = { p.Name, p.Balance.ToString(),date };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }
    }
}
