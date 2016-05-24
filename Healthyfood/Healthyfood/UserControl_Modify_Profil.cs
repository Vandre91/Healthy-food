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
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
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

            Root.Healthy.Utilisateur.modify_firstname(Root.Healthy.Profil,textBox_Fisrtname.Text);
            Root.Healthy.Utilisateur.modify_lastname(Root.Healthy.Profil,textBox_Name.Text);
            Root.Healthy.Utilisateur.modify_age(Root.Healthy.Profil,Age);
            Root.Healthy.Utilisateur.modify_weigth(Root.Healthy.Profil,Weight);
            Root.Healthy.Utilisateur.modify_heigth(Root.Healthy.Profil,Height);
        }

        private void UserControl_Modify_Profil_Load(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Fisrtname.Clear();
            textBox_Age.Clear();
            textBox_Weight.Clear();
            textBox_Height.Clear();

            textBox_Name.Text = Root.Healthy.Profil.LastName;
            textBox_Fisrtname.Text = Root.Healthy.Profil.FirstName;
            textBox_Age.Text = Root.Healthy.Profil.Age.ToString();
            textBox_Weight.Text = Root.Healthy.Profil.Weight.ToString();
            textBox_Height.Text = Root.Healthy.Profil.Height.ToString();
        }

        private void UserControl_Modify_Profil_Enter(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Fisrtname.Clear();
            textBox_Age.Clear();
            textBox_Weight.Clear();
            textBox_Height.Clear();

            textBox_Name.Text = Root.Healthy.Profil.LastName;
            textBox_Fisrtname.Text = Root.Healthy.Profil.FirstName;
            textBox_Age.Text = Root.Healthy.Profil.Age.ToString();
            textBox_Weight.Text = Root.Healthy.Profil.Weight.ToString();
            textBox_Height.Text = Root.Healthy.Profil.Height.ToString();
        }
    }
}
