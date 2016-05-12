using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    public class Stocks
    {
       public static Dictionary<string, Ingredients> _stock;

        public Stocks ()
        {
            _stock = new Dictionary<string, Ingredients>();
        }

       public static string naming (Ingredients ingred)
        {
            return ((ingred.Name()) + " " + Convert.ToString(ingred.Expiration_Date()));
        }

        public Ingredients AddIngredient(string category,string name, int balance, DateTime expiration_date)
        {

            if (category == null || category == string.Empty || string.IsNullOrWhiteSpace(category)) throw new ArgumentException("The name must not be empty", nameof(category));
            if (name == null || name == string.Empty || string.IsNullOrWhiteSpace(name)) throw new ArgumentException("The name must not be empty", nameof(name));
            if (!(Ingredients._Category.Contains(category))) throw new ArgumentException("This category does not exist", nameof(category));
            if (!(Ingredients._Name.Contains(name))) throw new ArgumentException("This name of ingredient does not exist", nameof(name));
            if (expiration_date < DateTime.Today) throw new ArgumentException("This ingredient is obsolete", nameof(expiration_date));
            if (balance <= 0) throw new ArgumentException("The balance must be more than 0", nameof(balance));
            Ingredients ingred = new Ingredients(category, name, balance, expiration_date);
            if (_stock.ContainsKey(naming(ingred)))
            {
                int bal = _stock[name + " " + Convert.ToString(expiration_date)].Balance + balance;
                RemoveIngredient(name, expiration_date);
                Ingredients i = AddIngredient(category, name, bal, expiration_date);
            }
            else
            {
                _stock[naming(ingred)] = ingred;
            }

            return ingred;
        }

        public void RemoveIngredient(string name, DateTime expiration_date)

        {
            if (_stock.ContainsKey(name+" "+ Convert.ToString(expiration_date)))
            {
                _stock.Remove(name + " " + Convert.ToString(expiration_date));
            }
            else
            {
                throw new ArgumentException("This ingredient does not exist", nameof(name));
            }
            
        }

        public void ReduceIngredient(string name, int balance,  DateTime expiration_date)
        {
            if (balance <= 0) throw new ArgumentException("The balance must be more than 0", nameof(balance));
            if (_stock.ContainsKey(name + " " + Convert.ToString(expiration_date)))
            {
                if (balance > _stock[name + " " + Convert.ToString(expiration_date)].Balance)
                {
                    throw new ArgumentException(" ");
                }
                else
                {
                    int bal = _stock[name + " " + Convert.ToString(expiration_date)].Balance - balance;
                    string category = _stock[name + " " + Convert.ToString(expiration_date)].Category1;
                    RemoveIngredient(name, expiration_date);
                   Ingredients i = AddIngredient(category, name, bal, expiration_date);
                    if (bal == 0)  RemoveIngredient(name, expiration_date);
                   
                }
            }
            else
            {
                throw new ArgumentException("this ingredient does not exist", nameof(name));
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

