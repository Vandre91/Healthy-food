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
    class Utilisateurs
    {
        Dictionary<string, Profil_Utilisateur> Famille;
        int _count; // cinq utilisateurs au maximum

        internal Utilisateurs ()
        {
            Famille = new Dictionary<string, Profil_Utilisateur>() ;
        }
        public void save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new System.IO.FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(file, this);
            }
        }

        public Profil_Utilisateur CreateUser (string firstName, string lastName, int age, int weight, double height, bool isFemale)
        {
            if (Famille.ContainsKey(firstName)) throw new ArgumentException("this name must be different because it already exists", nameof(firstName));
            if (_count > 5) throw new ArgumentException("users must be less than five", nameof(_count));
            if (firstName == null || firstName == string.Empty || string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("The name must not be empty", nameof(firstName));
            if (lastName == null || lastName == string.Empty || string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("The name must not be empty", nameof(lastName));
            if (height < 1.0 || height > 2.3) throw new ArgumentException("The height does not match", nameof(height));
            Profil_Utilisateur u = new Profil_Utilisateur(firstName, lastName, age, weight, height, isFemale);
            Famille[firstName] = u;
            _count++;
            return u;
        }

        public Profil_Utilisateur FindUser (string firstName)
        {
            return Famille.ContainsKey(firstName) ? Famille[firstName] : null;
        }

        public void RemoveUser (string firstName)
        {
            if (Famille.ContainsKey(firstName))
                {
                Famille.Remove(firstName);
                _count--;
                }
        }
    }
}
