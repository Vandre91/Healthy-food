using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading.Tasks;

namespace Healthyfood
{
    [Serializable]
    public class Stock
    {
        string _name;
        int _number; // nombre des fruits
        double _amount; // QuantitE de viande 
        double _balance; //Quantite de viande disponible
        DateTime _dayOfbuy;
        DateTime _expirationDate;

        public Stock(string name, int number, double amount,DateTime dayOfbuy,  DateTime expirationDate)
        {
            if (name == null || name == string.Empty || string.IsNullOrWhiteSpace(name)) throw new ArgumentException("The name must no be empty ", nameof(name));
            if(number < 1) throw new ArgumentException("The number does not match", nameof(number));
            if (amount == 0.0) throw new ArgumentException("The amount does not match", nameof(amount));
            
            _name = name;
            _number = number;
            _amount = amount;
            _dayOfbuy = dayOfbuy;
            _expirationDate = expirationDate;

        }
        public void save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new System.IO.FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(file, this);
            }
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

        public  int GetNumber
        {
            get { return _number; }
            
        }

       public  double GetAmount
        {
            get { return _amount; }
        }

       public  double GetBalance
        {
            get { return _balance; }
        }

       public  DateTime GetExpirationDate
        {
            get { return _expirationDate; }
        }

       public  DateTime DateofBuy
        {
            get { return _dayOfbuy; }
            
            set
            {
                _dayOfbuy = value;
            }
        }

        public void AddFood(double amount)

         {
            if (amount == 0.0)
                throw new ArgumentException("The amount of food you add must be greater than 0.", "amount");
            _balance += amount;
        }

        
        public void RemoveFood(double amount, string name)
        {
            if (amount == 0.0)
                throw new ArgumentException("The amount you want to remove must be greater than 0.", "amount");
            else if (_balance - amount < 0.0)
                throw new ArgumentException("You tried to remove to much food. You can remove  ");
            else if (_name == null || name == " ")
                throw new ArgumentException(" you can remove because you don't put name of food");
            double result = _balance - amount;
            if (result < 0)
            {
                Console.WriteLine("You don't have enough food");
            }
            else
            {
                _balance = result;
            }
        }
    }
}
