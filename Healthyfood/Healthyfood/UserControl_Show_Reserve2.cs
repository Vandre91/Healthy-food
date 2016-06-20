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
    public partial class UserControl_Show_Reserve2 : UserControl
    {
        
        public UserControl_Show_Reserve2()
        {
            InitializeComponent();
            string[] row = { "Steak de boeuf", "1500", "10/10" };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
            listView1.Items[0].ImageIndex =3 ; 
            columnHeader1.ImageIndex =2 ;
            columnHeader2.ImageIndex = 1;
            columnHeader3.ImageIndex = 0;

        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

      

        private void UserControl_Show_Reserve2_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int i = 0;
            foreach (var p in Root.Healthy.Stocks.IStock)
            {
                string date = Convert.ToString(p.Expiration_Date);
                string[] row = { p.Name, p.Balance.ToString(), date };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
                listView1.Items[i].ImageIndex = categoryImage(p.Category1);
                if ((i % 2) == 0) listView1.Items[i].BackColor = Color.LightGray;
                else listView1.Items[i].BackColor = Color.White;
                listView2.Items.Add(" ");
                listView2.Items[i].ImageIndex = DateImage(p.Expiration_Date);
                i++;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = listView1.SelectedItems[0].SubItems[0].Text;
            string expiration_date = listView1.SelectedItems[0].SubItems[2].Text;
            DateTime expiration = Convert.ToDateTime(expiration_date);
            Root.Healthy.Stocks.RemoveIngredient(name, expiration);
            UserControl_Show_Reserve2_Enter(sender, e);
        }

        private int categoryImage (string category)
        {
            if (category == "viande") return 3;
            else if (category == "poisson") return 4;
            else if (category == "crustace") return 15;
            else if (category == "dessert_sucrerie") return 8;
            else if (category == "boisson") return 5;
            else if (category == "volaille") return 6;
            else if (category == "legume") return 10;
            else if (category == "fruit") return 14;
            else if (category == "produit_laitier") return 9;

            else if (category == "matiere_grasse") return 13;

            else if (category == "feculent") return 11;

            else if (category == "boulangerie") return 12;

            else return 7;
        }

        private int DateImage (DateTime date)
        {
            if (date < DateTime.Today) return 17;
            else if (date == DateTime.Today) return 18;
            else return 16;
        }
    }
}
