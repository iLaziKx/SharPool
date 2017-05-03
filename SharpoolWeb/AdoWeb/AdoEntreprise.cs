using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;


namespace Webservice
{
    public class AdoEntreprise : Ado
    {
       
        public static List<Entreprise> readAll()
        {
            List<Entreprise> lesEntreprise = new List<Entreprise>();
            Open("Web");

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Entreprise";

            MySqlDataReader res = cmd.ExecuteReader();
            while (res.Read())
            {

                lesEntreprise.Add(new Entreprise((int)res["idEntreprise"], (string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["ville"], (string)res["codePostal"], (string)res["commentaire"], (bool)res["entrepriseCreer"]));
            }
            Close();
            return lesEntreprise;
           
        }
    }
}