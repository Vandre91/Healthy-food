using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    [Serializable]
    public class Recipe
    {
        public Dictionary<string, Ingredients> _recette;
        string  _describe;

        public Recipe(Ingredients ing,string describe)
        {

            _recette = new Dictionary<string, Ingredients>();

        }

        public string Describe
        {
            get { return _describe; }
            set { _describe = value; }
        }

        public ICollection<Ingredients> IRecipe
        {
            get { return _recette.Values; }
        }

    }

}
