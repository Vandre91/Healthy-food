using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    class Ingredients
    {
        DateTime _expiration_date;
        double _balance;
        internal enum Category { viande_de_boeuf, oeuf, riz, viande_de_mouton, fromage, lait, soda, couscous};
        Category _category;
        public Ingredients (Category category, double balance, DateTime expiration_date)
        {
            _category = category;
            _balance = balance;
            _expiration_date = expiration_date;
        }
    }
}
