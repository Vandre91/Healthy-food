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
            return ((Ingredients.Name) + " " + Convert.ToString(Ingredients.Expiration_Date));
        }

        public void AddIngredient(string category,string name, double balance, DateTime expiration_date)
        {

            Ingredients ingred = new Ingredients(category, name, balance, expiration_date);
            if (_stock.ContainsKey(naming(ingred)))
            {
                _stock[naming(ingred)].Balance = balance;
            }
            else
            {
                _stock[naming(ingred)] = ingred;
            }
        }

        public void RemoveIngredient(string category,string name, double balance, double amount, DateTime expiration_date)

        {
            Ingredients ingred = new Ingredients(category, name, balance, expiration_date);
            if (_stock.ContainsKey(naming(ingred)))
            {
                _stock.Remove(naming(ingred));
            }
            else
            {
                throw new ArgumentException("This ingredient does not exist", nameof(category));
            }
        }

        public void ReduceIngredient(string category,string name, double balance,  DateTime expiration_date)
        {
            Ingredients ingred = new Ingredients(category, name, balance, expiration_date);
            if (_stock.ContainsKey(naming(ingred)))
            {
                if (balance > _stock[naming(ingred)].Balance)
                {
                    throw new ArgumentException(" ");
                }
                else
                {
                    _stock[naming(ingred)].Reduce = balance;
                }
            }
            else
            {
                throw new ArgumentException("this ingredient does not exist", nameof(category));
            }
        }

        public void CreateIngredient (string category, string name )
        {
            if (Ingredients._Name.Contains(name)) throw new ArgumentException("This ingredient does already exist", nameof(name));
            else
            {
                Ingredients._Name.Add(name);
                if (category == "viande" ) Ingredients.viande.Add(name);
                if (category == "poisson") Ingredients.poisson.Add(name);
                if (category == "crustace") Ingredients.crustace.Add(name);
                if (category == "dessert_sucrerie") Ingredients.dessert_sucrerie.Add(name);
                if (category == "boisson") Ingredients.boisson.Add(name);
                if (category == "volaille") Ingredients.volaille.Add(name);
                if (category == "legume") Ingredients.legume.Add(name);
                if (category == "fruit") Ingredients.fruit.Add(name);
                if (category == "produit_laitier") Ingredients.produit_laitier.Add(name);
                if (category == "matiere_grasse") Ingredients.matiere_grasse.Add(name);
                if (category == "feculent") Ingredients.feculent.Add(name);
                if (category == "boulangerie") Ingredients.boulangerie.Add(name);
                if (category == "herbe_plante") Ingredients.herbe_plante.Add(name);
            }
        }                    
    }
 }

