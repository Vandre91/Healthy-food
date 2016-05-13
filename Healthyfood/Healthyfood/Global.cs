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
        public static List<string> crustace = new List<string> { "araignee de mer", "cigale de mer", "crabe", "crevette geante", "crevette grise", "crevette rose", "ecrevisse", "etrille", "gambas", "homard", "langouste", "langoustine", "limule", "tourteau", "Coque", "bucarde", "rigadeau", "rigadelle", "sourdon", "hénon", "demoiselle", "maillot", "mourgue", "pagne", "berberechos", "huitre", "moule", "palourde", "clovisse", "petoncle", "mye", "couteau de mer", "vernis", "poulpe", "pieuvre", "buccin", "gros buccin", "bourgot", "bulot", "meduse" };
        public static List<string> poisson = new List<string> { "anchois", "anguille", "brochet", "cabillaud", "colin", "daurade royale", "flétan", "loup de mer", "merlan", "omble chevalier", "perche", "plie", "raie", "rascasse du nord", "rouget barbet", "sandre", "sardine", "saumon", "sole", "thon" };
        public static List<string> volaille = new List<string> { "blanc de poulet", "cuisses de poulet", "pattes de poulet", "pilons de poulet", "ailes de poulet", "gesier de poulet", "foie de poulet", "coeur de poulet", "blanc de dinde", "aiguillette de dinde", "escalope de dinde", "filet de dinde", "supreme de dinde", "aileron de dinde", "manchon de dinde", "cuisses de dinde", "pilon de dinde", "aiguillettes de canard", "cuisses de canard", "filet de canard", "tournedos de canard", "aiguillettes de pintade", "cuisses de pintade", "filet de pintade", "tournedos de pintade" };
        public static List<string> fruit = new List<string> { "abricot", "airelle", "aki", "alberge", "amande", "ananas", "arbouse", "aronia", "avocat", "banane", "barbadine", "bergamote", "bigarade", "boysenberry", "brugnon", "cabosse", "cacahuète", "calamondin", "canneberge", "carambole", "casseille", "cassis", "cédrat", "cériman", "cerise", "citron", "citandrin", "citrange", "clémentine", "datte", "fraise", "frambroise", "girembelle", "goyave", "grenade", "grenadelle", "merise", "melon", "pistache", "pastèque", "poire", "pomme", "raisin" };
        public static List<string> legume = new List<string> { "aubergine", "concombre", "cornichon", "courgette", "couge de siam", "melon", "pastèque", "piment fort", "poivre melon", "tomate", "poivrons" };
        public static List<string> produit_laitier = new List<string> { "yaourt", "fromage", "beurre", "lait de vache", "lait cru", "lait pasteurisé", "lait stérilisé", "lait UHT", "lait concentré", "lait en poudre", "lait demi écrémé", "lait entier", "lait écrémé", "crème", "crème glacée", "kefir", "viili", "lait au bifidus", "fromage frais", "fromage fermier", "fromage affiné", "fromage fondu", "caséine", "babeur", "lactosérum", "milkshake" };
        public static List<string> matiere_grasse = new List<string> { "huile et margarine de tournesol", "huile de palme", "huile d'olive", "huiles de soja", "huiles vegetale" };
        public static List<string> feculent = new List<string> { "fève", "boulgour", "coco nain", "flageolet", "haricot rouge", "haricot blanc", "lentille", "patate douce", "pore de terre cochet", "pois cassé", "polanta", "pomme de terre", "quinoa", "riz", "soisson", "manioc" };
        public static List<string> herbe_plante = new List<string> { "agave", "ail des ours", "arachide", "bardane", "bourrache", "camomille", "cerfeuil", "consoude", "conandre", "guimauve", "hysope", "laurier sauce", "marjolaine", "nepeta", "persil", "raifort", "romarin", "sarriette", "sauge", "thym", "verveine", "archillée", "ajowan", "amande amère", "anis", "câpres", "cardamonne", "carmin", "carvi", "casse", "graine de céléri", "chili ciboulette", "coniaque", "cumin", "oignon", "ciboule", "échalote", "mélisse officinale", "faux poivre", "piment", "muscade", "tamarin", "monarde", "moutarde", "blanche", "badiane", "genièvre", "armoise", "ase fétide", "bigaradier", "cédrat", "an", "eth", "fenouil", "feugrec", "galanga", "safran", "sariette", "rue", "sésame" };
        public static List<string> boulangerie = new List<string> { "apéro crunch", "babelys", "barbarines aux noix", "bâtonnets croustillants vaudois", "biscômes", "biscuits_de_noel", "bonbons aux fruits", "brioche", "croquettes", "croquets", "cuchaule", "farine à la meule", "farine bise", "farine complète", "farine fleur bio", "flûtes aux fromages", "flûtes nature", "lin en grains", "pain", "pain breulottier", "pain jura région", "pain au chanvre", "pain_campangnard au triticale", "pain de seigle", "pain du dézaley", "pain GRTA", "pain pavé", "pain paysan", "pain sâlois", "pain vadais", "pain vaudois", "pain au levain", "pâtes au blé dur", "petits biscuits", "pois chiche", "prunelle", "quenus", "quiche vaudoisée", "sablés", "sablée au fromage", "spirales", "tagliatelles", "tailleule neuchâteloise", "taillés aux grebons", "téotché", "téotché du boulanger", "téotché vadais", "tresse", "tresse aux beurre", "tresse aux lard", "truffes à la raisnée", "truffes aux miels", "croissant", "pain au chocolat", "croissant_beurre" };

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
        public static void CreateIngredient(string category, string name)
        {
                if (category == "viande") viande.Add(name);
                if (category == "poisson") poisson.Add(name);
                if (category == "crustace") crustace.Add(name);
                if (category == "dessert_sucrerie") dessert_sucrerie.Add(name);
                if (category == "boisson") boisson.Add(name);
                if (category == "volaille") volaille.Add(name);
                if (category == "legume") legume.Add(name);
                if (category == "fruit") fruit.Add(name);
                if (category == "produit_laitier") produit_laitier.Add(name);
                if (category == "matiere_grasse") matiere_grasse.Add(name);
                if (category == "feculent") feculent.Add(name);
                if (category == "boulangerie") boulangerie.Add(name);
                if (category == "herbe_plante") herbe_plante.Add(name);
         }
    }
}
