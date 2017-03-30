﻿using SharPool.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SharPool.Ado
{
    class AdoContrat : Ado
    {
        public static void create(Contrat unContrat, string connect)
        {
            try
            {
                open(connect);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Contrat (dateDebut,dateFin,satisfaction,descriptionPoste,nomTuteur,numeroResponsable,mailTuteur,nomEleve,prenomEleve,archivage,typeContrat_idType,entreprise_idEntreprise,promotion_idPromotion) VALUES(@dateDebut,@dateFin,@satisfaction,@descriptionPoste,@nomTuteur,@numéroResponsable,@mailTuteur,@nomEleve,@prenomEleve,@archivage,@idType,@idEntreprise,@idPromotion)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@dateDebut", unContrat.DateDebut);
                cmd.Parameters.AddWithValue("@dateFin", unContrat.DateFin);
                cmd.Parameters.AddWithValue("@satisfaction", unContrat.Satisfaction);
                cmd.Parameters.AddWithValue("@descriptionPoste", unContrat.DescriptionPoste);
                cmd.Parameters.AddWithValue("@nomTuteur", unContrat.NomTuteur);
                cmd.Parameters.AddWithValue("@numéroResponsable", unContrat.NumeroResponsable);
                cmd.Parameters.AddWithValue("@mailTuteur", unContrat.MailTuteur);
                cmd.Parameters.AddWithValue("@nomEleve", unContrat.NomEleve);
                cmd.Parameters.AddWithValue("@prenomEleve", unContrat.PrenomEleve);
                cmd.Parameters.AddWithValue("@archivage", unContrat.Archivage);
                cmd.Parameters.AddWithValue("@idType", unContrat.IdType);
                cmd.Parameters.AddWithValue("@idEntreprise", unContrat.IdEntreprise);
                cmd.Parameters.AddWithValue("@idPromotion", unContrat.IdPromotion);


                cmd.ExecuteNonQuery();
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }
        public static Contrat readOne(int unId)
        {
            Contrat unContrat;
            open("App");

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Contrat WHERE id= " + unId;

            MySqlDataReader res = cmd.ExecuteReader();
            res.Read();
            unContrat = new Contrat((DateTime)res["dateDebut"], (DateTime)res["dateFin"], (int)res["satisfaction"], (string)res["descriptionPoste"], (string)res["nomTuteur"], (string)res["numeroResponsable"], (string)res["mailTuteur"], (string)res["nomEleve"], (string)res["prenomEleve"], (bool)res["archivage"], (int)res["idType"], (int)res["idEntreprise"], (int)res["idPromotion"]);

            close();
            return unContrat;

        }
        public static List<Contrat> readAll()
        {
            List<Contrat> lesContrats = new List<Contrat>();
            open("App");

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Contrat";

            MySqlDataReader res = cmd.ExecuteReader();
            while (res.Read())
            {
                res.Read();
                lesContrats.Add(new Contrat((DateTime)res["dateDebut"], (DateTime)res["dateFin"], (int)res["satisfaction"], (string)res["descriptionPoste"], (string)res["nomTuteur"], (string)res["numeroResponsable"], (string)res["mailTuteur"], (string)res["nomEleve"], (string)res["prenomEleve"], (bool)res["archivage"], (int)res["idType"], (int)res["idEntreprise"], (int)res["idPromotion"]));
            }

            return lesContrats;

        }

        public static List<Contrat> readAllWs(string connect)
        {
            List<Contrat> lesContrats = new List<Contrat>();
            open(connect);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Contrat WHERE archivage = 0";

            MySqlDataReader res = cmd.ExecuteReader();
            while (res.Read())
            {
                res.Read();
                lesContrats.Add(new Contrat((DateTime)res["dateDebut"], (DateTime)res["dateFin"], (int)res["satisfaction"], (string)res["descriptionPoste"], (string)res["nomTuteur"], (string)res["numeroResponsable"], (string)res["mailTuteur"], (string)res["nomEleve"], (string)res["prenomEleve"], (bool)res["archivage"], (int)res["idType"], (int)res["idEntreprise"], (int)res["idPromotion"]));
            }

            return lesContrats;

        }

        public static void delete(int unId)
        {
            try
            {
                open("App");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM Contrat WHERE id=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", unId);

                cmd.ExecuteNonQuery();
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public static void update(Contrat unContrat)
        {
            try
            {
                open("App");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Contrat SET dateDebut=@dateDebut,dateFin=@dateFin,satisfaction=@satisfaction,descriptionPoste=@descriptionPoste,nomTuteur=@nomTuteur,numéroResponsable=@numéroResponsable,mailTuteur=@mailTuteur,nomEleve=@nomEleve,prenomEleve=@prenomEleve,archivage=@archivage,idType=@idType,idEntreprise=@idEntreprise,idPromotion=@idPromotion WHERE idContrat=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", unContrat.IdContrat);
                cmd.Parameters.AddWithValue("@dateDebut", unContrat.DateDebut);
                cmd.Parameters.AddWithValue("@dateFin", unContrat.DateFin);
                cmd.Parameters.AddWithValue("@satisfaction", unContrat.Satisfaction);
                cmd.Parameters.AddWithValue("@descriptionPoste", unContrat.DescriptionPoste);
                cmd.Parameters.AddWithValue("@nomTuteur", unContrat.NomTuteur);
                cmd.Parameters.AddWithValue("@numéroResponsable", unContrat.NumeroResponsable);
                cmd.Parameters.AddWithValue("@mailTuteur", unContrat.MailTuteur);
                cmd.Parameters.AddWithValue("@nomEleve", unContrat.NomEleve);
                cmd.Parameters.AddWithValue("@prenomEleve", unContrat.PrenomEleve);
                cmd.Parameters.AddWithValue("@archivage", unContrat.Archivage);
                cmd.Parameters.AddWithValue("@idType", unContrat.IdType);
                cmd.Parameters.AddWithValue("@idEntreprise", unContrat.IdEntreprise);
                cmd.Parameters.AddWithValue("@idPromotion", unContrat.IdPromotion);

                cmd.ExecuteNonQuery();
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }

        }

        public static void update_createWs()
        {
            try
            {
                open("App");
                List<Contrat> lesContrats = readAllWs("App");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                foreach (Contrat unContrat in lesContrats)
                {
                    cmd.CommandText = "UPDATE Contrat SET archivage=@archivage WHERE idContrat=@id";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@archivage", 1);
                    cmd.Parameters.AddWithValue("@id", unContrat.IdContrat);
                    cmd.ExecuteNonQuery();
                }
                close();
                
                open("Web");
                foreach (Contrat unContrat in lesContrats)
                {
                    create(unContrat, "Web");
                }
                close(); 
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }

        }
    }
}
