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
            
            int Age = Int32.Parse(textBox_Age.Text);
            int Weight = Int32.Parse(textBox_Weight.Text);
            int Height = Int32.Parse(textBox_Height.Text);

            Global.Utilisateur.CreateUser(textBox_Name.Text, textBox_Fisrtname.Text, Age, Weight, Height,false,false);

            textBox_Name.Clear();
            textBox_Fisrtname.Clear();
            textBox_Age.Clear();
            textBox_Weight.Clear();
            textBox_Height.Clear();
            

        }
    }
}
