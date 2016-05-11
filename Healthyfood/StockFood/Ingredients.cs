﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    public class Ingredients
    {
        
        public static List<string> _Name = new List<string> {"Steak de boeuf", "Collier de boeuf", "Entrecote de boeuf", "cote de boeuf", "rumsteck de boeuf", "filet de boeuf", "jarret de boeuf", "onglet de boeuf", "flanchet de boeuf", "poitrine de boeuf", "bifteck de boeuf", "collier d'agneau", "cote d'agneau", "filet d'agneau", "gigot d'agneau", "poitrine d'agneau", "epaule d'agneau", "collier de veau", "cote de veau", "filet de veau", "poitrine de veau", "epaule de veau","jarret de veau", "flanchet de veau", "tendron de veau", "echine de porc", "cote de porc", "filet de porc", "jambon de porc", "jarret de porc", "collier de cheval", "cote de cheval", "entrecote de cheval", "filet de cheval", "rumsteck de cheval", "gite de cheval", "merlan de cheval", "tranche de cheval", "jaret de cheval", "araignee de cheval", "onglet de cheval",
            "araignee de mer", "cigale de mer", "crabe", "crevette geante", "crevette grise", "crevette rose", "ecrevisse", "etrille", "gambas", "homard", "langouste", "langoustine", "limule", "tourteau", "Coque", "bucarde", "rigadeau", "rigadelle", "sourdon", "hénon", "demoiselle", "maillot", "mourgue", "pagne", "berberechos", "huitre", "moule", "palourde", "clovisse", "petoncle", "mye", "couteau de mer", "vernis", "poulpe", "pieuvre", "buccin", "gros buccin", "bourgot", "bulot", "meduse",
            "blanc de poulet", "cuisses de poulet", "pattes de poulet", "pilons de poulet", "ailes de poulet", "gesier de poulet", "foie de poulet", "coeur de poulet", "blanc de dinde", "aiguillette de dinde", "escalope de dinde", "filet de dinde", "supreme de dinde", "aileron de dinde", "manchon de dinde", "cuisses de dinde", "pilon de dinde", "aiguillettes de canard", "cuisses de canard", "filet de canard", "tournedos de canard", "aiguillettes de pintade", "cuisses de pintade", "filet de pintade", "tournedos de pintade",
            "anchois", "anguille", "brochet", "cabillaud", "colin", "daurade royale", "flétan", "loup de mer", "merlan", "omble chevalier", "perche", "plie", "raie", "rascasse du nord", "rouget barbet", "sandre", "sardine", "saumon", "sole", "thon" ,
            "lait", "absinthe", "allasch", "amaro", "amoroso", "café", "calvados", "champagne", "cognac", "eau de vie", "frambroise", "irish mist", "prunelle", "sirop", "tequila", "vin", "vodka","whisky" , "agastache de corée",
            "ail", "ail d'orient", "ail rocambol", "amarante", "aneth", "angélique","artichaut", "asperge verte", "asperge blanche", "balsamite", "bambou", "basilic", "bette à carte", "betterave rouge", "bourrache officinale", "bourrache orientale", "calebasse", "carottes", "céleri", "champignons", "chou frisé", "chou pommé", "chou rave", "chou de bruxelles", "chou brocolli", "chou fleur", "cresson", "ciboule commune", "ciboulette", "coeur de palmier", "coriande", "crambe", "cresson alénois", "echalote", "endive", "epinard", "estragon", "mache", "mais doux", "melisse turque", "menthe", "navets", "oignon rouge", "oignon blanc", "oignon jaune", "origan", "poireau", "poirée", "petit pois", "pimprenelle petite", "pois asperge", "pourpier", "radiss noir", "soja",
            "aubergine", "concombre", "cornichon", "courgette", "couge de siam", "melon", "pastèque", "piment fort", "poivre melon", "tomate", "poivrons",
            "yaourt", "fromage", "beurre", "lait de vache", "lait cru", "lait pasteurisé", "lait stérilisé", "lait UHT", "lait concentré", "lait en poudre", "lait demi écrémé", "lait entier", "lait écrémé", "crème", "crème glacée", "kefir", "viili", "lait au bifidus", "fromage frais", "fromage fermier", "fromage affiné", "fromage fondu", "caséine", "babeur", "lactosérum", "milkshake", "huile et margarine de tournesol", "huile de palme", "huile d'olive", "huiles de soja", "huiles vegetale",
            "gâteau stonehenge", "american apple pie", "tarte aux cérises", "gâteau au yaourt", "pomme et caramel", "salade de fruits", "pain perdu", "tarte à la crème de marron et de coco", "tarte aux pommes et à la vergeoise", "streusel brownies", "biscuits de la joie", "mimi au choco", "gâteau à la courge de nice","caramel mou au beurre salé", "muffins aux pommes", "baba au rhum", "poire au rapudara", "moelleux au chocolat", "poires au vin", "tarte à la rhubarbe", "mousse crémeuse chocolat aubergine", "charlotte russe aux pommes", "pommes au four", "cake au citron et aux graines de pavot", "fondant au chocolat", "salade orientale de fraises à la menthe", "douceur à la caroube", "gâteau au carotte", "makrouts","quatre quart caramélisé aux pommes", "cheese cake aux spéculoos", "cookies aux deux noix", "alfajores de maicena", "muffins vegan cacoo noisette", "cookies noisettes", "épeautre et chocolat", "fraises au yaourt", "madeleines de commercy", "cake poire noisette chocolat", "muffins au chocolat noir",
            "agave", "ail des ours", "arachide", "bardane",  "bourrache", "camomille", "cerfeuil", "consoude", "conandre",  "guimauve", "hysope", "laurier sauce", "marjolaine",  "nepeta", "persil",  "raifort", "romarin", "sarriette", "sauge", "thym", "verveine", "archillée",  "ajowan", "amande amère",  "anis", "câpres", "cardamonne", "carmin", "carvi", "casse", "graine de céléri", "chili ciboulette",  "coniaque", "cumin", "oignon", "ciboule", "échalote",  "mélisse officinale", "faux poivre", "piment", "muscade",  "tamarin", "monarde","moutarde", "blanche", "badiane", "genièvre", "armoise", "ase fétide", "bigaradier", "cédrat", "an", "eth", "fenouil", "feugrec", "galanga", "safran", "sariette", "rue", "sésame", "fève", "boulgour", "coco nain", "flageolet", "haricot rouge", "haricot blanc", "lentille", "patate douce", "pore de terre cochet", "pois cassé", "polanta", "pomme de terre", "quinoa", "riz", "soisson", "manioc",
        "apéro crunch", "babelys", "barbarines aux noix", "bâtonnets croustillants vaudois", "biscômes", "biscuits de noel", "bonbons aux fruits", "brioche", "croquettes", "croquets", "cuchaule", "farine à la meule", "farine bise", "farine complète", "farine fleur bio", "flûtes aux fromages", "flûtes nature", "lin en grains", "pain", "pain breulottier", "pain jura région", "pain au chanvre", "pain_campangnard au triticale", "pain de seigle", "pain du dézaley", "pain GRTA", "pain pavé", "pain paysan", "pain sâlois", "pain vadais", "pain vaudois", "pain au levain", "pâtes au blé dur", "petits biscuits", "pois chiche", "prunelle", "quenus", "quiche vaudoisée", "sablés", "sablée au fromage", "spirales", "tagliatelles", "tailleule neuchâteloise", "taillés aux grebons", "téotché", "téotché du boulanger", "téotché vadais", "tresse", "tresse aux beurre", "tresse aux lard", "truffes à la raisnée", "truffes aux miels", "croissant", "pain au chocolat", "croissant_beurre",
        "abricot", "airelle", "aki", "alberge", "amande", "ananas", "arbouse", "aronia", "avocat", "banane", "barbadine", "bergamote", "bigarade", "boysenberry", "brugnon", "cabosse", "cacahuète", "calamondin", "canneberge", "carambole", "casseille", "cassis", "cédrat", "cériman", "cerise", "citron", "citandrin", "citrange", "clémentine", "datte", "fraise", "frambroise",  "girembelle", "goyave", "grenade", "grenadelle", "merise", "melon", "pistache", "pastèque", "poire", "pomme", "raisin"};
        public static List<string> viande = new List<string>{ "Steak de boeuf", "Collier de boeuf", "Entrecote de boeuf", "cote de boeuf", "rumsteck de boeuf", "filet de boeuf", "jarret de boeuf", "onglet de boeuf", "flanchet de boeuf", "poitrine de boeuf", "bifteck de boeuf", "collier d'agneau", "cote d'agneau", "filet d'agneau", "gigot d'agneau", "poitrine d'agneau", "epaule d'agneau", "collier de veau", "cote de veau", "filet de veau", "poitrine de veau", "epaule de veau", "jarret de veau", "flanchet de veau", "tendron de veau", "echine de porc", "cote de porc", "filet de porc", "jambon de porc", "jarret de porc", "collier de cheval", "cote de cheval", "entrecote de cheval", "filet de cheval", "rumsteck de cheval", "gite de cheval", "merlan de cheval", "tranche de cheval", "jaret de cheval", "araignee de cheval", "onglet de cheval"};
        public static List<string> crustace = new List<string> { "araignee de mer", "cigale de mer", "crabe", "crevette geante", "crevette grise", "crevette rose", "ecrevisse", "etrille", "gambas", "homard", "langouste", "langoustine", "limule", "tourteau", "Coque", "bucarde", "rigadeau", "rigadelle", "sourdon", "hénon", "demoiselle", "maillot", "mourgue", "pagne", "berberechos", "huitre", "moule", "palourde", "clovisse", "petoncle", "mye", "couteau de mer", "vernis", "poulpe", "pieuvre", "buccin", "gros buccin", "bourgot", "bulot", "meduse"};
        public static List<string> volaille = new List<string> { "blanc de poulet", "cuisses de poulet", "pattes de poulet", "pilons de poulet", "ailes de poulet", "gesier de poulet", "foie de poulet", "coeur de poulet", "blanc de dinde", "aiguillette de dinde", "escalope de dinde", "filet de dinde", "supreme de dinde", "aileron de dinde", "manchon de dinde", "cuisses de dinde", "pilon de dinde", "aiguillettes de canard", "cuisses de canard", "filet de canard", "tournedos de canard", "aiguillettes de pintade", "cuisses de pintade", "filet de pintade", "tournedos de pintade" };
        public static List<string> poisson = new List<string>{ "anchois", "anguille", "brochet", "cabillaud", "colin", "daurade royale", "flétan", "loup de mer", "merlan", "omble chevalier", "perche", "plie", "raie", "rascasse du nord", "rouget barbet", "sandre", "sardine", "saumon", "sole", "thon"};
        public static List<string> boisson = new List<string> { "lait", "absinthe", "allasch", "amaro", "amoroso", "café", "calvados", "champagne", "cognac", "eau de vie", "frambroise", "irish mist", "prunelle", "sirop", "tequila", "vin", "vodka", "whisky" };
        public static List<string> legume = new List<string> { "aubergine", "concombre", "cornichon", "courgette", "couge de siam", "melon", "pastèque", "piment fort", "poivre melon", "tomate", "poivrons"};
        public static List<string> fruit = new List<string> { "abricot", "airelle", "aki", "alberge", "amande", "ananas", "arbouse", "aronia", "avocat", "banane", "barbadine", "bergamote", "bigarade", "boysenberry", "brugnon", "cabosse", "cacahuète", "calamondin", "canneberge", "carambole", "casseille", "cassis", "cédrat", "cériman", "cerise", "citron", "citandrin", "citrange", "clémentine", "datte", "fraise", "frambroise",  "girembelle", "goyave", "grenade", "grenadelle", "merise", "melon", "pistache", "pastèque", "poire", "pomme", "raisin"};
        public static List<string> produit_laitier = new List<string> { "yaourt", "fromage", "beurre", "lait de vache", "lait cru", "lait pasteurisé", "lait stérilisé", "lait UHT", "lait concentré", "lait en poudre", "lait demi écrémé", "lait entier", "lait écrémé", "crème", "crème glacée", "kefir", "viili", "lait au bifidus", "fromage frais", "fromage fermier", "fromage affiné", "fromage fondu", "caséine", "babeur", "lactosérum", "milkshake" };
        public static List<string> matiere_grasse = new List<string> {"huile et margarine de tournesol", "huile de palme", "huile d'olive", "huiles de soja", "huiles vegetale"};
        public static List<string> dessert_sucrerie = new List<string> { "gâteau stonehenge", "american apple pie", "tarte aux cérises", "gâteau au yaourt", "pomme et caramel", "salade de fruits", "pain perdu", "tarte à la crème de marron et de coco", "tarte aux pommes et à la vergeoise", "streusel brownies", "biscuits de la joie", "mimi au choco", "gâteau à la courge de nice", "caramel mou au beurre salé", "muffins aux pommes", "baba au rhum", "poire au rapudara", "moelleux au chocolat", "poires au vin", "tarte à la rhubarbe", "mousse crémeuse chocolat aubergine", "charlotte russe aux pommes", "pommes au four", "cake au citron et aux graines de pavot", "fondant au chocolat", "salade orientale de fraises à la menthe", "douceur à la caroube", "gâteau au carotte", "makrouts", "quatre quart caramélisé aux pommes", "cheese cake aux spéculoos", "cookies aux deux noix", "alfajores de maicena", "muffins vegan cacoo noisette", "cookies noisettes", "épeautre et chocolat", "fraises au yaourt", "madeleines de commercy", "cake poire noisette chocolat", "muffins au chocolat noir" };
        public static List<string> boulangerie = new List<string> { "apéro crunch", "babelys", "barbarines aux noix", "bâtonnets croustillants vaudois", "biscômes", "biscuits_de_noel", "bonbons aux fruits", "brioche", "croquettes", "croquets", "cuchaule", "farine à la meule", "farine bise", "farine complète", "farine fleur bio", "flûtes aux fromages", "flûtes nature", "lin en grains", "pain", "pain breulottier", "pain jura région", "pain au chanvre", "pain_campangnard au triticale", "pain de seigle", "pain du dézaley", "pain GRTA", "pain pavé", "pain paysan", "pain sâlois", "pain vadais", "pain vaudois", "pain au levain", "pâtes au blé dur", "petits biscuits", "pois chiche", "prunelle", "quenus", "quiche vaudoisée", "sablés", "sablée au fromage", "spirales", "tagliatelles", "tailleule neuchâteloise", "taillés aux grebons", "téotché", "téotché du boulanger", "téotché vadais", "tresse", "tresse aux beurre", "tresse aux lard", "truffes à la raisnée", "truffes aux miels", "croissant", "pain au chocolat", "croissant_beurre" };
        public static List<string> herbe_plante = new List<string>{ "agave", "ail des ours", "arachide", "bardane",  "bourrache", "camomille", "cerfeuil", "consoude", "conandre",  "guimauve", "hysope", "laurier sauce", "marjolaine",  "nepeta", "persil",  "raifort", "romarin", "sarriette", "sauge", "thym", "verveine", "archillée",  "ajowan", "amande amère",  "anis", "câpres", "cardamonne", "carmin", "carvi", "casse", "graine de céléri", "chili ciboulette",  "coniaque", "cumin", "oignon", "ciboule", "échalote",  "mélisse officinale", "faux poivre", "piment", "muscade",  "tamarin", "monarde","moutarde", "blanche", "badiane", "genièvre", "armoise", "ase fétide", "bigaradier", "cédrat", "an", "eth", "fenouil", "feugrec", "galanga", "safran", "sariette", "rue", "sésame"};
        public static List<string> feculent = new List<string> { "fève", "boulgour", "coco nain", "flageolet", "haricot rouge", "haricot blanc", "lentille", "patate douce", "pore de terre cochet", "pois cassé", "polanta", "pomme de terre", "quinoa", "riz", "soisson", "manioc"};
        public static List<string> _Category = new List<string> {"viande", "poisson", "crustace", "dessert_sucrerie", "boisson", "volaille", "legume", "fruit", "produit_laitier", "matiere_grasse", "feculent", "boulangerie", "herbe_plante" };

        static string _name;
        public static string _category;
        static DateTime _expiration_date;
        double _balance;


        public Ingredients (string category, string name, double balance, DateTime expiration_date)
        {
            _category = category;
            _name = name;
            _balance = balance;
            _expiration_date = expiration_date;
        }

        public string Category ()
        {
           return _category;
        }
       

        public DateTime Expiration_Date()
        {
            return _expiration_date; 
        }

        public string Name ()
        {
            return _name; 
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance =+ value; }
        }

        public double Reduce
        {
            get { return _balance; }
            set { _balance = -value; }
        }
       
    }
}
