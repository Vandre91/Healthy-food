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
        public List<Ingredients> _recette;
        string _name;
        string  _describe;

        public Recipe(string name,List<Ingredients> ing,string describe)
        {
            _name = name;
            _recette = new List<Ingredients>(ing);
            _describe = describe;

        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Describe
        {
            get { return _describe; }
            set { _describe = value; }
        }

        public IList<Ingredients> IRecipe
        {
            get { return _recette; }
        }
        
    }

}
