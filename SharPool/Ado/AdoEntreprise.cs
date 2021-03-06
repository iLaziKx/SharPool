﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SharPool.Classes;
using System.Data;

namespace SharPool.Ado
{
    class AdoEntreprise : Ado
        {
            public static void create(Entreprise uneEntreprise, string connect)
            {
                try
                {
                    open(connect);

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO entreprise (numeroSiret,nomEntreprise,adresse,codePostal,ville,commentaire,entrepriseCreer) VALUES (@numeroSiret,@nomEntreprise,@adresse,@codePostal,@ville,@commentaire,@entrepriseCreer)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@numeroSiret", uneEntreprise.NumeroSiret);
                    cmd.Parameters.AddWithValue("@nomEntreprise", uneEntreprise.NomEntreprise);
                    cmd.Parameters.AddWithValue("@adresse", uneEntreprise.Adresse);
                    cmd.Parameters.AddWithValue("@codePostal", uneEntreprise.CodePostal);
                    cmd.Parameters.AddWithValue("@ville", uneEntreprise.Ville);
                    cmd.Parameters.AddWithValue("@commentaire", uneEntreprise.Commentaire);
                    cmd.Parameters.AddWithValue("@entrepriseCreer", uneEntreprise.EntrepriseCreer);

                    cmd.ExecuteNonQuery();
                    close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());

                }
            }
            public static Entreprise readOne(int unId)
            {
                Entreprise uneEntreprise;
                open("App");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM entreprise WHERE idEntreprise= " + unId;

                MySqlDataReader res = cmd.ExecuteReader();
            
                res.Read();
                uneEntreprise = new Entreprise((int)res["idEntreprise"], (string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["codePostal"], (string)res["ville"], (string)res["commentaire"], (bool)res["entrepriseCreer"]);
            
                close();
                return uneEntreprise;

            }
            public static List<Entreprise> readAll()
            {
                List<Entreprise> lesEntreprise = new List<Entreprise>();
                open("App");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM entreprise";

                MySqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    
                    lesEntreprise.Add(new Entreprise((int)res["idEntreprise"], (string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["codePostal"], (string)res["ville"], (string)res["commentaire"], (bool)res["entrepriseCreer"]));
                }
                close();
                return lesEntreprise;

            }

        public static List<Entreprise> readAllWs()
        {
            List<Entreprise> lesEntreprises = new List<Entreprise>();
            open("App");

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM entreprise WHERE entrepriseCreer = 0";

            MySqlDataReader res = cmd.ExecuteReader();
            while (res.Read())
            {
                lesEntreprises.Add(new Entreprise((int)res["idEntreprise"], (string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["codePostal"], (string)res["ville"], (string)res["commentaire"], (bool)res["entrepriseCreer"]));
            }
            close();
            return lesEntreprises;

        }

        public static void delete(int unId)
            {
                try
                {
                    open("App");

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM entreprise WHERE idEntreprise=@id";
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

            public static void update(Entreprise uneEntreprise)
            {
                try
                {
                    open("App");

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE entreprise SET numeroSiret=@numeroSiret,nomEntreprise=@nomEntreprise,adresse=@adresse,codePostal=@codePostal,ville=@ville,commentaire=@commentaire WHERE idEntreprise=@idEntreprise";
                    cmd.Prepare();
                
                    cmd.Parameters.AddWithValue("@numeroSiret", uneEntreprise.NumeroSiret);
                    cmd.Parameters.AddWithValue("@nomEntreprise", uneEntreprise.NomEntreprise);
                    cmd.Parameters.AddWithValue("@adresse", uneEntreprise.Adresse);
                    cmd.Parameters.AddWithValue("@codePostal", uneEntreprise.CodePostal);
                    cmd.Parameters.AddWithValue("@ville", uneEntreprise.Ville);
                    cmd.Parameters.AddWithValue("@commentaire", uneEntreprise.Commentaire);
                    cmd.Parameters.AddWithValue("@idEntreprise", uneEntreprise.IdEntreprise);

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
                List<Entreprise> lesEntreprises = readAllWs();
                
                foreach (Entreprise uneEntreprise in lesEntreprises)
                {
                    open("App");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE entreprise SET entrepriseCreer=@entrepriseCreer WHERE idEntreprise=@idEntreprise";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@entrepriseCreer", true);
                    cmd.Parameters.AddWithValue("@idEntreprise", uneEntreprise.IdEntreprise);
                    cmd.ExecuteNonQuery();
                    close();
                }
                
                
                foreach (Entreprise uneEntreprise in lesEntreprises)
                {
                    create(uneEntreprise, "Web");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }

        }
        public static DataTable dtReadAll()
        {
            DataTable dtEntreprise = new DataTable();

            try
            {
                open("App");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM entreprise";

                MySqlDataReader res = cmd.ExecuteReader();

                dtEntreprise.Load(res);

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return dtEntreprise;
            }
            return dtEntreprise;
        }

        //public static bool verification()
        //{
        //    try
        //    {
        //        open("App");
        //        MySqlCommand cmd = new MySqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandText = "SELECT * FROM entreprise";

        //        MySqlDataReader res = cmd.ExecuteReader();

        //        dtEntreprise.Load(res);

        //        close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine("Error: {0}", ex.ToString());

        //        return dtEntreprise;
        //    }
        //    return dtEntreprise;
        //}
    }
}
