﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthyfood
{
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
        }
        
        private void button_Utilisateur_Click(object sender, EventArgs e)
        {
            userControl_Profil1.Visible = true;
        }

        private void button_Provisions_Click(object sender, EventArgs e)
        {
            userControl_Reserve1.Visible = true;
        }

        private void button_Recette_Click(object sender, EventArgs e)
        {
            userControl_Recipe1.Visible = true;
        }
    }
}
