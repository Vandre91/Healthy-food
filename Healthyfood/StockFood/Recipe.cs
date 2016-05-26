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
        public Dictionary<string, Ingredients> Recette;
        string  _describe;

        public Recipe()
        {
            Recette = new Dictionary<string, Ingredients>();

        }
        //public Recipe CreateRecipe()
        //{

        //}

        public string Describe
        {
            get { return _describe; }
            set { _describe = value; }
        }

        public ICollection<Ingredients> IRecipe
        {
            get { return Recette.Values; }
        }

    }

}
