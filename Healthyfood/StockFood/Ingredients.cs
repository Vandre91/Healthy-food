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
        double _balance;
        public  enum _Category { viande, poisson, crustace, dessert_sucrerie, boisson, volaille, legume, fruit, produit_laitier, matiere_grasse, féculent_boulangerie, herbe_plante};
        public enum Viande { steak_de_boeuf, collier_de_boeuf, entrecote_de_boeuf, cote_de_boeuf, rumsteck_de_boeuf, filet_de_boeuf, jarret_de_boeuf, onglet_de_boeuf, flanchet_de_boeuf, poitrine_de_boeuf, bifteck_de_boeuf, collier_de_agneau, cote_de_agneau, filet_de_agneau, gigot_de_agneau, poitrine_de_agneau, epaule_de_agneau, collier_de_veau, cote_de_veau, filet_de_veau, poitrine_de_veau, epaule_de_veau, jarret_de_veau, flanchet_de_veau, tendron_de_veau, echine_de_porc, cote_de_porc, filet_de_porc, jambon_de_porc, jarret_de_porc, collier_de_cheval, cote_de_cheval, entrecote_de_cheval, filet_de_cheval, rumsteck_de_cheval, gite_de_cheval, merlan_de_cheval, tranche_de_cheval, jaret_de_cheval, araignee_de_cheval, onglet_de_cheval, };
        public enum Crustace { araignee_de_mer, cigale_de_mer, crabe, crevette_geante, crevette_grise, crevette_rose, ecrevisse, etrille, gambas, homard, langouste, langoustine, limule, tourteau, Coque, bucarde, rigadeau , rigadelle, sourdon, hénon, demoiselle, maillot, mourgue, pagne, berberechos, huitre, moule, palourde, clovisse, petoncle, mye, couteau_de_mer, vernis, poulpe, pieuvre, buccin, gros_buccin, bourgot, bulot, meduse };
        public enum Volaille {blanc_de_poulet, cuisses_de_poulet, pattes_de_poulet, pilons_de_poulet, ailes_de_poulet, gesier_de_poulet, foie_de_poulet, coeur_de_poulet, blanc_de_dinde, aiguillette_de_dinde, escalope_de_dinde, filet_de_dinde, supreme_de_dinde, aileron_de_dinde, manchon_de_dinde, cuisses_de_dinde, pilon_de_dinde, aiguillettes_de_canard, cuisses_de_canard, filet_de_canard, tournedos_de_canard, aiguillettes_de_pintade, cuisses_de_pintade, filet_de_pintade, tournedos_de_pintade}
        public static _Category _category;
        public enum _Poisson { anchois, anguille, brochet, cabillaud, colin, daurade_royale, flétan, loup_de_mer, merlan, omble_chevalier, perche, plie, raie, rascasse_du_nord, rouget_barbet, sandre, sardine, saumon, sole, thon};
        public enum _Boisson {lait, absinthe, allasch, amaro, amoroso, café, calvados, champagne, cognac, eau_de_vie, frambroise, irish_mist, prunelle, sirop, tequila, vin, vodka, whisky};
        public enum _legume { agastache_de_corée, ail, ail_d_orient, ail_rocambol, amarante, aneth, angélique, asérine_bon_henri, arroche, artichaut, asperge_verte, asperge_blanche, balsamite, bambou, basilic, betteàcarte, betterave_rouge, bourrache_officinale, bourrache_orientale, calebasse, carottes, céleri, champignons, chou_frisé, chou_pommé, chou_rave, chou_de_bruxelles, chou_brocolli, chou_fleur, cresson, ciboule_commune, ciboulette, coeur_de_palmier, coriande, crambe, cresson_alénois, echalote, endive, epinard, estragon, fenouil_bulbeux, fenouil_doux_officinal, mache, mais_doux, melisse_turque, menthe, navets, oignon_rouge, oignon_blanc, oignon_jaune, origan, poireau, poirée, petit_pois, pimprenelle_petite, pois_asperge, pourpier, radiss_noir, soja, aubergine, concombre, cornichon, courgette, couge_de_siam, melon, pastèque, piment_fort, poivre_melon, tomate, poivrons };
        public enum _fruit { abricot, airelle, aki, alberge, amande, ananas, arbouse, aronia, avocat, banane, barbadine, bergamote, bigarade, boysenberry, brugnon, cabosse, cacahuète, calamondin, canneberge, carambole, casseille, cassis, cédrat, cériman, cerise, citron, citandrin, citrange, clémentine, datte, fraise, frambroise,  girembelle, goyave, grenade, grenadelle, merise, melon, pistache, pastèque, poire, pomme, raisin};
        public enum _Produit_Laitier { lait, yaourt, fromage, beurre, lait_de_vache, lait_cru, lait_pasteurisé, lait_stérilisé, lait_UHT, lait_concentré, lait_en_poudre, lait_demi_écrémé, lait_entier, lait_écrémé, crème, crème_glacée, kefir, viili, lait_au_bifidus, fromage_frais, fromage_fermier, fromage_affiné, fromage_fondu, caséine, babeur, lactosérum, milkshake }
        public enum _matiere_grasse { huile_et_margarine_de_tournesol, huile_de_palme, huile_d_olive, huiles_de_soja, huiles_vegetales };
        public enum dessert_sucrerie { gâteau_stonehenge, american_apple_pie, tarte_aux_cérises, gâteau_au_yaourt, pomme_et_caramel, salade_de_fruits, pain_perdu, tarte_à_la_crème_de_marron_et_de_coco, tarte_aux_pommes_et_à_la_vergeoise, streusel_brownies, biscuits_de_la_joie, mimi_au_choco, gâteau_à_la_courge_de_nice, caramel_mou_au_beurre_salé, muffins_aux_pommes, baba_au_rhum, poire_au_rapudara, moelleux_au_chocolat, poires_au_vin, tarte_à_la_rhubarbe, mousse_crémeuse_chocolat_aubergine, charlotte_russe_aux_pommes, pommes_au_four, cake_au_citron_et_aux_graines_de_pavot, fondant_au_chocolat, salade_orientale_de_fraises_à_la_menthe, douceur_à_la_caroube, gâteau_au_carotte, makrouts, quatre_quart_caramélisé_aux_pommes, cheese_cake_aux_spéculoos, cookies_aux_deux_noix, alfajores_de_maicena, muffins_vegan_cacoo_noisette, cookies_noisettes, épeautre_et_chocolat, fraises_au_yaourt, madeleines_de_commercy, cake_poire_noisette_chocolat, muffins_au_chocolay_noir }
        public enum _Boulangerie { apéro_crunch, babelys, barbarines_aux_noix, bâtonnets_croustillants_vaudois, biscômes, biscuits_de_noel, bonbons_aux_fruits, brioche, croquettes, croquets, cuchaule, farine_à_la_meule, farine_bise, farine_complète, farine_fleur_bio, flûtes_aux_fromqges, flûtes_nature, lin_en_grains, pain, pain_breulottier, pain_jura_région, pain_au_chanvre, pain_campangnard_au_triticale, pain_de_seigle, pain_du_dézaley, pain_GRTA, pain_pavé, pain_paysan, pain_sâlois, pain_vadais, pain_vaudois, pain_au_levain, pâtes_au_blé_dur, petits_biscuits, pois_chiche, prunelle, quenus, quiche_vaudoise, sablés, sablée_au_fromage, spirales, tagliatelles, tailleule_neuchâteloise, taillés_aux_grebons, téotché, téotché_du_boulanger, téotché_vadais, tresse, tresse_aux_beurre, tresse_aux_lard, truffes_à_la_raisnée, truffes_aux_miels, croissant, pain_au_chocolat, croissant_beurre }
        public enum _Herbe_Plante { agave, ail_des_ours, arachide, bardane, basilic, bourrache, camomille, cerfeuil, ciboulette, consoude, conandre, estragon, guimauve, hysope, laurier_sauce, marjolaine, menthe, nepeta, persil, pourpier, raifort, romarin, sarriette, sauge, thym, verveine, archillée, ail, ajowan, amande_amère, angélique, anis, câpres, cardamonne, carmin, carvi, casse, graine_de_céléri, chili_ciboulette, cornichon, coniaque, cumin, oignon, ciboule, échalote, cresson_alénois, mélisse_officinale, faux_poivre, piment, muscade, soja, tamarin, monarde, moutarde, blanche, badiane, genièvre, armoise, ase_fétide, bigaradier, cédrat, an, eth, fenouil, feugrec, galanga, safran, sariette, rue, sésame }
        public enum _Féculent { fève, boulgour, coco_nain, flageolot, haricot_rouge, haricot_blanc, lentille, patate_douce, pore_de_terre_cochet, pois_cassé, polanta, pomme_de_terre, quinoa, riz, soisson, manioc }

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
