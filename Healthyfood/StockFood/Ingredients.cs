using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    public class Ingredients
    {
        static DateTime _expiration_date;
        double _amount; // viande a ajouter ou retirer
        double _balance;
        public  enum _Category { viande, poisson, crustace, dessert_sucrerie, boisson, volaille, legume, fruit, produit_laitier, matiere_grasse, féculent_boulangerie, herbe_plante};
        public enum Viande { steak_de_boeuf, collier_de_boeuf, entrecote_de_boeuf, cote_de_boeuf, rumsteck_de_boeuf, filet_de_boeuf, jarret_de_boeuf, onglet_de_boeuf, flanchet_de_boeuf, poitrine_de_boeuf, bifteck_de_boeuf, collier_de_agneau, cote_de_agneau, filet_de_agneau, gigot_de_agneau, poitrine_de_agneau, epaule_de_agneau, collier_de_veau, cote_de_veau, filet_de_veau, poitrine_de_veau, epaule_de_veau, jarret_de_veau, flanchet_de_veau, tendron_de_veau, echine_de_porc, cote_de_porc, filet_de_porc, jambon_de_porc, jarret_de_porc, collier_de_cheval, cote_de_cheval, entrecote_de_cheval, filet_de_cheval, rumsteck_de_cheval, gite_de_cheval, merlan_de_cheval, tranche_de_cheval, jaret_de_cheval, araignee_de_cheval, onglet_de_cheval, };
        public enum Crustace { araignee_de_mer, cigale_de_mer, crabe, crevette_geante, crevette_grise, crevette_rose, ecrevisse, etrille, gambas, homard, langouste, langoustine, limule, tourteau, Coque, bucarde, rigadeau , rigadelle, sourdon, hénon, demoiselle, maillot, mourgue, pagne, berberechos, huitre, moule, palourde, clovisse, petoncle, mye, couteau_de_mer, vernis, poulpe, pieuvre, buccin, gros_buccin, bourgot, bulot, meduse };
        public enum Volaille {blanc_de_poulet, cuisses_de_poulet, pattes_de_poulet, pilons_de_poulet, ailes_de_poulet, gesier_de_poulet, foie_de_poulet, coeur_de_poulet, blanc_de_dinde, aiguillette_de_dinde, escalope_de_dinde, filet_de_dinde, supreme_de_dinde, aileron_de_dinde, manchon_de_dinde, cuisses_de_dinde, pilon_de_dinde, aiguillettes_de_canard, cuisses_de_canard, filet_de_canard, tournedos_de_canard, aiguillettes_de_pintade, cuisses_de_pintade, filet_de_pintade, tournedos_de_pintade}
        public static _Category _category;
        public enum _Poisson { anchois, anguille, brochet, cabillaud, colin, daurade_royale, flétan, loup_de_mer, merlan, omble_chevalier, perche, plie, raie, rascasse_du_nord, rouget_barbet, sandre, sardine, saumon, sole, thon};
        public enum _Boisson {lait, absinthe, allasch, amaro, amoroso, café, calvados, champagne, cognac, eau_de_vie, frambroise, irish_mist, prunelle, sirop, tequila, vin, vodka, whisky};
        public enum _Volaille { poules, dindes, canards, pintades};
        public enum _legume { agastache_de_corée, ail, ail_d_orient, ail_rocambol, amarante, aneth, angélique, asérine_bon_henri, arroche, artichaut, asperge_verte, asperge_blanche, balsamite, bambou, basilic, betteàcarte, betterave_rouge, bourrache_officinale, bourrache_orientale, calebasse, carottes, céleri, champignons, chou_frisé, chou_pommé, chou_rave, chou_de_bruxelles, chou_brocolli, chou_fleur, cresson, ciboule_commune, ciboulette, coeur_de_palmier, coriande, crambe, cresson_alénois, echalote, endive, epinard, estragon, fenouil_bulbeux, fenouil_doux_officinal, mache, mais_doux, melisse_turque, menthe, navets, oignon_rouge, oignon_blanc, oignon_jaune, origan, poireau, poirée, petit_pois, pimprenelle_petite, pois_asperge, pourpier, radiss_noir, soja, aubergine, concombre, cornichon, courgette, couge_de_siam, melon, pastèque, piment_fort, poivre_melon, tomate, poivrons };
        public enum _fruit { abricot, airelle, aki, alberge, amande, ananas, arbouse, aronia, avocat, banane, barbadine, bergamote, bigarade, boysenberry, brugnon, cabosse, cacahuète, calamondin, canneberge, carambole, casseille, cassis, cédrat, cériman, cerise, citron, citandrin, citrange, clémentine, datte, fraise, frambroise,  girembelle, goyave, grenade, grenadelle, merise, melon, pistache, pastèque, poire, pomme, raisin};
        public enum _Produit_Laitier { lait, yaourt, fromage, beurre, lait_de_vache, lait_cru, lait_pasteurisé, lait_stérilisé, lait_UHT, lait_concentré, lait_en_poudre, lait_demi_écrémé, lait_entier, lait_écrémé, crème, crème_glacée, kefir, viili, lait_au_bifidus, fromage_frais, fromage_fermier, fromage_affiné, fromage_fondu, caséine, babeur, lactosérum, milkshake }
        public enum _matiere_grasse { huile_et_margarine_de_tournesol, huile_de_palme, huile_d_olive, huiles_de_soja, huiles_vegetales };
        public Ingredients (_Category category, double balance, DateTime expiration_date)
        {
            _category = category;
            _balance = balance;
            _expiration_date = expiration_date;
        }

        public static _Category Category
        {
            get { return _category; }
        }
        


        public static DateTime Expiration_Date
        {
            get { return _expiration_date; }
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
