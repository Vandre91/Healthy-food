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
    public partial class UserControl_Profil : UserControl
    {
        public UserControl_Profil()
        {
            InitializeComponent();
            timer_refresh.Start();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            userControl_Show_Profil1.Visible = true;
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count <= 0)
            {
                button_Modify.Enabled = true;
            }
            else
            {
                string name = listView1.SelectedItems[0].SubItems[0].Text;
                string lastname = listView1.SelectedItems[0].SubItems[1].Text;
                Profil_Utilisateur profil = Global.Utilisateur.FindUser(name, lastname);
                Global.Profil = profil;
                userControl_Modify_Profil1.Visible = true;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            listView1.Items.Clear();

      
            foreach (var p in Global.Utilisateur.IUtilisateur)
            {
                string[] row = { p.FirstName, p.LastName,p.Age.ToString() };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }
    }
}
