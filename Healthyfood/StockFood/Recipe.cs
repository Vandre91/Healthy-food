using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    public class Recipe
    {
        public Dictionary<string, Ingredients> Recette;
        Double _Quantity;

        public Recipe()
        {
            Recette = new Dictionary<string, Ingredients>();
        }

        public Double Quantity
        {
            get { return _Quantity; }
        }

        public ICollection<Ingredients> IRecipe
        {
            get { return Recette.Values; }
        }

    }

}
