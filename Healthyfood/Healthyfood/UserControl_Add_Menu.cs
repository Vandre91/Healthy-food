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
    public partial class UserControl_Add_Menu : UserControl
    {
        public UserControl_Add_Menu()
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
        #region Combobox Click
        private void comboBox1_Click(object sender, EventArgs e)
        {
            foreach(Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox1.Items.Add(recipe.Name);
            }
        }

        private void comboBox_ls_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_ls.Items.Add(recipe.Name);
            }
        }

        private void comboBox_mm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_mm.Items.Add(recipe.Name);
            }
        }

        private void comboBox_ms_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_ms.Items.Add(recipe.Name);
            }
        }

        private void comboBox_mem_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_mem.Items.Add(recipe.Name);
            }
        }

        private void comboBox_mes_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_mes.Items.Add(recipe.Name);
            }
        }

        private void comboBox_jm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_jm.Items.Add(recipe.Name);
            }
        }

        private void comboBox_js_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_js.Items.Add(recipe.Name);
            }
        }

        private void comboBox_vm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_vm.Items.Add(recipe.Name);
            }
        }

        private void comboBox_vs_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_vs.Items.Add(recipe.Name);
            }
        }

        private void comboBox_sm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_sm.Items.Add(recipe.Name);
            }
        }

        private void comboBox_ss_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_ss.Items.Add(recipe.Name);
            }
        }

        private void comboBox_dm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_dm.Items.Add(recipe.Name);
            }
        }

        private void comboBoxds_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBoxds.Items.Add(recipe.Name);
            }
        }
        #endregion

        private void button_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
