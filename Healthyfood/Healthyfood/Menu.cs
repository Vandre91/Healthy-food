using StockFood;
using System;
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
        healthyfood _food ;
        string _currentFileName;

        public Menu()
        {
            InitializeComponent();
            _food = new healthyfood();
        }

        public healthyfood Healthy
        {
            get { return _food; }
            set { _food = value; }
        }

        private void button_Utilisateur_Click(object sender, EventArgs e)
        {
            userControl_Profil1.Visible = true;
            userControl_Profil1.Focus();
        }

        private void button_Provisions_Click(object sender, EventArgs e)
        {
            userControl_Reserve1.Visible = true;
            userControl_Reserve1.Focus();
        }

        private void button_Recette_Click(object sender, EventArgs e)
        {
            userControl_Recipe1.Visible = true;
            userControl_Recipe1.Focus();
        }

        private void saugarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentFileName == null)
            {
                using (var d = new SaveFileDialog())
                {
                    d.OverwritePrompt = true;
                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        _currentFileName = d.FileName;
                    }
                    else return;
                }
            }
            Healthy.Save(_currentFileName);
        }

        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var d = new OpenFileDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    Healthy = healthyfood.Load(d.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl_Menu1.Visible = true;
            userControl_Menu1.Focus();
        }
    }
}
