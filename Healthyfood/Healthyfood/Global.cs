using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockFood;

namespace Healthyfood
{
    public static class Global
    {
        static Utilisateurs  _Utilisateur = new Utilisateurs();
        static Profil_Utilisateur _Profil;
        static Stocks _Stocks = new Stocks();
        public static List<string> viande = new List<string> { "Steak de boeuf", "Collier de boeuf", "Entrecote de boeuf", "Cote de boeuf", "Rumsteck de boeuf", "Filet de boeuf", "Jarret de boeuf", "Onglet de boeuf", "Flanchet de boeuf", "Poitrine de boeuf", "Bifteck de boeuf", "Collier d'agneau", "Cote d'agneau", "Filet d'agneau", "Gigot d'agneau", "Poitrine d'agneau", "Epaule d'agneau", "Collier de veau", "Cote de veau", "Filet de veau", "Poitrine de veau", "Epaule de veau", "Jarret de veau", "Flanchet de veau", "Tendron de veau", "Echine de porc", "Cote de porc", "Filet de porc", "Jambon de porc", "Jarret de porc", "Collier de cheval", "Cote de cheval", "Entrecote de cheval", "Filet de cheval", "Rumsteck de cheval", "Gite de cheval","Jaret de cheval", "Onglet de cheval" };
        public static List<string> boisson = new List<string> { "lait", "absinthe", "allasch", "amaro", "amoroso", "café", "calvados", "champagne", "cognac", "eau de vie", "frambroise", "irish mist", "prunelle", "sirop", "tequila", "vin", "vodka", "whisky" };
        public static List<string> dessert_sucrerie = new List<string> { "gâteau stonehenge", "american apple pie", "tarte aux cérises", "gâteau au yaourt", "pomme et caramel", "salade de fruits", "pain perdu", "tarte à la crème de marron et de coco", "tarte aux pommes et à la vergeoise", "streusel brownies", "biscuits de la joie", "mimi au choco", "gâteau à la courge de nice", "caramel mou au beurre salé", "muffins aux pommes", "baba au rhum", "poire au rapudara", "moelleux au chocolat", "poires au vin", "tarte à la rhubarbe", "mousse crémeuse chocolat aubergine", "charlotte russe aux pommes", "pommes au four", "cake au citron et aux graines de pavot", "fondant au chocolat", "salade orientale de fraises à la menthe", "douceur à la caroube", "gâteau au carotte", "makrouts", "quatre quart caramélisé aux pommes", "cheese cake aux spéculoos", "cookies aux deux noix", "alfajores de maicena", "muffins vegan cacoo noisette", "cookies noisettes", "épeautre et chocolat", "fraises au yaourt", "madeleines de commercy", "cake poire noisette chocolat", "muffins au chocolat noir" };



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
        public static Stocks Stocks
        {
            get { return _Stocks; }
            set { if (value == null) value = new Stocks(); }
        }
    }
}
