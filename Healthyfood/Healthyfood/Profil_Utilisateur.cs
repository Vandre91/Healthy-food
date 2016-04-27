using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthyfood
{
    public class Profil_Utilisateur
    {
        string _firstName;
        string _lastName;
        int _age;
        int _weight; 
        double _height; // un réel de tel sorte que 1.8 correspond à 180 cm
        bool _isFemale;
        int _imc;

        internal Profil_Utilisateur (string firstName, string lastName, int age , int weight, double height , bool isFemale)
        {
            if (firstName == null || firstName == string.Empty || string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("The name must not be empty", nameof(firstName));
            if (lastName == null || lastName == string.Empty || string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("The name must not be empty", nameof(lastName));
            if (height < 1.0 || height > 2.3) throw new ArgumentException("The height does not match", nameof(height));
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _weight = weight;
            _height = height;
            _isFemale = isFemale;
        }

        string FirstName
        { get { return _firstName; } }

        string LastName
        { get { return _lastName; } }

        int Age
        { get { return _age; } }

        int Weight
        { get { return _weight; } }

        double Height
        { get { return _height; } }

        double Imc
        {
            get { return (_weight / (_height * _height)) ; }
        }
    }
}
