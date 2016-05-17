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
    public partial class UserControl_Show_Profil : UserControl
    {
        
        public UserControl_Show_Profil()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            int age1, x = 6;
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            if (textBox_Name.Text == null || textBox_Name.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Name.Text))
            { label1.Text = "Le texte est invalide";
                x = 1;
            }
           
            if (textBox_Fisrtname.Text == null || textBox_Fisrtname.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Fisrtname.Text))
            {
                label2.Text = "Le texte est invalide";
                x = 1;
            }
            if (!(Int32.TryParse(textBox_Age.Text, out age1)))
                {
                label3.Text = "Le format n'est pas valide";
                x = 1; 
                }
            else
            {
                age1 = Int32.Parse(textBox_Age.Text);
                if (age1 < 0 || age1 > 130) label3.Text = "L'age n'est pas valide";
                x = 1;
            }
            if (!(Int32.TryParse(textBox_Height.Text, out age1)))
            {
                label5.Text = "Le format n'est pas valide";
                x = 1;
            }
            else
            {
                age1 = Int32.Parse(textBox_Height.Text);
                if (age1 < 30 || age1 > 230) label5.Text = "La taille n'est pas valide";
                x = 1;
            }

            if (!(Int32.TryParse(textBox_Weight.Text, out age1)))
            {
                label6.Text = "Le format n'est pas valide";
                x = 1;
            }
            else
            {
                age1 = Int32.Parse(textBox_Weight.Text);
                if (age1 < 0 || age1 > 250) label6.Text = "Le poids n'est pas valide";
                x = 1;
            }

            if (comboBox_Sex.Text == null || comboBox_Sex.Text == string.Empty || string.IsNullOrWhiteSpace(comboBox_Sex.Text))
            {
                label4.Text = "Aucun sexe sélectionné";
                x = 1;

            }

            if (!(textBox_Name.Text == null || textBox_Name.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Name.Text)) 
                && !(textBox_Fisrtname.Text == null || textBox_Fisrtname.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Fisrtname.Text))
                && (Int32.TryParse(textBox_Age.Text, out age1))
                && (Int32.TryParse(textBox_Height.Text, out age1))
                && (Int32.TryParse(textBox_Weight.Text, out age1))
                && !(comboBox_Sex.Text == null || comboBox_Sex.Text == string.Empty || string.IsNullOrWhiteSpace(comboBox_Sex.Text)))
            {

                label7.Text = "Utilisateur enregistré";
                int Age = Int32.Parse(textBox_Age.Text);
                int Weight = Int32.Parse(textBox_Weight.Text);
                int Height = Int32.Parse(textBox_Height.Text);

                Global.Utilisateur.CreateUser(textBox_Name.Text, textBox_Fisrtname.Text, Age, Weight, Height, false, false);

                textBox_Name.Clear();
                textBox_Fisrtname.Clear();
                textBox_Age.Clear();
                textBox_Weight.Clear();
                textBox_Height.Clear();
                
            }
            

        }
    }
}
