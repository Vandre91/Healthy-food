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
        double _balance;
        public  enum _Category { viande_de_boeuf, oeuf, riz, viande_de_mouton, fromage, lait, soda, couscous};
        static _Category _category;
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
            set { _balance= value; }
        }

       
    }
}
