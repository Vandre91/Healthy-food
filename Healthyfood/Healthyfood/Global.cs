using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthyfood
{
    public static class Global
    {
        static Utilisateurs  _Utilisateur = new Utilisateurs();
        static Profil_Utilisateur _Profil;
        public static Utilisateurs Utilisateur
        {
            get { return _Utilisateur; }
            set { if (value == null) value = new Utilisateurs(); }
        }
        public static Profil_Utilisateur Profil
        {
            get { return _Profil; }
            set {  _Profil = value; }
        }
    }
}
