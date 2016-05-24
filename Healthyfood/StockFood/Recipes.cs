using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    public class Recipes
    {
        public Dictionary<string, Ingredients> Recettes;
        Double _quantity;

        public Recipes()
        {
            Recettes = new Dictionary<string, Ingredients>();

        }

        public Double Quantity
        {
            get { return _quantity; }
            set {
                 if(value <= 0 ) throw new ArgumentException("Quantity must not be lower or equal 0", nameof(value));
                _quantity = value;
            }
        }

        public ICollection<Ingredients> IRecipes
        {
            get { return Recettes.Values; }
        }

    }
}
