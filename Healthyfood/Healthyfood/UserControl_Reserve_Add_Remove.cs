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
    public partial class UserControl_Reserve_Add_Remove : UserControl
    {
        static int countv = Global.viande.Count;
        static int countd = Global.boisson.Count;
        static int countds = Global.dessert_sucrerie.Count;
        static int countc = Global.crustace.Count;
        static int countp = Global.poisson.Count;
        static int countvo = Global.volaille.Count;
        static int countl = Global.legume.Count;
        static int countf = Global.fruit.Count;
        static int countpf = Global.produit_laitier.Count;
        static int countmg = Global.matiere_grasse.Count;
        static int countfe = Global.feculent.Count;
        static int counthp = Global.herbe_plante.Count;
        static int countbl = Global.boulangerie.Count;
        
        string[] _beef = new string[countv];
        string[] _drink = new string[countd];
        string[] _sucrerie_dessert = new string[countds];
        string[] _crustace = new string[countc];
        string[] _poisson = new string[countp];
        string[] _volaile = new string[countvo];
        string[] _legume = new string[countl];
        string[] _fruit = new string[countf];
        string[] _produit_laitier = new string[countpf];
        string[] _matière_grasse = new string[countmg];
        string[] _feculent = new string[countfe];
        string[] _herbe_plante = new string[counthp];
        string[] _boulangerie = new string[countbl];



        public UserControl_Reserve_Add_Remove()
        {
            InitializeComponent();
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(textBox_Date.Text);
            int quantity = Int32.Parse(textBox_Quantity.Text);
            Global.Stocks.AddIngredient("viande",textBox_Name.Text,quantity,date);

            textBox_Name.Clear();
            textBox_Quantity.Clear();
            textBox_Date.Clear();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Name.Text = listView1.SelectedItems[0].Text;
        }

        private void button_save_drink_Click(object sender, EventArgs e)
        {

        }

        private void button_back1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UserControl_Reserve_Add_Remove_Enter(object sender, EventArgs e)
        {
            int v = 0;
            int b = 0;
            int s = 0;
            int c = 0;
            int po = 0;
            int vo = 0;
            int l = 0;
            int f = 0;
            int pf = 0;
            int mg = 0;
            int fe = 0;
            int hp = 0;
            int bl = 0;

            Global.viande.CopyTo(_beef);
            Global.crustace.CopyTo(_crustace);
            Global.boisson.CopyTo(_drink);
            Global.dessert_sucrerie.CopyTo(_sucrerie_dessert);
            Global.poisson.CopyTo(_poisson);
            Global.volaille.CopyTo(_volaile);
            Global.legume.CopyTo(_legume);
            Global.fruit.CopyTo(_fruit);
            Global.produit_laitier.CopyTo(_produit_laitier);

            Global.matiere_grasse.CopyTo(_matière_grasse);
            Global.feculent.CopyTo(_feculent);
            Global.herbe_plante.CopyTo(_herbe_plante);
            Global.boulangerie.CopyTo(_boulangerie);

            foreach (var p in _beef)
            {
                ListViewItem item = new ListViewItem(_beef[v]);
                listView1.Items.Add(item);
                v++;
            }
            foreach (var p in _drink)
            {
                ListViewItem item = new ListViewItem(_drink[b]);
                listView2.Items.Add(item);
                b++;
            }
            foreach (var p in _sucrerie_dessert)
            {
                ListViewItem item = new ListViewItem(_sucrerie_dessert[s]);
                listView3.Items.Add(item);
                s++;
            }
            foreach ( var p in _crustace)
            {
                ListViewItem item = new ListViewItem(_crustace[c]);
                listView4.Items.Add(item);
                c++;
            }
            foreach (var p in _poisson)
            {
                ListViewItem item = new ListViewItem(_poisson[po]);
                listView5.Items.Add(item);
                po++;
            }
            foreach (var p in _volaile)
            {
                ListViewItem item = new ListViewItem(_volaile[vo]);
                listView6.Items.Add(item);
                vo++;
            }
            foreach ( var p in _legume)
            {
                ListViewItem item = new ListViewItem(_legume[l]);
                listView7.Items.Add(item);
                l++;
            }
            foreach (var p in _fruit)
            {
                ListViewItem item = new ListViewItem(_fruit[f]);
                listView8.Items.Add(item);
                f++;

            }
            foreach (var p in _produit_laitier)
            {
                ListViewItem item = new ListViewItem(_produit_laitier[pf]);
                listView9.Items.Add(item);
                pf++;
            }
            foreach (var p in _matière_grasse)
            {
                ListViewItem item = new ListViewItem(_matière_grasse[mg]);
                listView10.Items.Add(item);
                mg++;
            }
            foreach (var p in _feculent)
            {
                ListViewItem item = new ListViewItem(_feculent[fe]);
                listView11.Items.Add(item);
                fe++;
            }
            foreach ( var p in _herbe_plante)
            {
                ListViewItem item = new ListViewItem(_herbe_plante[hp]);
                listView12.Items.Add(item);
                hp++;
            }
            foreach (var p in _boulangerie)
            {
                ListViewItem item = new ListViewItem(_boulangerie[bl]);
                listView13.Items.Add(item);
                bl++;
            }
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Name_drink.Text = listView2.SelectedItems[0].Text;
        }
    }
}
