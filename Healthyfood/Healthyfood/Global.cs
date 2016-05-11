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
        public static List<string> viande = new List<string> { "Steak de boeuf", "Collier de boeuf", "Entrecote de boeuf", "cote de boeuf", "rumsteck de boeuf", "filet de boeuf", "jarret de boeuf", "onglet de boeuf", "flanchet de boeuf", "poitrine de boeuf", "bifteck de boeuf", "collier d'agneau", "cote d'agneau", "filet d'agneau", "gigot d'agneau", "poitrine d'agneau", "epaule d'agneau", "collier de veau", "cote de veau", "filet de veau", "poitrine de veau", "epaule de veau", "jarret de veau", "flanchet de veau", "tendron de veau", "echine de porc", "cote de porc", "filet de porc", "jambon de porc", "jarret de porc", "collier de cheval", "cote de cheval", "entrecote de cheval", "filet de cheval", "rumsteck de cheval", "gite de cheval", "merlan de cheval", "tranche de cheval", "jaret de cheval", "araignee de cheval", "onglet de cheval" };
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
