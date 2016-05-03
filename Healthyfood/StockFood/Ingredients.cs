using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    public class Ingredients
    {
        static DateTime _expiration_date;
        double _amount; // viande a ajouter ou retirer
        double _balance;
        public  enum _Category { viande, poisson, crustace, dessert_sucrerie, boisson, volaille, legume, fruit, produit_laitier, matiere_grasse, féculent_boulangerie, herbe_plante};
        public enum Viande { steak_de_boeuf, collier_de_boeuf, entrecote_de_boeuf, cote_de_boeuf, rumsteck_de_boeuf, filet_de_boeuf, jarret_de_boeuf, onglet_de_boeuf, flanchet_de_boeuf, poitrine_de_boeuf, bifteck_de_boeuf, collier_de_agneau, cote_de_agneau, filet_de_agneau, gigot_de_agneau, poitrine_de_agneau, epaule_de_agneau, collier_de_veau, cote_de_veau, filet_de_veau, poitrine_de_veau, epaule_de_veau, jarret_de_veau, flanchet_de_veau, tendron_de_veau, echine_de_porc, cote_de_porc, filet_de_porc, jambon_de_porc, jarret_de_porc, collier_de_cheval, cote_de_cheval, entrecote_de_cheval, filet_de_cheval, rumsteck_de_cheval, gite_de_cheval, merlan_de_cheval, tranche_de_cheval, jaret_de_cheval, araignee_de_cheval, onglet_de_cheval, };
        public static _Category _category;
        public Ingredients (_Category category, double balance, DateTime expiration_date)
        {
            _category = category;
            _balance = balance;
            _expiration_date = expiration_date;
        }

        public static _Category Category
        {
            get { return _category; }
        }
        


        public static DateTime Expiration_Date
        {
            get { return _expiration_date; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance =+ value; }
        }

        public double Reduce
        {
            get { return _balance; }
            set { _balance = -value; }
        }
       
    }
}
