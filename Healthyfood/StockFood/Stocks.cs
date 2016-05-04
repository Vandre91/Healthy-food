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

        public void AddIngredient(Ingredients._Category category,Ingredients._Name name, double balance, DateTime expiration_date)
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

        public void RemoveIngredient(Ingredients._Category category,Ingredients._Name name, double balance, double amount, DateTime expiration_date)

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

        public void ReduceIngredient(Ingredients._Category category,Ingredients._Name name, double balance,  DateTime expiration_date)
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
                    
        }
    }

