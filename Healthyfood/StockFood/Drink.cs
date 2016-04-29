using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
   public  class Drink
    {
        string _nameflask;
        double _amountflask; // boisson a ajouter
        int _numberflask;
        double _balanceflask; // quantite boisson disponible
        DateTime _dayOfbuy;
        DateTime _expirationday;

        public Drink(string nameflask, int numberflask, double amountflask, double balanceflask, DateTime dayOfbuy, DateTime expirationday)
        {
            if (nameflask == null || nameflask == string.Empty || string.IsNullOrWhiteSpace(nameflask)) throw new ArgumentException("The name must no be empty", nameof(nameflask));
            if (amountflask == 0.0) throw new ArgumentException("the amountflask does not match", nameof(amountflask));
            if (balanceflask == 0.0) throw new ArgumentException("you need to add drink", nameof(balanceflask));

            _nameflask = nameflask;
            _numberflask = numberflask;
            _amountflask = amountflask;
            _balanceflask = balanceflask;
            _dayOfbuy = dayOfbuy;
            _expirationday = expirationday;
        }

        public string Name
        {
            get { return _nameflask; }
            set
            {
                if (value == null || value == string.Empty || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The name must not be empty", nameof(value));
                _nameflask = value;
            }

        }
        public double GetBalanceFlask
        {
            get { return _balanceflask; }
        }

        public double AmountFlask
        {
            get { return _amountflask; }
            set
            {
                if (value <= 2.0) throw new ArgumentException(" the drink to add is little", nameof(value));
                _amountflask = value;
            }
        }
        public DateTime DayofBuy
        {
            get { return _dayOfbuy; }
            set
            {
                _dayOfbuy = value;
            }
        }
        public DateTime Expirationday
        {
            get { return _expirationday; }
            set
            {
                _expirationday = value;
            }
        }
        public void AddDrink( int numberflask)
        {
            if (numberflask == 0)
                throw new ArgumentException("you need to add flask");
            _numberflask++;    

        } 
        public void RemoveFlask(int numberflask)
        {
            if (numberflask > 10)
                Console.WriteLine("you can take flask");
            _numberflask --;
        }
    }
}
