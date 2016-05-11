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
    public partial class UserControl_Reserve_Add_Remove : UserControl
    {
        static int count = Global.viande.Count;
        string[] _beef = new string[count];
        
        public UserControl_Reserve_Add_Remove()
        {
            InitializeComponent();
            int i = 0;
            Global.viande.CopyTo(_beef);
            foreach (var p in _beef)
            {
                ListViewItem item = new ListViewItem(_beef[i]);
                listView1.Items.Add(item);
                i++;
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Name.Text = listView1.SelectedItems[0].Text;
        }

        private void button_save_drink_Click(object sender, EventArgs e)
        {

        }

        private void button_back1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
