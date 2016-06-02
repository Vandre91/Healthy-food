using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StockFood
{
    [Serializable]
    public class healthyfood
    {
        Utilisateurs _Utilisateur;
        Profil_Utilisateur _Profil;
        Stocks _Stocks;
        AllRecipe _Allrecipe;
        Calories _Calories;

        public List<string> _viande;
        public List<string> _boisson;
        public List<string> _dessert_sucrerie;
        public List<string> _crustace;
        public List<string> _poisson;
        public List<string> _volaille;
        public List<string> _fruit;
        public List<string> _legume;
        public List<string> _produit_laitier;
        public List<string> _matiere_grasse;
        public List<string> _feculent;
        public List<string> _herbe_plante;
        public List<string> _boulangerie;

        public healthyfood()
        {
            _viande = new List<string> { "Steak de boeuf", "Collier de boeuf", "Entrecote de boeuf", "Cote de boeuf", "Rumsteck de boeuf", "Filet de boeuf", "Jarret de boeuf", "Onglet de boeuf", "Flanchet de boeuf", "Poitrine de boeuf", "Bifteck de boeuf", "Collier d'agneau", "Cote d'agneau", "Filet d'agneau", "Gigot d'agneau", "Poitrine d'agneau", "Epaule d'agneau", "Collier de veau", "Cote de veau", "Filet de veau", "Poitrine de veau", "Epaule de veau", "Jarret de veau", "Flanchet de veau", "Tendron de veau", "Echine de porc", "Cote de porc", "Filet de porc", "Jambon de porc", "Jarret de porc", "Collier de cheval", "Cote de cheval", "Entrecote de cheval", "Filet de cheval", "Rumsteck de cheval", "Gite de cheval", "Jaret de cheval", "Onglet de cheval" };
            _boisson = new List<string> { "lait", "absinthe", "allasch", "amaro", "amoroso", "café", "calvados", "champagne", "cognac", "eau de vie", "frambroise", "irish mist", "prunelle", "sirop", "tequila", "vin", "vodka", "whisky" };
            _dessert_sucrerie = new List<string> { "gâteau stonehenge", "american apple pie", "tarte aux cérises", "gâteau au yaourt", "pomme et caramel", "salade de fruits", "pain perdu", "tarte à la crème de marron et de coco", "tarte aux pommes et à la vergeoise", "streusel brownies", "biscuits de la joie", "mimi au choco", "gâteau à la courge de nice", "caramel mou au beurre salé", "muffins aux pommes", "baba au rhum", "poire au rapudara", "moelleux au chocolat", "poires au vin", "tarte à la rhubarbe", "mousse crémeuse chocolat aubergine", "charlotte russe aux pommes", "pommes au four", "cake au citron et aux graines de pavot", "fondant au chocolat", "salade orientale de fraises à la menthe", "douceur à la caroube", "gâteau au carotte", "makrouts", "quatre quart caramélisé aux pommes", "cheese cake aux spéculoos", "cookies aux deux noix", "alfajores de maicena", "muffins vegan cacoo noisette", "cookies noisettes", "épeautre et chocolat", "fraises au yaourt", "madeleines de commercy", "cake poire noisette chocolat", "muffins au chocolat noir" };
            _crustace = new List<string> { "araignee de mer", "cigale de mer", "crabe", "crevette geante", "crevette grise", "crevette rose", "ecrevisse", "etrille", "gambas", "homard", "langouste", "langoustine", "limule", "tourteau", "Coque", "bucarde", "rigadeau", "rigadelle", "sourdon", "hénon", "demoiselle", "maillot", "mourgue", "pagne", "berberechos", "huitre", "moule", "palourde", "clovisse", "petoncle", "mye", "couteau de mer", "vernis", "poulpe", "pieuvre", "buccin", "gros buccin", "bourgot", "bulot", "meduse" };
            _poisson = new List<string> { "anchois", "anguille", "brochet", "cabillaud", "colin", "daurade royale", "flétan", "loup de mer", "merlan", "omble chevalier", "perche", "plie", "raie", "rascasse du nord", "rouget barbet", "sandre", "sardine", "saumon", "sole", "thon" };
            _volaille = new List<string> { "blanc de poulet", "cuisses de poulet", "pattes de poulet", "pilons de poulet", "ailes de poulet", "gesier de poulet", "foie de poulet", "coeur de poulet", "blanc de dinde", "aiguillette de dinde", "escalope de dinde", "filet de dinde", "supreme de dinde", "aileron de dinde", "manchon de dinde", "cuisses de dinde", "pilon de dinde", "aiguillettes de canard", "cuisses de canard", "filet de canard", "tournedos de canard", "aiguillettes de pintade", "cuisses de pintade", "filet de pintade", "tournedos de pintade" };
            _fruit = new List<string> { "abricot", "airelle", "aki", "alberge", "amande", "ananas", "arbouse", "aronia", "avocat", "banane", "barbadine", "bergamote", "bigarade", "boysenberry", "brugnon", "cabosse", "cacahuète", "calamondin", "canneberge", "carambole", "casseille", "cassis", "cédrat", "cériman", "cerise", "citron", "citandrin", "citrange", "clémentine", "datte", "fraise", "frambroise", "girembelle", "goyave", "grenade", "grenadelle", "merise", "melon", "pistache", "pastèque", "poire", "pomme", "raisin" };
            _legume = new List<string> { "aubergine", "concombre", "cornichon", "courgette", "couge de siam", "melon", "pastèque", "piment fort", "poivre melon", "tomate", "poivrons" };
            _produit_laitier = new List<string> { "yaourt", "fromage", "beurre", "lait de vache", "lait cru", "lait pasteurisé", "lait stérilisé", "lait UHT", "lait concentré", "lait en poudre", "lait demi écrémé", "lait entier", "lait écrémé", "crème", "crème glacée", "kefir", "viili", "lait au bifidus", "fromage frais", "fromage fermier", "fromage affiné", "fromage fondu", "caséine", "babeur", "lactosérum", "milkshake" };
            _matiere_grasse = new List<string> { "huile et margarine de tournesol", "huile de palme", "huile d'olive", "huiles de soja", "huiles vegetale" };
            _feculent = new List<string> { "fève", "boulgour", "coco nain", "flageolet", "haricot rouge", "haricot blanc", "lentille", "patate douce", "pore de terre cochet", "pois cassé", "polanta", "pomme de terre", "quinoa", "riz", "soisson", "manioc" };
            _herbe_plante = new List<string> { "agave", "ail des ours", "arachide", "bardane", "bourrache", "camomille", "cerfeuil", "consoude", "conandre", "guimauve", "hysope", "laurier sauce", "marjolaine", "nepeta", "persil", "raifort", "romarin", "sarriette", "sauge", "thym", "verveine", "archillée", "ajowan", "amande amère", "anis", "câpres", "cardamonne", "carmin", "carvi", "casse", "graine de céléri", "chili ciboulette", "coniaque", "cumin", "oignon", "ciboule", "échalote", "mélisse officinale", "faux poivre", "piment", "muscade", "tamarin", "monarde", "moutarde", "blanche", "badiane", "genièvre", "armoise", "ase fétide", "bigaradier", "cédrat", "an", "eth", "fenouil", "feugrec", "galanga", "safran", "sariette", "rue", "sésame" };
            _boulangerie = new List<string> { "apéro crunch", "babelys", "barbarines aux noix", "bâtonnets croustillants vaudois", "biscômes", "biscuits_de_noel", "bonbons aux fruits", "brioche", "croquettes", "croquets", "cuchaule", "farine à la meule", "farine bise", "farine complète", "farine fleur bio", "flûtes aux fromages", "flûtes nature", "lin en grains", "pain", "pain breulottier", "pain jura région", "pain au chanvre", "pain_campangnard au triticale", "pain de seigle", "pain du dézaley", "pain GRTA", "pain pavé", "pain paysan", "pain sâlois", "pain vadais", "pain vaudois", "pain au levain", "pâtes au blé dur", "petits biscuits", "pois chiche", "prunelle", "quenus", "quiche vaudoisée", "sablés", "sablée au fromage", "spirales", "tagliatelles", "tailleule neuchâteloise", "taillés aux grebons", "téotché", "téotché du boulanger", "téotché vadais", "tresse", "tresse aux beurre", "tresse aux lard", "truffes à la raisnée", "truffes aux miels", "croissant", "pain au chocolat", "croissant_beurre" };

            _Utilisateur = new Utilisateurs();
            _Stocks = new Stocks();
            _Allrecipe = new AllRecipe();
            _Calories = new Calories();
            CreateRecipes();
        }
        public void Save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream file = new System.IO.FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(file, this);
            }
        }
        public static healthyfood Load(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return (healthyfood)formatter.Deserialize(file);
            }
        }
        public Calories Calories
        {
            get { return _Calories; }
            set { _Calories = value; }
        }
        public Utilisateurs Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }
        public Profil_Utilisateur Profil
        {
            get { return _Profil; }
            set { _Profil = value; }
        }
        public Stocks Stocks
        {
            get { return _Stocks; }
            set { _Stocks = value; }
        }
        public AllRecipe AllRecipe
        {
            get { return _Allrecipe; }
            set { _Allrecipe = value; }
        }
        public void CreateIngredient(string category, string name)
        {
            if (category == "viande") _viande.Add(name);
            if (category == "poisson") _poisson.Add(name);
            if (category == "crustace") _crustace.Add(name);
            if (category == "dessert_sucrerie") _dessert_sucrerie.Add(name);
            if (category == "boisson") _boisson.Add(name);
            if (category == "volaille") _volaille.Add(name);
            if (category == "legume") _legume.Add(name);
            if (category == "fruit") _fruit.Add(name);
            if (category == "produit_laitier") _produit_laitier.Add(name);
            if (category == "matiere_grasse") _matiere_grasse.Add(name);
            if (category == "feculent") _feculent.Add(name);
            if (category == "boulangerie") _boulangerie.Add(name);
            if (category == "herbe_plante") _herbe_plante.Add(name);
        }
        public double CalculCal(double quantity,double calcent)
        {
            double cal = calcent / 100;
            double calend = quantity * cal;
            return calend;
        } 
        public void CreateRecipes()
        {
            #region Tomates au chévre
            Ingredients a = new Ingredients("legume", "tomate", 4, DateTime.Today);
            Ingredients b = new Ingredients("matiere_grasse", "chévre", 2, DateTime.Today);
            Ingredients c = new Ingredients("herbe_plante", "poivre", 2, DateTime.Today);
            Ingredients d = new Ingredients("herbe_plante", "salade", 100, DateTime.Today);
            List<Ingredients> recipes = new List<Ingredients> { a,b,c,d };
            _Allrecipe.AddHealthyrecipe("Tomates au chèvre frais", recipes, "Evider les tomates et conserver le chapeau. les remplir de chèvre, fermer avec le chapeau de la tomate.Mettre à four moyen une vingtaine de minutes.Servir avec une salade.");
            #endregion
            #region Cote de porc
            Ingredients e = new Ingredients("viande", "Cotes de porc ", 400, DateTime.Today);
            Ingredients f = new Ingredients("matiere_grasse", "beurre", 100, DateTime.Today);
            Ingredients g = new Ingredients("herbe_plante", "poivre", 2, DateTime.Today);
            Ingredients h = new Ingredients("herbe_plante", "Sel", 2, DateTime.Today);
            List<Ingredients> recipe = new List<Ingredients> { e, f, g, h };
            _Allrecipe.AddHealthyrecipe("Côtes de porc au citron", recipe, "Faire cuire les 2 côtes de porc dans la magarine. 10 minutes avant la fin de la cuisson, saler, poivrer, couper le citron en 2, arroser les côtes avec son jus.Mettre aussi les 2 bouts de citrons dans la poêle, ça donnera plus de goût. S'accompagne très bien avec des frites. ");
            #endregion
            
            #region Salade de tomates,  de haricots verts et d'aiglefin poché au vin 
            Ingredients salade1 = new Ingredients("poisson", "aiglefin frais",225, DateTime.Today);
            Ingredients salade2 = new Ingredients("boisson", "vin blanc", 60, DateTime.Today);
            Ingredients salade3 = new Ingredients("feculent", "haricots_verts", 225, DateTime.Today);
            Ingredients salade4 = new Ingredients("legume", "tomates cerises multicolores coupées", 350, DateTime.Today);
            Ingredients salade5 = new Ingredients("herbe_plante", "coriande fraiches ciselée", 30, DateTime.Today);
            Ingredients salade6 = new Ingredients("herbe_plante", "ciboulette ciselée", 30, DateTime.Today);
            Ingredients salade7 = new Ingredients("boisson", "jus de citron", 30, DateTime.Today);
            Ingredients salade8 = new Ingredients("matiere grasse", "huile de Olive", 15, DateTime.Today);
            Ingredients salade9 = new Ingredients("viande", "oeufs durs coupés en deux", 2, DateTime.Today);
            Ingredients salade10 = new Ingredients("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredients> recipesalade = new List<Ingredients> { salade1, salade2, salade3, salade4, salade5, salade6, salade7, salade8, salade9, salade10 };
            _Allrecipe.AddHealthyrecipe(" Salade de tomates, de haricots verts et d'aiglefin poché au vin", recipesalade, "Dans une poêle antiadhésive, placer l’aiglefin et le vin blanc. Couvrir et porter à ébullition. Laisser mijoter environ 4 minutes ou jusqu’à ce que le poisson soit cuit et qu’il se défasse en gros flocons., Dans une casserole d’eau bouillante salée, cuire les haricots jusqu’à ce qu’ils soient tendres. Plonger dans l’eau glacée et égoutter. Séparer les haricots en deux sur la longueur si désiré.,Dans un bol, mélanger les haricots, les tomates, les herbes, le jus de citron et l’huile d’olive. Saler et poivrer. Répartir dans 4 assiettes. Garnir de gros flocons de poisson et d’un demi-oeuf dur.");
            #endregion

            #region couscous au jus  de carotte
            Ingredients Couscous1 = new Ingredients("dessert_sucrerie", "jus de carotte", 500, DateTime.Today);
            Ingredients Couscous2 = new Ingredients("dessert_sucrerie", "miel", 15, DateTime.Today);
            Ingredients couscous3 = new Ingredients("legume", "poivre noir concassé", 2, DateTime.Today);
            Ingredients couscous4 = new Ingredients("herbe_plante", " couscous", 400, DateTime.Today);
            List<Ingredients> recipecouscous = new List<Ingredients> { Couscous1, Couscous2, couscous3, couscous4 };
            _Allrecipe.AddHealthyrecipe("couscous au jus de carotte", recipecouscous, "Dans un bol, mélanger le couscous, les carottes et les petits pois. Ajouter l'eau bouillante, couvrir et laisser reposer pendant 5 minutes ou jusqu'à ce que les légumes soient tendres mais encore croquants et que l'eau soit absorbée. À l'aide d'une fourchette, détacher les grains de couscous.");
            #endregion
            #region salade de chou-fleur et de petits pois
            Ingredients chou1 = new Ingredients("legume", "chou-fleur", 600, DateTime.Today);
            Ingredients chou2 = new Ingredients("legume", "tomates cerises", 280, DateTime.Today);
            Ingredients chou3 = new Ingredients("legume", "oignons vert", 2, DateTime.Today);
            Ingredients chou4 = new Ingredients("fruit", "citron", 1, DateTime.Today);
            Ingredients chou5 = new Ingredients("matiere_grasse", "huile d'olive", 45, DateTime.Today);
            Ingredients chou6 = new Ingredients("matiere_grasse", "huile d'olive", 30, DateTime.Today);
            Ingredients chou7 = new Ingredients("herbe_plante", "moutarcde", 15, DateTime.Today);
            Ingredients chou8 = new Ingredients("herbe_plante", "menthe", 15, DateTime.Today);
            Ingredients chou9 = new Ingredients("herbe_plante", "basilic", 15, DateTime.Today);
            Ingredients chou10 = new Ingredients("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredients> recipechou = new List<Ingredients> { chou1, chou2, chou3, chou4, chou5, chou6, chou7, chou8, chou9, chou10 };
            _Allrecipe.AddHealthyrecipe(" salade de chou-fleur et de petits pois", recipechou, "1.Dans une casserole d'eau bouillante salée, cuire le chou-fleur environ  2 minutes ou jusqu'à ce qu'il soit al dente. Refroidir dans le bol d'eau glacée.Egoutter et réservé dans un bol.2 Ajouter le rester  des ingrédients.Saler et poivrer.Mélanger");
            #endregion

            #region Haricots vert  rémoulade

            Ingredients haricot1 = new Ingredients("feculent", "haricots verts parés", 454, DateTime.Today);
            Ingredients haricot2 = new Ingredients("matiere_grasse", "mayonnaise", 30, DateTime.Today);
            Ingredients haricot3 = new Ingredients("herbe_plante", "thé de moutarde de Dijon", 10, DateTime.Today);
            Ingredients haricot4 = new Ingredients("boisson", "vinaigre de vin blanc", 10, DateTime.Today);
            Ingredients haricot5 = new Ingredients("legume", "capres hachées", 5, DateTime.Today);
            Ingredients haricot6 = new Ingredients("legume", "purée de raifort", 3, DateTime.Today);
            Ingredients haricot7 = new Ingredients("legume", "oignons verts", 2, DateTime.Today);
            Ingredients haricot8 = new Ingredients("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredients> recipeharicot = new List<Ingredients> { haricot1, haricot2, haricot3, haricot4, haricot5, haricot6, haricot7, haricot8 };
            _Allrecipe.AddHealthyrecipe("haricots vert rémoulade", recipeharicot, "1.Dans une casserole d'eau bouillante salée, cuire les haricots environ 5 minutes ou jusqu'à ce qu'ils soient tendres.Refroidir dans l'eau glacé. 2  si désiré, sur un plan  de travail, diviser les haricots en deux dans le sens de la longueur(voir  note).3 Dans un grand bol,mélanger la mayonnaise, la moutarde,le vinaigre, les capres et le raifort.Ajouter les haricots.Saler, poivrer et mélanger ");
            #endregion

        }
    }
}
