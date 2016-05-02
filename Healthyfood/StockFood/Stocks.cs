using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    class Stocks
    {
        public Dictionary<string, Ingredients> _stock;

        public Stocks ()
        {
            _stock = new Dictionary<string, Ingredients>();
        }

        string naming (Ingredients ingred)
        {
            return (Convert.ToString(Ingredients.Category) + " " + Convert.ToString(Ingredients.Expiration_Date));
        }
    }
}
