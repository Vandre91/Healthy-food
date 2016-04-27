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

        Profil_Utilisateur (string firstName, string lastName, int age , int weight, double height , bool isFemale)
        {
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
