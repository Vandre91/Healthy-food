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
    public partial class UserControl_Profil : UserControl
    {
        public UserControl_Profil()
        {
            InitializeComponent();
            userControl_Show_Profil1.Visible = false;
            userControl_Modify_Profil1.Visible = false;
            textBox1.Visible = false;
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Visible = false;
            try
            {
                string name = listView1.SelectedItems[0].SubItems[0].Text;
                string lastname = listView1.SelectedItems[0].SubItems[1].Text;
                Root.Healthy.Utilisateur.RemoveUser(name, lastname);
                textBox1.Visible = false;
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                listView2.Items.RemoveAt(listView2.SelectedIndices[0]);
            }
            catch (ArgumentException)
            {
                textBox1.Visible = false;
            }
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            timer1.Start();
            timer2.Start();
            int i = 0;

            foreach (var p in Root.Healthy.Utilisateur.IUtilisateur)
            {
                string[] row = { p.FirstName, p.LastName, p.Age.ToString() };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
                listView1.Items[i].ImageIndex = SexImage(p.IsFemale);

                listView2.Items.Add("");
                listView2.Items[i].ImageIndex = ImcImage(p.Imc);
                i++;
            }
        }

        private int SexImage (bool isfemale)
        {
            if (isfemale) return 0;
            else return 1;
        }

        private int ImcImage (double imc)
        {
            if (imc < 16.5 || imc > 30 && imc < 35) return 2;
            else if (imc > 16.5 && imc < 18.5 || imc > 25 && imc < 30) return 3;
            else if (imc > 18.5 && imc < 25) return 4;
            else if (imc > 35 && imc < 40) return 5;
            else return 6;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            timer1.Stop();
            timer2.Stop();
            textBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl_Show_Profil1.Visible = true;
            userControl_Show_Profil1.BringToFront();

            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count <= 0)
            {
                //button_Modify.Enabled = true;
            }
            else
            {
                try
                {
                    string name = listView1.SelectedItems[0].SubItems[0].Text;
                    string lastname = listView1.SelectedItems[0].SubItems[1].Text;
                    UserProfile profil = Root.Healthy.Utilisateur.FindUser(name, lastname);
                    Root.Healthy.Profil = profil;
                    userControl_Modify_Profil1.Visible = true;
                    userControl_Modify_Profil1.Focus();
                }
                catch (ArgumentException)
                {
                    textBox1.Visible = true;
                }
            }
        }

        //private void button_Add_Click(object sender, EventArgs e)
        //{
        //    label7.Visible = false;
        //    userControl_Show_Profil1.Visible = true;
        //}

        //private void button_back_Click_1(object sender, EventArgs e)
        //{
        //    label7.Visible = false;
        //    this.Visible = false;
        //    timer_refesh.Stop();
        //}

        //private void button_Modify_Click(object sender, EventArgs e)
        //{
        //    label7.Visible = false;
        //    if (listView1.Items.Count <= 0)
        //    {
        //        button_Modify.Enabled = true;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string name = listView1.SelectedItems[0].SubItems[0].Text;
        //            string lastname = listView1.SelectedItems[0].SubItems[1].Text;
        //            UserProfile profil = Root.Healthy.Utilisateur.FindUser(name, lastname);
        //            Root.Healthy.Profil = profil;
        //            userControl_Modify_Profil1.Visible = true;
        //            userControl_Modify_Profil1.Focus();
        //        }
        //        catch (ArgumentException)
        //        {
        //            label7.Text = "Selectioner un Utilisateur";
        //            label7.Visible = true;
        //        }
        //    }
        //}

        //private void button_Delete_Click(object sender, EventArgs e)
        //{
        //    label7.Visible = false;
        //    try
        //    {
        //        string name = listView1.SelectedItems[0].SubItems[0].Text;
        //        string lastname = listView1.SelectedItems[0].SubItems[1].Text;
        //        Root.Healthy.Utilisateur.RemoveUser(name, lastname);
        //        label7.Text = "Utilisateur Suprimer";
        //        label7.Visible = true;
        //        listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        //    }
        //    catch (ArgumentException)
        //    {
        //        label7.Text = "Selectioner un Utilisateur";
        //        label7.Visible = true;
        //    }
        //}

        //public void UserControl_Profil_Enter(object sender, EventArgs e)
        //{
        //    listView1.Items.Clear();
        //    timer_refesh.Start();

        //    foreach (var p in Root.Healthy.Utilisateur.IUtilisateur)
        //    {
        //        string[] row = { p.FirstName, p.LastName, p.Age.ToString() };
        //        ListViewItem item = new ListViewItem(row);
        //        listView1.Items.Add(item);
        //    }
        //}

        //private void timer_refesh_Tick(object sender, EventArgs e)
        //{
        //    listView1.Items.Clear();


        //    foreach (var p in Root.Healthy.Utilisateur.IUtilisateur)
        //    {
        //        string[] row = { p.FirstName, p.LastName, p.Age.ToString() };
        //        ListViewItem item = new ListViewItem(row);
        //        listView1.Items.Add(item);
        //    }
        //}
    }
    
}
