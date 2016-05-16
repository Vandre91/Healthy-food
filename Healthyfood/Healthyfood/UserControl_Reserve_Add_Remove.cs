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
        object _s;
        EventArgs _e;

        public UserControl_Reserve_Add_Remove()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_meat.Text = listView1.SelectedItems[0].Text;
        }

        private void button_back1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void UserControl_Reserve_Add_Remove_Enter(object sender, EventArgs e)
        {
            _s = sender;
            _e = e;

            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
            listView6.Items.Clear();
            listView7.Items.Clear();
            listView8.Items.Clear();
            listView9.Items.Clear();
            listView10.Items.Clear();
            listView11.Items.Clear();
            listView12.Items.Clear();
            listView13.Items.Clear();

            int countv = Global.viande.Count;
            int countd = Global.boisson.Count;
            int countds = Global.dessert_sucrerie.Count;
            int countc = Global.crustace.Count;
            int countp = Global.poisson.Count;
            int countvo = Global.volaille.Count;
            int countl = Global.legume.Count;
            int countf = Global.fruit.Count;
            int countpf = Global.produit_laitier.Count;
            int countmg = Global.matiere_grasse.Count;
            int countfe = Global.feculent.Count;
            int counthp = Global.herbe_plante.Count;
            int countbl = Global.boulangerie.Count;

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
            text_name_drink.Text = listView2.SelectedItems[0].Text;
        }

        private void listView3_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_dessert.Text = listView3.SelectedItems[0].Text;
        }





        private void Btn_back_milk_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_back_fat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_back_starchy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_bacl_grass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_back_bakery_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_dessert_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_crustacean_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_Back_fish_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_poultry_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_vegetable_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_fruit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_dairyproduct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_starchyfood_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_fat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_grass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_bukery_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

       

        private void listView4_MouseClick(object sender, MouseEventArgs e)
        {
            txt_name_crust.Text = listView4.SelectedItems[0].Text;

        }

        private void listView5_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_fish.Text = listView5.SelectedItems[0].Text;
        }

        private void listView6_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_poultry.Text = listView6.SelectedItems[0].Text;
        }

        private void listView7_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_vegetable.Text = listView7.SelectedItems[0].Text;
        }

        private void listView8_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_fruit.Text = listView8.SelectedItems[0].Text;
        }

        private void listView9_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_milk.Text = listView9.SelectedItems[0].Text;
        }

        private void listView10_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_fat.Text = listView10.SelectedItems[0].Text;
        }

        private void listView11_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_starchy.Text = listView11.SelectedItems[0].Text;
        }

        private void listView12_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_plant.Text = listView12.SelectedItems[0].Text;
        }

        private void listView13_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_bakery.Text = listView13.SelectedItems[0].Text;
        }


        int verify_error(TextBox boxname, TextBox boxdate, TextBox boxquantity, Label error1, Label error2, Label error3, Label error4)
        {

            DateTime date = Convert.ToDateTime(boxdate.Text);
            int quantity = Int32.Parse(boxquantity.Text);
            string text = string.Copy(boxname.Text);
            if (date < DateTime.Today & quantity > 0 & text != string.Empty )
            {
                boxdate.BackColor = Color.Red;
                boxquantity.BackColor = Color.White;
                boxname.BackColor = Color.White;
                error1.Text = "La date entrée est invalide";
                error2.Text = null;
                error3.Text = null;
                error4.Text = null;
                return 0;
            }
            else if (date < DateTime.Today & quantity <= 0 & text != string.Empty)
            {
                boxdate.BackColor = Color.Red;
                boxquantity.BackColor = Color.Red;
                boxname.BackColor = Color.White;
                error1.Text = "La date entrée est invalide";
                error2.Text = "La quantité entrée est invalide";
                error3.Text = null;
                error4.Text = null;
                return 0;
            }

            else if (date < DateTime.Today & quantity > 0 & text == string.Empty)
            {
                boxdate.BackColor = Color.Red;
                boxquantity.BackColor = Color.White;
                boxname.BackColor = Color.Red;
                error1.Text = "La date entrée est invalide";
                error2.Text = null;
                error3.Text = "Aucun aliment sélection";
                error4.Text = null;
                return 0;
            }
            else if (date < DateTime.Today & quantity <= 0 & text == string.Empty)
            {
                boxdate.BackColor = Color.Red;
                boxquantity.BackColor = Color.Red;
                boxname.BackColor = Color.Red;
                error1.Text = "La date entrée est invalide";
                error2.Text = "La quantité entrée est invalide";
                error3.Text = "Aucun aliment sélectionné";
                error4.Text = null;
                return 0;
            }
            else if (date >= DateTime.Today & quantity <= 0 & text == string.Empty)
            {
                boxquantity.BackColor = Color.Red;
                boxdate.BackColor = Color.White;
                boxname.BackColor = Color.Red;
                error2.Text = "La quantité entrée est invalide";
                error1.Text = null;
                error3.Text = "Aucun aliment sélectionné";
                error4.Text = null;
                return 0;
            }
            else if (date >= DateTime.Today & quantity <= 0 & text != string.Empty)
            {
                boxquantity.BackColor = Color.Red;
                boxdate.BackColor = Color.White;
                boxname.BackColor = Color.White;
                error2.Text = "La quantité entrée est invalide";
                error1.Text = null;
                error3.Text = null;
                error4.Text = null;
                return 0;
            }

            else if (date >= DateTime.Today & quantity > 0 & text == string.Empty)
            {
                boxname.BackColor = Color.Red;
                boxdate.BackColor = Color.White;
                boxquantity.BackColor = Color.White;
                error2.Text = null;
                error1.Text = null;
                error3.Text = "Aucun aliment sélectionné";
                error4.Text = null;
                return 0;
            }
            else
            {
                boxquantity.Clear();
                boxdate.Clear();
                boxdate.BackColor = Color.White;
                boxquantity.BackColor = Color.White;
                boxname.BackColor = Color.White;
                error1.Text = null;
                error2.Text = null;
                error3.Text = null;
                error4.Text = "Aliment enregistré";
                return 1;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(textBox_Date.Text, out date)) || !(Int32.TryParse(textBox_Quantity.Text, out quantity)))
            {
                text_error1.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(textBox_Quantity.Text);
                date = Convert.ToDateTime(textBox_Date.Text);
                int x = 0;
                x= verify_error(text_name_meat, textBox_Date, textBox_Quantity, text_error1, text_error2, text_error3, text_error4);
                if (x == 1) Global.Stocks.AddIngredient("viande", text_name_meat.Text, quantity, date);
            }
        }

        private void button_save_drink_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(textbox_datePeremption.Text, out date)) || !(Int32.TryParse(textbox_quantity_drink.Text, out quantity)))
            {

                label37.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(textbox_quantity_drink.Text);
                int x = 0;
                date = Convert.ToDateTime(textbox_datePeremption.Text);
                x = verify_error(text_name_drink, textbox_datePeremption, textbox_quantity_drink, label37, label38, label39, label40);
                if (x == 1) Global.Stocks.AddIngredient("boisson", text_name_drink.Text, quantity, date);
            }

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(txt_dateperemtion_dessert.Text, out date)) || !(Int32.TryParse(txt_quantity_dessert.Text, out quantity)))
            {
                label41.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_dessert.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemtion_dessert.Text);
                x = verify_error(text_name_dessert, txt_dateperemtion_dessert, txt_quantity_dessert, label41, label42, label43, label44);
                if (x == 1) Global.Stocks.AddIngredient("dessert_sucrerie", text_name_dessert.Text, quantity, date);
            }
        }

        private void btn_enreg_crustaceam_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(txt_dateperemption_crust.Text, out date)) || !(Int32.TryParse(txt_quantity_crust.Text, out quantity)))
            {
                label45.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_crust.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemption_crust.Text);

                x = verify_error(txt_name_crust, txt_dateperemption_crust, txt_quantity_crust, label45, label46, label47, label48);
                if (x == 1) Global.Stocks.AddIngredient("crustace", txt_name_crust.Text, quantity, date);
            }
        }

        private void btn_enreg_fish_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(txt_dateperemption_fish.Text, out date)) || !(Int32.TryParse(txt_quantity_fish.Text, out quantity)))
            {
                label49.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_fish.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemption_fish.Text);
                x = verify_error(text_name_fish, txt_dateperemption_fish, txt_quantity_fish, label49, label50, label51, label52);
                if (x == 1) Global.Stocks.AddIngredient("poisson", text_name_fish.Text, quantity, date);
            }
        }

        private void btn_enreg_poultry_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(txt_dateperemtion_poultry.Text, out date)) || !(Int32.TryParse(txt_quantity_poultry.Text, out quantity)))
            {
                label53.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_poultry.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemtion_poultry.Text);

                x = verify_error(text_name_poultry, txt_dateperemtion_poultry, txt_quantity_poultry, label53, label54, label55, label56);
                if (x == 1) Global.Stocks.AddIngredient("volaille", text_name_poultry.Text, quantity, date);
            }
        }

        private void btn_enreg_vegetable_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(txt_dateperemtion_vegetable.Text, out date)) || !(Int32.TryParse(txt_quantity_vegetable.Text, out quantity)))
            {
                label57.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_vegetable.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemtion_vegetable.Text);

                x = verify_error(text_name_vegetable, txt_dateperemtion_vegetable, txt_quantity_vegetable, label57, label58, label59, label60);
                if (x == 1) Global.Stocks.AddIngredient("legume", text_name_vegetable.Text, quantity, date);
            }
        }

        private void btn_enreg_fruit_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(txt_dateperemtion_fruit.Text, out date)) || !(Int32.TryParse(txt_quantity_fruit.Text, out quantity)))
            {
                label61.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(txt_dateperemtion_fruit.Text);
                quantity = Int32.Parse(txt_quantity_fruit.Text);
                int x = 0;

                x = verify_error(text_name_fruit, txt_dateperemtion_fruit, txt_quantity_fruit, label61, label62, label63, label64);
                if (x == 1) Global.Stocks.AddIngredient("fruit", text_name_fruit.Text, quantity, date);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(textBox23.Text, out date)) || !(Int32.TryParse(textBox24.Text, out quantity)))
            {
                label65.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(textBox23.Text);
                quantity = Int32.Parse(textBox24.Text);
                int x = 0;

                x = verify_error(text_name_milk, textBox23, textBox24, label65, label66, label67, label68);
                if (x == 1) Global.Stocks.AddIngredient("produit_laitier", text_name_milk.Text, quantity, date);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(textBox26.Text, out date)) || !(Int32.TryParse(textBox27.Text, out quantity)))
            {
                label69.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(textBox26.Text);
                quantity = Int32.Parse(textBox27.Text);
                int x = 0;

                x = verify_error(text_name_fat, textBox26, textBox27, label69, label70, label71, label72);
                if (x == 1) Global.Stocks.AddIngredient("matiere_grasse", text_name_fat.Text, quantity, date);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(textBox29.Text, out date)) || !(Int32.TryParse(textBox30.Text, out quantity)))
            {
                label73.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(textBox29.Text);
                quantity = Int32.Parse(textBox30.Text);
                int x = 0;

                x = verify_error(text_name_starchy, textBox29, textBox30, label73, label74, label75, label76);
                if (x == 1) Global.Stocks.AddIngredient("feculent", text_name_starchy.Text, quantity, date);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(textBox32.Text, out date)) || !(Int32.TryParse(textBox33.Text, out quantity)))
            {
                label77.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(textBox32.Text);
                quantity = Int32.Parse(textBox33.Text);
                int x = 0;

                x = verify_error(text_name_plant, textBox32, textBox33, label77, label78, label79, label80);
                if (x == 1) Global.Stocks.AddIngredient("herbe_plante", text_name_plant.Text, quantity, date);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            if (!(DateTime.TryParse(textBox37.Text, out date)) || !(Int32.TryParse(textBox36.Text, out quantity)))
            {
                label81.Text = "Le format est invalide";

            }
            else
            {
            date = Convert.ToDateTime(textBox37.Text);
            quantity = Int32.Parse(textBox36.Text);
            int x = 0;

                x = verify_error(text_name_bakery, textBox36, textBox37, label81, label82, label83, label84);
            if (x == 1) Global.Stocks.AddIngredient("boulangerie", text_name_bakery.Text, quantity, date);
            }
        }

        private void button_ajouter_viande_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button_ajouter_boisson_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button_ajouter_dessert_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button_ajouter_crustacé_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button_ajouter_poisson_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button_ajouter_volailles_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button_ajouter_legumes_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button_ajouter_fruit_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button_ajouter_produit_laitier_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void button_ajouter_matiére_grasse_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
        }

        private void button_ajouter_feculent_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
        }

        private void button_ajout_boulangerie_Click(object sender, EventArgs e)
        {
            panel13.Visible = true;
        }

        private void button_ajouter_herbe_Click(object sender, EventArgs e)
        {
            panel12.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("boisson", textBox1.Text);
            panel1.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("viande", textBox2.Text);
            panel2.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("dessert_sucrerie", textBox3.Text);
            panel3.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("crustace", textBox4.Text);
            panel4.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("poisson", textBox5.Text);
            panel5.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("volaille", textBox6.Text);
            panel6.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("legume", textBox7.Text);
            panel7.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("fruit", textBox8.Text);
            panel8.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("produit_laitier", textBox9.Text);
            panel9.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("matiere_grasse", textBox10.Text);
            panel10.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("feculent", textBox11.Text);
            panel11.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("herbe_plante", textBox12.Text);
            panel12.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Global.CreateIngredient("boulangerie", textBox13.Text);
            panel13.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
        }
    }
}
