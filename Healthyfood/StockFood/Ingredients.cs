﻿using System;
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
        public enum Viande { steak_de_boeuf}
        public static _Category _category;
        public enum _Poisson { anchois, anguille, brochet, cabillaud, colin, daurade_royale, flétan, loup_de_mer, merlan, omble_chevalier, perche, plie, raie, rascasse_du_nord, rouget_barbet, sandre, sardine, saumon, sole, thon};
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