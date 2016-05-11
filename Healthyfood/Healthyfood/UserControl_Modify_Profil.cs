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
    public partial class UserControl_Modify_Profil : UserControl
    {
        public UserControl_Modify_Profil()
        {
            InitializeComponent();

            //textBox_Name.Clear();
            //textBox_Fisrtname.Clear();
            //textBox_Age.Clear();
            //textBox_Weight.Clear();
            //textBox_Height.Clear();

            //textBox_Name.Text = Global.Profil.LastName;
            //textBox_Fisrtname.Text = Global.Profil.FirstName;
            //textBox_Age.Text = Global.Profil.Age.ToString();
            //textBox_Weight.Text = Global.Profil.Weight.ToString();
            //textBox_Height.Text = Global.Profil.Height.ToString();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            int Age = Int32.Parse(textBox_Age.Text);
            int Weight = Int32.Parse(textBox_Weight.Text);
            int Height = Int32.Parse(textBox_Height.Text);

            Global.Utilisateur.modify_firstname(Global.Profil,textBox_Fisrtname.Text);
            Global.Utilisateur.modify_lastname(Global.Profil,textBox_Name.Text);
            Global.Utilisateur.modify_age(Global.Profil,Age);
            Global.Utilisateur.modify_weigth(Global.Profil,Weight);
            Global.Utilisateur.modify_heigth(Global.Profil,Height);
        }

        private void UserControl_Modify_Profil_Load(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Fisrtname.Clear();
            textBox_Age.Clear();
            textBox_Weight.Clear();
            textBox_Height.Clear();

            textBox_Name.Text = Global.Profil.LastName;
            textBox_Fisrtname.Text = Global.Profil.FirstName;
            textBox_Age.Text = Global.Profil.Age.ToString();
            textBox_Weight.Text = Global.Profil.Weight.ToString();
            textBox_Height.Text = Global.Profil.Height.ToString();
        }

        private void UserControl_Modify_Profil_Enter(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Fisrtname.Clear();
            textBox_Age.Clear();
            textBox_Weight.Clear();
            textBox_Height.Clear();

            textBox_Name.Text = Global.Profil.LastName;
            textBox_Fisrtname.Text = Global.Profil.FirstName;
            textBox_Age.Text = Global.Profil.Age.ToString();
            textBox_Weight.Text = Global.Profil.Weight.ToString();
            textBox_Height.Text = Global.Profil.Height.ToString();
        }
    }
}
