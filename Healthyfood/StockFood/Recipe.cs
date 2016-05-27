using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
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
        public void save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new System.IO.FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(file, this);
            }
        }

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
