using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    public class Meat
    {
        string _name;
        double _amount; //viande à ajouter
        double _balance; // viande dispo
        
        DateTime _expirationDay;

        public Meat(string name, double amount, double balance,  DateTime expirationDay)
        {
            if (name == null || name == string.Empty || string.IsNullOrWhiteSpace(name)) throw new ArgumentException("The name must no be empty ", nameof(name));
            if (amount == 0.0) throw new ArgumentException(" The amount does not match", nameof(amount));
            if (balance == 0.0) throw new ArgumentException("you need to add  meat", nameof(balance));

            _name = name;
            _amount = amount;
            _balance = balance;
            _expirationDay = expirationDay;
        }

        public  string Name
        {
            get { return _name; }
            set
            {
                if (value == null || value == string.Empty || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The name must not be empty", nameof(value));
                _name = value;
            }
        }
        public double GetBalance
        {
            get { return _balance; }

        }
        public double Amount
        {
            get { return _amount; }
            set
            {
                if ( value == 0.0) throw new ArgumentException("where is meat for add???", nameof(value));
                _amount = value;
            }
        }

        
        public DateTime Expirationday
        {
            get { return _expirationDay; }
            set { _expirationDay = value; }
        }

        public void AddMeat(double amount, double balance)
        {
            if (amount == 0.0)
                throw new ArgumentException("the amount of meat you add must be greater than 0.", " amount ");
            else if (balance < 1.0)
            _balance += amount;
        }
        
        public void RemoveMeat(double amount, string name)
        {
            if (amount == 0.0)
                throw new ArgumentException(" the amount of meat you add must be greater than 0.", "amount ");
            else if (_balance - amount < 0.0)
                throw new ArgumentException(" you tried to remove much food. You can remove");
            else if (_name == null || _name == " ")
                throw new ArgumentException("you can remove because you don't put name of meat");

            double result = _balance - amount;

            if (result < 0)
            {
                Console.WriteLine(" you don't have enough meat");
            }

            else
                _balance = result;
            }
        }
    }

