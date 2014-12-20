﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_pressing_Loreau.Model
{
    class Bdd
    {
        #region attributs
        private static MySqlConnection MSConnexion;
        private static int ReturnCode = 0;
        #endregion

        #region Methodes
        public static MySqlConnection connexion()
        {
            try
            {

                if (MSConnexion == null)
                {
                    MSConnexion = new MySqlConnection("Server=localhost;Database=bddping1;Uid=root;Pwd=;");
                    MSConnexion.Open();
                }
                return MSConnexion;
            }
            catch (Exception Ex)
            {
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                return null;
            }

        }

        public static void deconnexion()
        {

            MSConnexion.Close();
            MSConnexion = null;
        }
        #endregion

        #region requetes
        /*
         * Liste de l'ensemble des requetes sql du logiciel
         * Triés par classes
         */

        //Département
        public static String insertDepartement = "INSERT INTO departement(dep_nom) VALUES (?)";
        public static String selectDepartements = "SELECT dep_id, dep_nom FROM departement";
        public static String selectDepartementById = "SELECT dep_id, dep_nom FROM departement WHERE id=?";

        //PlaceConvoyeur
        public static String insertConvoyeur = "INSERT INTO convoyeur(conv_emplacement) VALUES (?)";
        public static String selectConvoyeurs = "SELECT conv_id, conv_emplacement FROM convoyeur";
        public static String selectTypeById = "SELECT conv_id, conv_emplacement FROM convoyeur WHERE T.typ_id=?";

        //TypeArticle
        public static String insertType = "INSERT INTO type(typ_nom, typ_encombrement, typ_TVA, typ_HT, typ_dep_id) VALUES (?,?,?,?,?)";
        public static String selectTypes = "SELECT T.typ_id, T.type_nom, T.type_encombrement, T.type_TVA, T.type_HT, T.type_dep_id, D.dep_nom FROM type T, departement D WHERE T.type_dep_id=D.dep_id";
        public static String selectTypeByDepId = "SELECT T.typ_id, T.typ_nom, T.typ_encombrement, T.typ_TVA, T.typ_HT, T.typ_dep_id, D.dep_nom FROM type T, departement D WHERE T.typ_dep_id=D.dep_id AND D.dep_id=?";
        #endregion
    }
}
