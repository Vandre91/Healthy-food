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
    public class Utilisateurs
    {
        Dictionary<string, Profil_Utilisateur> Famille;
        int _count; // cinq utilisateurs au maximum

        public Utilisateurs()
        {
            Famille = new Dictionary<string, Profil_Utilisateur>();
        }
        public void save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new System.IO.FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(file, this);
            }
        }

        public Profil_Utilisateur CreateUser(string firstName, string lastName, int age, int weigth, double heigth, bool isFemale, bool isVegetarian)
        {

            if (_count == 5) throw new ArgumentException("users must be less than five", nameof(_count));
            if (age < 0 || age > 130) throw new ArgumentException("Age must be between 0 and 130", nameof(age));
            if (firstName == null || firstName == string.Empty || string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("The name must not be empty", nameof(firstName));
            if (lastName == null || lastName == string.Empty || string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("The name must not be empty", nameof(lastName));
            if (Famille.ContainsKey(naming(firstName,lastName))) throw new ArgumentException("this name must be different because it already exists", nameof(lastName));
            if (heigth < 30 || heigth > 230) throw new ArgumentException("The height does not match", nameof(heigth));
            if (weigth < 0 || weigth > 250) throw new ArgumentException("The height does not match", nameof(weigth));
            Profil_Utilisateur u = new Profil_Utilisateur(firstName, lastName, age, weigth, heigth, isFemale, isVegetarian);
            Famille[naming(firstName, lastName)] = u;
            _count++;
            return u;
        }

        public Profil_Utilisateur FindUser(string firstName, string lastName)
        {
            if (Famille.ContainsKey(naming(firstName, lastName)))
            {return Famille[naming(firstName, lastName)]; }
            else
            { throw new ArgumentException("This user does not exist", nameof(firstName)); }
        }

        public void RemoveUser(string firstName, string LastName)
        {
            if (Famille.ContainsKey(naming(firstName, LastName)))
            {
                Famille.Remove(naming(firstName, LastName));
                _count--;
            }
            else throw new ArgumentException("This user does not exist", nameof(firstName));
        }

        public string naming (string firstName, string LastName)
        { return (firstName + " " + LastName); }
    }
}
