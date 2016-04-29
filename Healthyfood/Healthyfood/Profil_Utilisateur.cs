﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading.Tasks;


namespace Healthyfood
{
    [Serializable]
    public class Profil_Utilisateur
    {
        string _firstName;
        string _lastName;
        int _age;
        int _weight;
        double _height; // un réel de tel sorte que 1.8 correspond à 180 cm
        bool _isFemale;
        double _imc;

        internal Profil_Utilisateur(string firstName, string lastName, int age, int weight, double height, bool isFemale)
        {

            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _weight = weight;
            _height = height;
            _isFemale = isFemale;
        }
        public void save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new System.IO.FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(file, this);
            }
        }
        public static Profil_Utilisateur Load(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return (Profil_Utilisateur)formatter.Deserialize(file);
            }
        }

        string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value == null || value == string.Empty || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The name must not be empty", nameof(value));
                _firstName = value;
            }
        }

        internal string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == null || value == string.Empty || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The name must not be empty", nameof(value));
                _lastName = value;
            }
        }

        int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 130) throw new ArgumentException("The age must be more than 0 and less than 130", nameof(value));
                _age = value;
            }
        }

        int Weight
        {
            get { return _weight; }
            set
            {
                if (value < 2 || value > 230) throw new ArgumentException("The weight must be more than 2 and less than 230", nameof(value));
                _weight = value;
            }
        }

        double Height
        {
            get { return _height; }
            set
            {
                if (value < 30 || value > 250) throw new ArgumentException("The weight must be more than 30 and less than 250", nameof(value));
                _height = value;
            }
        }

        double Imc
        {
            get { return (_weight / (_height * _height) / 100); }
        }
    }
}
