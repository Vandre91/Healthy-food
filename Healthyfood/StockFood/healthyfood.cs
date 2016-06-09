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
        Users _Utilisateur;
        UserProfile _Profil;
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
            _boisson = new List<string> { "vin blanc", "lait", "absinthe", "allasch", "amaro", "amoroso", "café", "calvados", "champagne", "cognac", "eau de vie", "frambroise", "irish mist", "prunelle", "sirop", "tequila", "vin", "vodka", "whisky" };
            _dessert_sucrerie = new List<string> { "gâteau stonehenge", "american apple pie", "tarte aux cérises", "gâteau au yaourt", "pomme et caramel", "salade de fruits", "pain perdu", "tarte à la crème de marron et de coco", "tarte aux pommes et à la vergeoise", "streusel brownies", "biscuits de la joie", "mimi au choco", "gâteau à la courge de nice", "caramel mou au beurre salé", "muffins aux pommes", "baba au rhum", "poire au rapudara", "moelleux au chocolat", "poires au vin", "tarte à la rhubarbe", "mousse crémeuse chocolat aubergine", "charlotte russe aux pommes", "pommes au four", "cake au citron et aux graines de pavot", "fondant au chocolat", "salade orientale de fraises à la menthe", "douceur à la caroube", "gâteau au carotte", "makrouts", "quatre quart caramélisé aux pommes", "cheese cake aux spéculoos", "cookies aux deux noix", "alfajores de maicena", "muffins vegan cacoo noisette", "cookies noisettes", "épeautre et chocolat", "fraises au yaourt", "madeleines de commercy", "cake poire noisette chocolat", "muffins au chocolat noir" };
            _crustace = new List<string> { "araignee de mer", "cigale de mer", "crabe", "crevette geante", "crevette grise", "crevette rose", "ecrevisse", "etrille", "gambas", "homard", "langouste", "langoustine", "limule", "tourteau", "Coque", "bucarde", "rigadeau", "rigadelle", "sourdon", "hénon", "demoiselle", "maillot", "mourgue", "pagne", "berberechos", "huitre", "moule", "palourde", "clovisse", "petoncle", "mye", "couteau de mer", "vernis", "poulpe", "pieuvre", "buccin", "gros buccin", "bourgot", "bulot", "meduse" };
            _poisson = new List<string> { "anchois", "aiglefin frais", "anguille", "brochet", "cabillaud", "colin", "daurade royale", "flétan", "loup de mer", "merlan", "omble chevalier", "perche", "plie", "raie", "rascasse du nord", "rouget barbet", "sandre", "sardine", "saumon", "sole", "thon" };
            _volaille = new List<string> { "blanc de poulet", "cuisses de poulet", "pattes de poulet", "pilons de poulet", "ailes de poulet", "gesier de poulet", "foie de poulet", "coeur de poulet", "blanc de dinde", "aiguillette de dinde", "escalope de dinde", "filet de dinde", "supreme de dinde", "aileron de dinde", "manchon de dinde", "cuisses de dinde", "pilon de dinde", "aiguillettes de canard", "cuisses de canard", "filet de canard", "tournedos de canard", "aiguillettes de pintade", "cuisses de pintade", "filet de pintade", "tournedos de pintade" };
            _fruit = new List<string> { "abricot", "airelle", "aki", "alberge", "amande", "ananas", "arbouse", "aronia", "avocat", "banane", "barbadine", "bergamote", "bigarade", "boysenberry", "brugnon", "cabosse", "cacahuète", "calamondin", "canneberge", "carambole", "casseille", "cassis", "cédrat", "cériman", "cerise", "citron", "citandrin", "citrange", "clémentine", "datte", "fraise", "frambroise", "girembelle", "goyave", "grenade", "grenadelle", "merise", "melon", "pistache", "pastèque", "poire", "pomme", "raisin" };
            _legume = new List<string> { "aubergine", "concombre", "cornichon", "courgette", "couge de siam", "melon", "pastèque", "piment fort", "poivre melon", "tomate", "poivrons" };
            _produit_laitier = new List<string> { "yaourt", "fromage", "beurre", "lait de vache", "lait cru", "lait pasteurisé", "lait stérilisé", "lait UHT", "lait concentré", "lait en poudre", "lait demi écrémé", "lait entier", "lait écrémé", "crème", "crème glacée", "kefir", "viili", "lait au bifidus", "fromage frais", "fromage fermier", "fromage affiné", "fromage fondu", "caséine", "babeur", "lactosérum", "milkshake" };
            _matiere_grasse = new List<string> { "huile et margarine de tournesol", "huile de palme", "huile d'olive", "huiles de soja", "huiles vegetale" };
            _feculent = new List<string> { "fève", "boulgour", "coco nain", "flageolet", "haricot rouge", "haricot blanc", "lentille", "patate douce", "pore de terre cochet", "pois cassé", "polanta", "pomme de terre", "quinoa", "riz", "soisson", "manioc" };
            _herbe_plante = new List<string> { "agave", "ail des ours", "arachide", "bardane", "bourrache", "camomille", "cerfeuil", "consoude", "conandre", "guimauve", "hysope", "laurier sauce", "marjolaine", "nepeta", "persil", "raifort", "romarin", "sarriette", "sauge", "thym", "verveine", "archillée", "ajowan", "amande amère", "anis", "câpres", "cardamonne", "carmin", "carvi", "casse", "graine de céléri", "chili ciboulette", "coniaque", "cumin", "oignon", "ciboule", "échalote", "mélisse officinale", "faux poivre", "piment", "muscade", "tamarin", "monarde", "moutarde", "blanche", "badiane", "genièvre", "armoise", "ase fétide", "bigaradier", "cédrat", "an", "eth", "fenouil", "feugrec", "galanga", "safran", "sariette", "rue", "sésame" };
            _boulangerie = new List<string> { "apéro crunch", "babelys", "barbarines aux noix", "bâtonnets croustillants vaudois", "biscômes", "biscuits_de_noel", "bonbons aux fruits", "brioche", "croquettes", "croquets", "cuchaule", "farine à la meule", "farine bise", "farine complète", "farine fleur bio", "flûtes aux fromages", "flûtes nature", "lin en grains", "pain", "pain breulottier", "pain jura région", "pain au chanvre", "pain_campangnard au triticale", "pain de seigle", "pain du dézaley", "pain GRTA", "pain pavé", "pain paysan", "pain sâlois", "pain vadais", "pain vaudois", "pain au levain", "pâtes au blé dur", "petits biscuits", "pois chiche", "prunelle", "quenus", "quiche vaudoisée", "sablés", "sablée au fromage", "spirales", "tagliatelles", "tailleule neuchâteloise", "taillés aux grebons", "téotché", "téotché du boulanger", "téotché vadais", "tresse", "tresse aux beurre", "tresse aux lard", "truffes à la raisnée", "truffes aux miels", "croissant", "pain au chocolat", "croissant_beurre" };

            _Utilisateur = new Users();
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
        public Users Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }
        public UserProfile Profil
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
            Ingredient a = new Ingredient("legume", "tomate", 100, DateTime.Today);
            Ingredient b = new Ingredient("matiere_grasse", "chévre", 100, DateTime.Today);
            Ingredient c = new Ingredient("herbe_plante", "poivre", 2, DateTime.Today);
            Ingredient d = new Ingredient("herbe_plante", "salade", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { a,b,c,d };
            _Allrecipe.AddHealthyrecipe("Tomates au chèvre frais", recipes, "Evider les tomates et conserver le chapeau. les remplir de chèvre, fermer avec le chapeau de la tomate.Mettre à four moyen une vingtaine de minutes.Servir avec une salade.");
            #endregion
            #region Cote de porc
            Ingredient e = new Ingredient("viande", "Cotes de porc ", 400, DateTime.Today);
            Ingredient f = new Ingredient("matiere_grasse", "beurre", 100, DateTime.Today);
            Ingredient g = new Ingredient("herbe_plante", "poivre", 2, DateTime.Today);
            Ingredient h = new Ingredient("herbe_plante", "Sel", 2, DateTime.Today);
            List<Ingredient> recipe = new List<Ingredient> { e, f, g, h };
            _Allrecipe.AddHealthyrecipe("Côtes de porc au citron", recipe, "Faire cuire les 2 côtes de porc dans la magarine. 10 minutes avant la fin de la cuisson, saler, poivrer, couper le citron en 2, arroser les côtes avec son jus.Mettre aussi les 2 bouts de citrons dans la poêle, ça donnera plus de goût. S'accompagne très bien avec des frites. ");
            #endregion
            
            #region Salade de tomates,  de haricots verts et d'aiglefin poché au vin 
            Ingredient salade1 = new Ingredient("poisson", "aiglefin frais",225, DateTime.Today);
            Ingredient salade2 = new Ingredient("boisson", "vin blanc", 60, DateTime.Today);
            Ingredient salade3 = new Ingredient("legume", "haricots verts", 225, DateTime.Today);
            Ingredient salade4 = new Ingredient("legume", "tomates cerises multicolores coupées", 350, DateTime.Today);
            Ingredient salade5 = new Ingredient("herbe_plante", "coriande fraiches ciselée", 30, DateTime.Today);
            Ingredient salade6 = new Ingredient("herbe_plante", "ciboulette ciselée", 30, DateTime.Today);
            Ingredient salade7 = new Ingredient("boisson", "jus de citron", 30, DateTime.Today);
            Ingredient salade8 = new Ingredient("matiere grasse", "huile de Olive", 15, DateTime.Today);
            Ingredient salade9 = new Ingredient("viande", "oeufs durs coupés en deux", 2, DateTime.Today);
            Ingredient salade10 = new Ingredient("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredient> recipesalade = new List<Ingredient> { salade1, salade2, salade3, salade4, salade5, salade6, salade7, salade8, salade9, salade10 };
            _Allrecipe.AddHealthyrecipe(" Salade de tomates, de haricots verts et d'aiglefin poché au vin", recipesalade, "Dans une poêle antiadhésive, placer l’aiglefin et le vin blanc. Couvrir et porter à ébullition. Laisser mijoter environ 4 minutes ou jusqu’à ce que le poisson soit cuit et qu’il se défasse en gros flocons., Dans une casserole d’eau bouillante salée, cuire les haricots jusqu’à ce qu’ils soient tendres. Plonger dans l’eau glacée et égoutter. Séparer les haricots en deux sur la longueur si désiré.,Dans un bol, mélanger les haricots, les tomates, les herbes, le jus de citron et l’huile d’olive. Saler et poivrer. Répartir dans 4 assiettes. Garnir de gros flocons de poisson et d’un demi-oeuf dur.");
            #endregion

            #region couscous au jus  de carotte
            Ingredient Couscous1 = new Ingredient("dessert_sucrerie", "jus de carotte", 500, DateTime.Today);
            Ingredient Couscous2 = new Ingredient("dessert_sucrerie", "miel", 15, DateTime.Today);
            Ingredient couscous3 = new Ingredient("legume", "poivre noir concassé", 2, DateTime.Today);
            Ingredient couscous4 = new Ingredient("herbe_plante", " couscous", 400, DateTime.Today);
            List<Ingredient> recipecouscous = new List<Ingredient> { Couscous1, Couscous2, couscous3, couscous4 };
            _Allrecipe.AddHealthyrecipe("couscous au jus de carotte", recipecouscous, "Dans un bol, mélanger le couscous, les carottes et les petits pois. Ajouter l'eau bouillante, couvrir et laisser reposer pendant 5 minutes ou jusqu'à ce que les légumes soient tendres mais encore croquants et que l'eau soit absorbée. À l'aide d'une fourchette, détacher les grains de couscous.");
            #endregion
            #region salade de chou-fleur et de petits pois
            Ingredient chou1 = new Ingredient("legume", "chou-fleur", 600, DateTime.Today);
            Ingredient chou2 = new Ingredient("legume", "tomates cerises", 280, DateTime.Today);
            Ingredient chou3 = new Ingredient("legume", "oignons vert", 2, DateTime.Today);
            Ingredient chou4 = new Ingredient("fruit", "citron", 1, DateTime.Today);
            Ingredient chou5 = new Ingredient("matiere_grasse", "huile d'olive", 45, DateTime.Today);
            Ingredient chou6 = new Ingredient("matiere_grasse", "huile d'olive", 30, DateTime.Today);
            Ingredient chou7 = new Ingredient("herbe_plante", "moutarcde", 15, DateTime.Today);
            Ingredient chou8 = new Ingredient("herbe_plante", "menthe", 15, DateTime.Today);
            Ingredient chou9 = new Ingredient("herbe_plante", "basilic", 15, DateTime.Today);
            Ingredient chou10 = new Ingredient("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredient> recipechou = new List<Ingredient> { chou1, chou2, chou3, chou4, chou5, chou6, chou7, chou8, chou9, chou10 };
            _Allrecipe.AddHealthyrecipe(" salade de chou-fleur et de petits pois", recipechou, "1.Dans une casserole d'eau bouillante salée, cuire le chou-fleur environ  2 minutes ou jusqu'à ce qu'il soit al dente. Refroidir dans le bol d'eau glacée.Egoutter et réservé dans un bol.2 Ajouter le rester  des ingrédients.Saler et poivrer.Mélanger");
            #endregion

            #region Haricots vert  rémoulade

            Ingredient haricot1 = new Ingredient("feculent", "haricots verts parés", 454, DateTime.Today);
            Ingredient haricot2 = new Ingredient("matiere_grasse", "mayonnaise", 30, DateTime.Today);
            Ingredient haricot3 = new Ingredient("herbe_plante", "thé de moutarde de Dijon", 10, DateTime.Today);
            Ingredient haricot4 = new Ingredient("boisson", "vinaigre de vin blanc", 10, DateTime.Today);
            Ingredient haricot5 = new Ingredient("legume", "capres hachées", 5, DateTime.Today);
            Ingredient haricot6 = new Ingredient("legume", "purée de raifort", 3, DateTime.Today);
            Ingredient haricot7 = new Ingredient("legume", "oignons verts", 2, DateTime.Today);
            Ingredient haricot8 = new Ingredient("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredient> recipeharicot = new List<Ingredient> { haricot1, haricot2, haricot3, haricot4, haricot5, haricot6, haricot7, haricot8 };
            _Allrecipe.AddHealthyrecipe("haricots vert rémoulade", recipeharicot, "1.Dans une casserole d'eau bouillante salée, cuire les haricots environ 5 minutes ou jusqu'à ce qu'ils soient tendres.Refroidir dans l'eau glacé. 2  si désiré, sur un plan  de travail, diviser les haricots en deux dans le sens de la longueur(voir  note).3 Dans un grand bol,mélanger la mayonnaise, la moutarde,le vinaigre, les capres et le raifort.Ajouter les haricots.Saler, poivrer et mélanger ");
            #endregion

            #region Casserole de poulet au mais, aux petits pois  et aux tomates succotash

            Ingredient poulet1 = new Ingredient("herbe_plante", "graines de coriande concassé", 5, DateTime.Today);
            Ingredient poulet2 = new Ingredient("herbe_plante", "graines de moutarde concassées", 5, DateTime.Today);
            Ingredient poulet3 = new Ingredient("legume", "flocont de piment fort", 3, DateTime.Today);
            Ingredient poulet4 = new Ingredient("volaille", " demi-poitrines de poulet dérossé et sans peau", 4, DateTime.Today);
            Ingredient poulet5 = new Ingredient("matiere_grasse", "huile d'Olive", 30, DateTime.Today);
            Ingredient poulet6 = new Ingredient("matiere_grasse", "bouillon de poulet", 180, DateTime.Today);
            Ingredient poulet7 = new Ingredient("feculent", "grains de mais surgelés", 225, DateTime.Today);
            Ingredient poulet8 = new Ingredient("legume", "tomates cerises coupées en deux", 210, DateTime.Today);
            Ingredient poulet9 = new Ingredient("legume", "Oignons verts", 4, DateTime.Today);
            Ingredient poulet10 = new Ingredient("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredient> recipepoulet = new List<Ingredient> { poulet1, poulet2, poulet3, poulet4, poulet5, poulet6, poulet7, poulet8, poulet9, poulet10 };
            _Allrecipe.AddHealthyrecipe("Casserole de poulet au mais, aux petits pois et aux tomates succotash", recipepoulet, "1 Dans un petit bol, mélanger la coriandre, la moutarde et le piment. Sur une assiette, frotter le poulet avec le melange d epices. Saler et poivrer. 2 Dans une grande poele antiadhesive à feu élevé, dorer le poulet  dans l huile environ 2 minutes de chaque coté.Ajouter le bouillon et les légumes. Porter à ébullition et couvrir.Laisser mijoter environ 8 minutes ou jusqu’à ce que le poulet soit bien cuit. Rectifier l assaisonnement");
            #endregion
            #region Trempette aux poivrons rouges rotis  et aux tomates séchées

            Ingredient trempette1 = new Ingredient("fruit", "noix de grenoble", 25, DateTime.Today);
            Ingredient trempette2 = new Ingredient("legume", "tomates séchées", 60, DateTime.Today);
            Ingredient trempette3 = new Ingredient("herbe_plante", "ail séchée", 1, DateTime.Today);
            Ingredient trempette4 = new Ingredient("fruit", "jus de citron", 15, DateTime.Today);
            Ingredient trempette5 = new Ingredient("legume", "poivrons rouges", 2, DateTime.Today);
            Ingredient trempette6 = new Ingredient("legume", "épepinées", 20, DateTime.Today);
            Ingredient trempette7 = new Ingredient("legume", "sel et poivre", 10, DateTime.Today);
            List<Ingredient> recipetrempette = new List<Ingredient> { trempette1, trempette2, trempette3, trempette4, trempette5, trempette6, trempette7 };
            _Allrecipe.AddHealthyrecipe(" Tremepette aux poivrons rouges rotis et aux tomates séchées", recipetrempette, "1 Au robot culinaire, hacher les noix, les tomates et l’ail avec le jus de citron.2 Ajouter les poivrons et mélanger quelques secondes à la fois jusqu’à ce que les poivrons soient presque réduits en purée. Saler et poivrer.3 Servir avec des tranches de baguette grillée, des crudités, ou les deux.");
            #endregion
            #region Trempette aux haricots  et aux artichaux

            Ingredient trempetteharicot1 = new Ingredient("feculent", "haricots blancs", 549, DateTime.Today);
            Ingredient trempetteharicot2 = new Ingredient("herbe_plante", "artichauts", 170, DateTime.Today);
            Ingredient trempetteharicot3 = new Ingredient("matiere_grasse", "huile d'olive", 30, DateTime.Today);
            Ingredient trempetteharicot4 = new Ingredient("fruit", "jus de citron", 15, DateTime.Today);
            Ingredient trempetteharicot5 = new Ingredient("herbe_plante", "ail", 1, DateTime.Today);
            Ingredient trempetteharicot6 = new Ingredient("legume", "sel et poivre", 10, DateTime.Today);
            List<Ingredient> recipetrempetteharicot = new List<Ingredient> { trempetteharicot1, trempetteharicot2, trempetteharicot3, trempetteharicot4, trempetteharicot5, trempetteharicot6 };
            _Allrecipe.AddHealthyrecipe(" Trempette aux haricots et aux artichaux", recipetrempetteharicot, "1 Au robot culinaire, broyer tous les ingredients jusqu'à l'obtention  d'une purée lisse. Saler et poivrer. 2 Servir avec des chips de pita, des crudités, ou les deux");
            #endregion

            #region  Risotto aux crevettes de type chowder

            Ingredient risotto1 = new Ingredient("matiere_grasse", "bouillon de poulet", 750, DateTime.Today);
            Ingredient risotto2 = new Ingredient("boisson", "lait", 750, DateTime.Today);
            Ingredient risotto3 = new Ingredient("legume", "carottes", 2, DateTime.Today);
            Ingredient risotto4 = new Ingredient("herbe_plante", "céleri", 2, DateTime.Today);
            Ingredient risotto5 = new Ingredient("legume", "oignon", 1, DateTime.Today);
            Ingredient risotto6 = new Ingredient("matiere_grasse", "huile d'olive", 30, DateTime.Today);
            Ingredient risotto7 = new Ingredient("feculent", "riz arborio", 400, DateTime.Today);
            Ingredient risotto8 = new Ingredient("boisson", "vin blanc", 125, DateTime.Today);
            Ingredient risotto9 = new Ingredient("crustace", "crevettes crues", 454, DateTime.Today);
            Ingredient risotto10 = new Ingredient("herbe_plante", "grains de mais surgelés", 150, DateTime.Today);
            Ingredient risotto11 = new Ingredient("herbe_plante", "persil frais", 30, DateTime.Today);
            Ingredient risotto12 = new Ingredient("fruit", "pincée de muscade", 1, DateTime.Today);
            Ingredient risotto13 = new Ingredient("legume", "sel et poivre", 10, DateTime.Today);
            List<Ingredient> reciperisotto = new List<Ingredient> { risotto1, risotto2, risotto3, risotto4, risotto5, risotto6, risotto7, risotto8, risotto9, risotto10, risotto11, risotto12, risotto13 };
            _Allrecipe.AddHealthyrecipe("Risotto aux crevettes de type chowder", reciperisotto, "Dans une casserole à feu élevé, porter à ébullition  le bouillon et le lait.Dès le premier bouillon, fermer le feu. Couvrir  et réserver au chaud. 2 Dans  une grande casserole à feu moyen, attendrir les carottes, le céleri et l'oignon dans l huile. 3 Ajouter le riz et cuire 1 minute  en remuant pour bien  l enrober. Déglacer avec le vin et laisser  réduire presque a sec. 4 À feu moyen, ajouter le mélange de bouillon, environ 250 ml (1 tasse) à la fois, en remuant fréquemment jusqu’à ce qu’il soit complètement absorbé entre chaque ajout. Saler et poivrer. Cuire de 18 à 22 minutes ou jusqu’à ce que le riz soit al dente. Incorporer les crevettes, le maïs, le persil et la muscade. Poursuivre la cuisson environ 2 minutes ou jusqu’à ce que les crevettes soient cuites. ");
            #endregion

            #region Nouille de chou aux cari et sauté de boeuf

            Ingredient nouille1 = new Ingredient("herbe_plante", "gousse d'ail", 4, DateTime.Today);
            Ingredient nouille2 = new Ingredient("matiere_grasse", "huile d'olive", 15, DateTime.Today);
            Ingredient nouille3 = new Ingredient("legume", "chou vert", 680, DateTime.Today);
            Ingredient nouille4 = new Ingredient("herbe_plante", "poudre de cari", 10, DateTime.Today);
            Ingredient nouille5 = new Ingredient("viande", "sauté de boeuf", 10, DateTime.Today);
            Ingredient nouille6 = new Ingredient("feculent", "fecule de mais", 10, DateTime.Today);
            Ingredient nouille7 = new Ingredient("boisson", "eau", 60, DateTime.Today);
            Ingredient nouille8 = new Ingredient("herbe_plante", "sauce de soja", 30, DateTime.Today);
            Ingredient nouille9 = new Ingredient("dessert_sucrerie", "miel", 30, DateTime.Today);
            Ingredient nouille10 = new Ingredient("herbe_plante", "poudre de cari", 10, DateTime.Today);
            Ingredient nouille11 = new Ingredient("viande", "boeuf haché", 454, DateTime.Today);
            Ingredient nouille12 = new Ingredient("herbe_plante", "oignon", 1, DateTime.Today);
            Ingredient nouille13 = new Ingredient("matiere_grasse", "huile d'olive", 15, DateTime.Today);
            Ingredient nouille14 = new Ingredient("legume", "poivrons de couleur", 2, DateTime.Today);
            Ingredient nouille15 = new Ingredient("legume", "épépinés", 1, DateTime.Today);
            Ingredient nouille16 = new Ingredient("herbe_plante", "aneth frais", 30, DateTime.Today);
            List<Ingredient> recipenouille = new List<Ingredient> { nouille1, nouille2, nouille3, nouille4, nouille5, nouille6, nouille7, nouille8, nouille9, nouille10, nouille11, nouille12, nouille13, nouille14, nouille15, nouille16 };
            _Allrecipe.AddHealthyrecipe("Nouille de chou aux cari et sauté de boeuf", recipenouille, "1 Dans une grande poêle à feu moyen‐élevé, dorer l’ail dans l’huile. Ajouter le chou et le cari. Poursuivre la cuisson environ 8 minutes en remuant fréquemment ou jusqu’à ce que le chou soit al dente. Réserver au chaud. 2 Dans un bol, délayer la fécule dans l’eau. Ajouter la sauce soya, le miel et le cari. Réserver la sauce. 3 Dans une autre grande poêle à feu élevé, dorer le boeuf et l’oignon dans l’huile. Ajouter les poivrons et poursuivre la cuisson jusqu’à ce qu’ils soient tendres. Ajouter la sauce et porter à ébullition en remuant fréquemment. 3 Dans 4 bols, repartir les nouilles de chou. Garnir du saute de boeuf et parsemer d aneth ");
            #endregion
            #region Riz aux lentilles  et aux choux  de Bruxelles:

            Ingredient lentilles1 = new Ingredient("herbe_plante", "oignon", 1, DateTime.Today);
            Ingredient lentilles2 = new Ingredient("herbe_plante", "céleri", 1, DateTime.Today);
            Ingredient lentilles3 = new Ingredient("herbe_plante", "gousse d'ail", 2, DateTime.Today);
            Ingredient lentilles4 = new Ingredient("matiere_grasse", "huile d'olive", 60, DateTime.Today);
            Ingredient lentilles5 = new Ingredient("fruit", "lentilles du Puy", 215, DateTime.Today);
            Ingredient lentilles6 = new Ingredient("herbe_plante", "bouillon de poulet", 500, DateTime.Today);
            Ingredient lentilles7 = new Ingredient("legume", "coulis de tomates", 375, DateTime.Today);
            Ingredient lentilles8 = new Ingredient("herbe_plante", "origan", 5, DateTime.Today);
            Ingredient lentilles9 = new Ingredient("herbe_plante", "moutarde", 5, DateTime.Today);
            Ingredient lentilles10 = new Ingredient("herbe_céleri", "céleri", 5, DateTime.Today);
            Ingredient lentilles11 = new Ingredient("herbe_plante", "céleri", 3, DateTime.Today);
            Ingredient lentilles12 = new Ingredient("legume", "pincée de poivre", 1, DateTime.Today);
            Ingredient lentilles13 = new Ingredient("feculent", "riz", 125, DateTime.Today);
            Ingredient lentilles14 = new Ingredient("herbe_plante", "persil frais", 10, DateTime.Today);
            Ingredient lentilles15 = new Ingredient("legume", "feuilles de choux", 675, DateTime.Today);
            Ingredient lentilles16 = new Ingredient("legume", "Sel et poivre", 30, DateTime.Today);
            List<Ingredient> recipelentilles = new List<Ingredient> { lentilles1, lentilles2, lentilles3, lentilles4, lentilles4, lentilles5, lentilles6, lentilles7, lentilles8, lentilles9, lentilles10, lentilles11, lentilles12, lentilles13, lentilles14, lentilles15, lentilles16 };
            _Allrecipe.AddHealthyrecipe(" Riz aux lentilles et aux choux de Bruxelles", recipelentilles, "1 Dans une grande poêle à feu moyen‐élevé, dorer l’oignon, le céleri et l’ail dans la moitié de l’huile (30 ml/2 c. à soupe). Ajouter les lentilles, le bouillon, le coulis de tomates et les épices. Saler, poivrer et porter à ébullition. Couvrir. Laisser mijoter 10 minutes. Incorporer le riz, couvrir à nouveau et laisser mijoter 20 minutes jusqu’à ce que le riz soit tendre mais encore légèrement croquant. Laisser reposer 5 minutes à découvert. Ajouter le persil. 2 Placer deux grilles au centre du four. Préchauffer le four à 200 °C (400 °F). Tapisser deux plaques de cuisson de papier parchemin. 3 Répartir les feuilles des choux de Bruxelles sur les plaques. Arroser du reste de l’huile (30 ml/2 c. à soupe). Saler et poivrer. Cuire les deux plaques au four de 12 à 15 minutes ou jusqu’à ce que les feuilles soient légèrement dorées. 4. Au moment de servir, déposer les feuilles de chou de Bruxelles rôties sur le dessus du mélange de riz et de lentilles. ");
            #endregion

            #region Tajine de légumes

            Ingredient tajine1 = new Ingredient("legume", "courgettes", 4, DateTime.Today);
            Ingredient tajine2 = new Ingredient("herbe_plante", "carottes", 5, DateTime.Today);
            Ingredient tajine3 = new Ingredient("poivrons", "poivron rouge", 1, DateTime.Today);
            Ingredient tajine4 = new Ingredient("poivrons", "poivron vert", 1, DateTime.Today);
            Ingredient tajine5 = new Ingredient("herbe_plante", "oignon", 1, DateTime.Today);
            Ingredient tajine6 = new Ingredient("legume", "boite de tomates concassées", 1, DateTime.Today);
            Ingredient tajine7 = new Ingredient("legume", "tomates séchées", 3, DateTime.Today);
            Ingredient tajine8 = new Ingredient("matiere_grasse", "huile d'olive", 30, DateTime.Today);
            Ingredient tajine9 = new Ingredient("legume", "sel et poivre", 30, DateTime.Today);
            Ingredient tajine10 = new Ingredient("herbe_plante", "ras el hanout", 20, DateTime.Today);
            Ingredient tajine11 = new Ingredient("herbe_plante", "Cannelle", 20, DateTime.Today);
            List<Ingredient> recipetajine = new List<Ingredient> { tajine1, tajine2, tajine3, tajine4, tajine5, tajine6, tajine7, tajine8, tajine9, tajine10, tajine11 };
            _Allrecipe.AddHealthyrecipe("Tajine de légumes", recipetajine, "Eplucher l'oignon, l'émincer et le faire dorer dans une cocotte avec un peu d'huile d'olive. Eplucher les courgettes, les carottes, les couper en rondelles; couper les poivrons en lanières. Ajouter les légumes dans la cocotte, verser la boîte de tomates concassées, découper les tomates séchées en petits morceaux, les ajouter; saler et poivrer. Ajouter une bonne cuillère à café de Ras el Hanout, et une demi cuillère à café de cannelle. Couvrir et laisser mijoter à feu très doux pendant 45 min, les légumes doivent être fondants. Servir avec de la semoule.");

            #endregion

            #region Filet de poulet à la crème de poivron facile

            Ingredient filet1 = new Ingredient("volaille", "filets de poulet", 6, DateTime.Today);
            Ingredient filet2 = new Ingredient("poivrons", "poivrons rouges", 2, DateTime.Today);
            Ingredient filet3 = new Ingredient("produit_laitier", "crème liquide", 20, DateTime.Today);
            Ingredient filet4 = new Ingredient("produit_laitier", "crème epaisse", 5, DateTime.Today);
            Ingredient filet5 = new Ingredient("produit_laitier", "beurre", 10, DateTime.Today);
            Ingredient filet6 = new Ingredient("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredient> recipefilet = new List<Ingredient> { filet1, filet2, filet3, filet4, filet5, filet6 };
            _Allrecipe.AddHealthyrecipe("Filet de poulet à la crème de poivron facile", recipefilet, "Découper les filets de poulet en petites lamelles (environ 3cm x 1cm). Les mettre dans une sauteuse dans laquelle le beurre a doucement fondu. Pendant qu'il 'bronze', couper en tous petits dés le poivron (bien enlever les parties blanches).Rajouter le poivron au poulet et les laisser faire connaissance jusqu'à ce que le poulet rosisse! A ce moment là, rajouter la crème liquide, le sel et le poivre, remuer pour bien tout mélanger et laisser cuire TRES doucement environ 20 minutes. Juste avant de servir, rajouter, pour lier la sauce, 2 ou 3 cuillères à soupe de crème fraîche épaisse. On peut le servir simplement avec du riz sauvage... et attendre les compliments (version light avec crème allégée à 15 % et toujours aussi bon!). ");

            #endregion

            #region  Sauce Bolognaise

            Ingredient sauce1 = new Ingredient("produit_laitier", "beurre", 30, DateTime.Today);
            Ingredient sauce2 = new Ingredient("matiere_grasse", "huile d'olive", 5, DateTime.Today);
            Ingredient sauce3 = new Ingredient("legume", "coulis de tomate", 30, DateTime.Today);
            Ingredient sauce4 = new Ingredient("viande", "viande hachée", 200, DateTime.Today);
            Ingredient sauce5 = new Ingredient("herbe_plante", "ail", 1, DateTime.Today);
            Ingredient sauce6 = new Ingredient("herbe_plante", "oignon", 1, DateTime.Today);
            Ingredient sauce7 = new Ingredient("legume", "sel et poivre", 30, DateTime.Today);
            List<Ingredient> recipesauce = new List<Ingredient> { sauce1, sauce2, sauce3, sauce4, sauce5, sauce6, sauce7 };
            _Allrecipe.AddHealthyrecipe("Sauce Bolognaise", recipesauce, "Dans une grande casserole, faites revenir l'ail et l'oignon dans l'huile d'olive. Ajouter progressivement la viande hachée....Salez, poivrez. Ajouter ensuite le coulis de tomate. Si la sauce semble trop épaisse, ajouter un 1/2 verre d'eau.... Laisser mijoter à feu doux durant 10 minutes. En fin de cuisson, faites fondre le beurre dans la sauce...");
            #endregion

            #region Cakes aux olives et au jambon

            Ingredient cakes1 = new Ingredient("boisson", "vin blanc sec", 15, DateTime.Today);
            Ingredient cakes2 = new Ingredient("matiere_grasse", "huile d'olive", 15, DateTime.Today);
            Ingredient cakes3 = new Ingredient("volaille", "oeufs", 4, DateTime.Today);
            Ingredient cakes4 = new Ingredient("produit_laitier", "gruyère rapé", 100, DateTime.Today);
            Ingredient cakes5 = new Ingredient("herbe_plante", "farine", 250, DateTime.Today);
            Ingredient cakes6 = new Ingredient("produit_laitier", "levure", 1, DateTime.Today);
            Ingredient cakes7 = new Ingredient("legume", "sel", 1, DateTime.Today);
            Ingredient cakes8 = new Ingredient("viande", "jambon en dés", 200, DateTime.Today);
            Ingredient cakes9 = new Ingredient("fruit", "olives vertes", 200, DateTime.Today);
            List<Ingredient> recipecake = new List<Ingredient> { cakes1, cakes2, cakes3, cakes4, cakes5, cakes6, cakes7, cakes8, cakes9 };
            _Allrecipe.AddHealthyrecipe("Cakes aux olives et au jambon", recipecake, " Dans un saladier, travaillez le vin, l'huile et les oeufs cassés un par un. Ajoutez la farine, le gruyère râpé, la farine, la levure, le sel et terminez par le jambon (en dés) et les olives coupées en 2. Faites cuire dans un moule à cake beurré et fariné pendant 45 min, à 190°C (thermostat 6/7).");
            #endregion

            #region Cookies simple et  delicieux 

            Ingredient cookie1 = new Ingredient("herbe_plante", "farine", 220, DateTime.Today);
            Ingredient cookie2 = new Ingredient("produit_laitier", "beurre mou", 100, DateTime.Today);
            Ingredient cookie3 = new Ingredient("dessert_sucrerie", "sucre blanc", 100, DateTime.Today);
            Ingredient cookie4 = new Ingredient("dessert_sucrerie", "cassonade", 100, DateTime.Today);
            Ingredient cookie5 = new Ingredient("dessert_sucrerie", "chocolat de patissier", 100, DateTime.Today);
            Ingredient cookie6 = new Ingredient("volaille", "oeuf", 1, DateTime.Today);
            Ingredient cookie7 = new Ingredient("herbe_plante", "bicarbonate alimentaire", 1, DateTime.Today);
            Ingredient cookie8 = new Ingredient("legume", "pincé de sel", 10, DateTime.Today);
            List<Ingredient> recipecookie = new List<Ingredient> { cookie1, cookie2, cookie3, cookie4, cookie5, cookie6, cookie7, cookie8 };
            _Allrecipe.AddHealthyrecipe("Cookies simple et delicieux", recipecookie, "Hacher le chocolat grossièrement, et mélanger le beurre mou avec les deux sucres et l'oeuf.Ajouter la farine, le bicarbonate, le sel et enfin le chocolat.Travailler la pâte à la main.Faire des boules, et les disposer sur une plaque recouverte de papier sulfurisé. Enfourner une quinzaine de minutes dans le four préchauffé à 180°C (thermostat 6).");

            #endregion

            #region Endives au jambon
            Ingredient endives1 = new Ingredient("herbe_plante", "chicons", 4, DateTime.Today);
            Ingredient endives2 = new Ingredient("viande", "jambon", 4, DateTime.Today);
            Ingredient endives3 = new Ingredient("herbe_plante", "farine", 40, DateTime.Today);
            Ingredient endives4 = new Ingredient("produit_laitier", "beurre", 40, DateTime.Today);
            Ingredient endives5 = new Ingredient("boisson", "lait", 60, DateTime.Today);
            Ingredient endives6 = new Ingredient("legume", "sel et poivre", 20, DateTime.Today);
            Ingredient endives7 = new Ingredient("fruit", "mouscade", 1, DateTime.Today);
            List<Ingredient> recipeendives = new List<Ingredient> { endives1, endives2, endives3, endives4, endives5, endives6, endives7 };
            _Allrecipe.AddHealthyrecipe("Endives au jambon", recipeendives, "Préparez une grande quantité de sauce béchamel. N'hésitez pas sur le noix de muscade en assaisonnant. Enroulez chaque chicon dans une tranche de jambon et disposez-les dans le plat. Prévoyez 2 chicons par personne. Remplissez le plat avec la sauce. Saupoudrez de gruyère râpé. Hop au four 180°C pendant 45 min. Servez avec une purée maison éventuellement gratinée elle aussi.");

            #endregion

            #region Boeuf Bourguignon
            Ingredient bourguignon1 = new Ingredient("viande", "boeuf", 800, DateTime.Today);
            Ingredient bourguignon2 = new Ingredient("viande", "lardons", 100, DateTime.Today);
            Ingredient bourguignon3 = new Ingredient("produit_laitier", "beurre", 50, DateTime.Today);
            Ingredient bourguignon4 = new Ingredient("boisson", "vin rouge", 70, DateTime.Today);
            Ingredient bourguignon5 = new Ingredient("herbe_plante", "oignons", 2, DateTime.Today);
            Ingredient bourguignon6 = new Ingredient("herbe_plante", "ail", 1, DateTime.Today);
            Ingredient bourguignon7 = new Ingredient("herbe_plante", "farine", 5, DateTime.Today);
            Ingredient bourguignon8 = new Ingredient("herbe_plante", "bouquet garni", 1, DateTime.Today);
            Ingredient bourguignon9 = new Ingredient("legume", "sel et poivre", 20, DateTime.Today);
            Ingredient bourguignon10 = new Ingredient("herbe_plante", "champignons de Paris", 250, DateTime.Today);
            List<Ingredient> recipebourguignon = new List<Ingredient> { bourguignon1, bourguignon2, bourguignon3, bourguignon4, bourguignon5, bourguignon6, bourguignon7, bourguignon8, bourguignon9, bourguignon10 };
            _Allrecipe.AddHealthyrecipe("Boeuf Bourguignon", recipebourguignon, "Dans une cocotte minute, faire roussir la viande et les lardons dans l’huile ou le beurre. Ajouter les oignons coupés en petits morceaux. Ajouter la boîte de champignons. Saupoudrer de farine. Mélanger. Laisser dorer un instant. Mouiller avec le vin rouge qui doit recouvrir la viande. Saler et poivrer. Ajouter l’ail et le bouquet garni. Fermer la cocotte minute. Laisser cuire doucement 60 mn à partir de la mise en rotation de la soupape.");

            #endregion

            #region Salade Melon, feta, jambon

            Ingredient salademel1 = new Ingredient("legume", "coeur de salade", 1, DateTime.Today);
            Ingredient salademel2 = new Ingredient("legume", "melon", 1, DateTime.Today);
            Ingredient salademel3 = new Ingredient("produit_laitier", "feta", 200, DateTime.Today);
            Ingredient salademel4 = new Ingredient("viande", "jambon", 4, DateTime.Today);
            Ingredient salademel5 = new Ingredient("fruit", "jus de citron", 4, DateTime.Today);
            Ingredient salademel6 = new Ingredient("matiere_grasse", "huile d'olive ", 4, DateTime.Today);
            Ingredient salademel7 = new Ingredient("boisson", "café de thym ", 1, DateTime.Today);
            Ingredient salademel8 = new Ingredient("legume", "sel et poivre ", 20, DateTime.Today);
            Ingredient salademel9 = new Ingredient("boisson", "eau ", 2, DateTime.Today);
            List<Ingredient> recipesalademelon = new List<Ingredient> { salademel1, salademel2, salademel3, salademel4, salademel5, salademel6, salademel7, salademel8, salademel9 };
            _Allrecipe.AddHealthyrecipe("Salade Melon, feta, jambon", recipesalademelon, "Eplucher le melon, et couper la chair en petits cubes. Couper les tranches de jambon cru en fines lanières. Couper la feta en cubes.Pour la sauce : verser le jus de citron dans un bol, saler, poivrer (allonger d'eau si désiré); bien mélanger. Ajouter l'huile d'olive, mélanger énergiquement, afin d'obtenir une belle émulsion et incorporer le thym. Mettre la salade, le melon, le jambon, la feta et la sauce dans un saladier, et remuer juste avant de servir.");
            #endregion

            #region Salade au saumon fumé
            Ingredient saumon1 = new Ingredient("poisson", "tranches de saumon fumé", 4, DateTime.Today);
            Ingredient saumon2 = new Ingredient("herbe_plante", "concombre", 1, DateTime.Today);
            Ingredient saumon3 = new Ingredient("legume", "salade", 200, DateTime.Today);
            Ingredient saumon4 = new Ingredient("produit_laitier", "feta", 100, DateTime.Today);
            
            Ingredient saumon5 = new Ingredient("fruit", "jus de citron", 1, DateTime.Today);
            Ingredient saumon6 = new Ingredient("legume", "sel et poivre", 20, DateTime.Today);
            Ingredient saumon7 = new Ingredient("herbe_plante", "cornichons aigres doux", 4, DateTime.Today);
            Ingredient saumon8 = new Ingredient("herbe_plante", "echalote", 1, DateTime.Today);
            Ingredient saumon9 = new Ingredient("herbe_plante", "cornichons aigres doux", 4, DateTime.Today);
            Ingredient saumon10 = new Ingredient("matiere_grasse", "huile d'olive", 1, DateTime.Today);
            Ingredient saumon11 = new Ingredient("legume", "sel et poivre", 20, DateTime.Today);
            List<Ingredient> recipesaumon = new List<Ingredient> { saumon1, saumon2, saumon3, saumon4, saumon5, saumon6, saumon7, saumon8, saumon9, saumon10, saumon11 };
            _Allrecipe.AddHealthyrecipe("Salade au saumon fumé", recipesaumon, "Préparer la sauce : émincer finement l'échalote et couper les cornichons en petits cubes. Dans un bol, mélanger le fromage blanc avec l'échalote, les cornichons Amora et l'huile d'olive. Assaisonner et réserver. Laver ensuite le demi-concombre et le détailler en rondelles.Couper les tranches de saumon fumé en lanières. Mélanger ensuite dans un saladier le saumon avec le concombre et la feta. Ajouter le jus de citron et assaisonner. Au moment de servir, déposer quelques feuilles de jeunes pousses Au moment de servir, déposer quelques feuilles de jeunes pousses dans des assiettes et ajouter le mélange au saumon fumé. Verser un peu de sauce blanche et déguster.  ");
            #endregion
            #region Entrecotes moutardées
            Ingredient entrecote1 = new Ingredient("viande", "pièces d'entrecotes", 1200, DateTime.Today);
            Ingredient entrecote2 = new Ingredient("matiere_grasse", "huile", 2, DateTime.Today);
            Ingredient entrecote3 = new Ingredient("herbe_plante", "moutarde", 3, DateTime.Today);
            Ingredient entrecote4 = new Ingredient("boisson", "Cognac", 3, DateTime.Today);
            Ingredient entrecote5 = new Ingredient("matiere_grasse", "soupe de crème", 9, DateTime.Today);
            Ingredient entrecote6 = new Ingredient("legume", "sel et poivre", 20, DateTime.Today);
            List<Ingredient> recipeentrecote = new List<Ingredient> { entrecote1, entrecote2, entrecote3, entrecote4, entrecote5, entrecote6 };
            _Allrecipe.AddHealthyrecipe("Entrecotes moutardées", recipeentrecote, "Enduire chaque entrecôte d'huile puis d'1 cuillère à soupe de moutarde. Laisser reposer 30 minutes. Graisser une poêle et saisir la viande à feu vif. Faire cuire 2-3 minutes de chaque côté pour une viande bleue, 4-5 minutes pour une viande saignante, plus longtemps pour une viande à point.Retirer la viande de la poêle. Saler, poivrer et réserver au chaud. Mettre la moutarde restante dans la poêle avec la moitié de la crème. Gratter le fond de la poêle pour décoller les sucs de cuisson de la viande puis réduire de moitié sur feu vif. Verser le cognac et la crème. Retirer du feu dès que la sauce atteint l'ébullition. Rectifier l'assaisonnement et verser sur l'entrecôte.");
            #endregion

            #region Sauté de Veau au Chorizo
            Ingredient saute1 = new Ingredient("viande", "sauté de veau", 1000, DateTime.Today);
            Ingredient saute2 = new Ingredient("viande", "chorizo", 1, DateTime.Today);
            Ingredient saute3 = new Ingredient("legume", "pulpe de tomate", 2, DateTime.Today);
            Ingredient saute4 = new Ingredient("fruit", "olives vertes", 1, DateTime.Today);
            Ingredient saute5 = new Ingredient("herbe_plante", "oignons", 4, DateTime.Today);
            Ingredient saute6 = new Ingredient("herbe_plante", "bouquet de basilic", 1, DateTime.Today);
            Ingredient saute7 = new Ingredient("herbe_plante", "bouquet garni", 1, DateTime.Today);
            Ingredient saute8 = new Ingredient("herbe_plante", "gousse d'ail", 1, DateTime.Today);
            List<Ingredient> recipesaute = new List<Ingredient> { saute1, saute2, saute3, saute4, saute5, saute6, saute7, saute8 };
            _Allrecipe.AddHealthyrecipe("Sauté de Veau", recipesaute, "Faire revenir veau et oignons émincés jusqu'à coloration. Ajouter le chorizo en rondelles (oter sa peau), puis la pulpe de tomate, le basilic haché et enfin les olives. Couvrir et faire mijoter à feux doux 1 heure minimum. Ce plat est encore meilleur préparé la veille et réchauffé le jour même.");
            #endregion

            #region Gigot d'Agneau aux pommes boulangères
            Ingredient gigot1 = new Ingredient("viande", "gigot d'agneau", 2, DateTime.Today);
            Ingredient gigot2 = new Ingredient("herbe_plante", "pomme de terre", 8, DateTime.Today);
            Ingredient gigot3 = new Ingredient("herbe_plante", "gousses d'ail", 2, DateTime.Today);
            Ingredient gigot4 = new Ingredient("herbe_plante", "brin de thym", 10, DateTime.Today);
            Ingredient gigot5 = new Ingredient("produit_laitier", "copeaux de beurre", 100, DateTime.Today);
            Ingredient gigot6 = new Ingredient("legume", "sel et poivre", 20, DateTime.Today);
            List<Ingredient> recipegigot = new List<Ingredient> { gigot1, gigot2, gigot3, gigot4, gigot5, gigot6 };
            _Allrecipe.AddHealthyrecipe("Gigot d'Agneau aux pommes boulangères", recipegigot, "Préchauffer le four à thermostat 7 (210°C).Peler, laver, sécher et tailler les pommes de terre en rondelles à l’aide d’une râpe. Les poser en couches égales dans le fond du plat et parsemer avec les copeaux de beurre. Déposer le gigot et enfourner. Après 15 min, lorsque le gigot commence à dorer, le retourner. Laisser cuire encore 15 min et le retourner à nouveau. Baisser le thermostat à 6 (180°C) et laisser la cuisson se poursuivre 40 min. Ajouter les gousses d'ail en chemise durant les 30 dernières minutes de cuisson. Eteindre et laisser reposer dans le four pendant 10 min. Le gigot sera moelleux et les pommes de terre imprégnées d’un délicieux goût d’agneau.");

            #endregion

            #region Pommes de terre boulangères
            Ingredient pomme1 = new Ingredient("herbe_plante", "pommes de terre", 1000, DateTime.Today);
            Ingredient pomme2 = new Ingredient("herbe_plante", "oignons", 4, DateTime.Today);
            Ingredient pomme3 = new Ingredient("herbe_plante", "bouquet garni", 1, DateTime.Today);
            Ingredient pomme4 = new Ingredient("herbe_plante", "oignons", 4, DateTime.Today);
            Ingredient pomme5 = new Ingredient("matiere_grasse", "cube de bouillon", 1, DateTime.Today);
            Ingredient pomme6 = new Ingredient("produit_laitier", "beurre", 50, DateTime.Today);
            List<Ingredient> recipepomme = new List<Ingredient> { pomme1, pomme2, pomme3, pomme4, pomme6 };
            _Allrecipe.AddHealthyrecipe("Pommes de terre boulangère", recipepomme, "Peler les pommes de terre et les couper en rondelles assez fines et régulières. Peler les oignons et les émincer assez finement. Beurrer un moule à bord assez haut et disposer une couche de pommes de terre. Disposer par-dessus les oignons et finir par le reste de pommes de terre. Ajouter le bouquet garni ou, à défaut, parsemer simplement de thym ou d'herbes de Provence. Saler et poivrer. Ajouter le cube de bouillon dissout dans assez d'eau pour couvrir presque toutes les pommes de terre. Parsemer de noisettes de beurre et mettre au four environ 40 min à 220°C. ");
            #endregion







        }
    }
}
