using System;
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
                    cmd.CommandText = "INSERT INTO Entreprise (numeroSiret,nomEntreprise,adresse,ville,commentaire,entrepriseCreer) VALUES (@numeroSiret,@nomEntreprise,@adresse,@ville,@commentaire,@entrepriseCreer)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@numeroSiret", uneEntreprise.NumeroSiret);
                    cmd.Parameters.AddWithValue("@nomEntreprise", uneEntreprise.NomEntreprise);
                    cmd.Parameters.AddWithValue("@adresse", uneEntreprise.Adresse);
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
                cmd.CommandText = "SELECT * FROM Entreprise WHERE id= " + unId;

                MySqlDataReader res = cmd.ExecuteReader();
                res.Read();
                uneEntreprise = new Entreprise((string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["ville"], (string)res["codePostal"], (string)res["commentaire"], (bool)res["entrepriseCreer"]);

                close();
                return uneEntreprise;

            }
            public static List<Entreprise> readAll()
            {
                List<Entreprise> lesEntreprise = new List<Entreprise>();
                open("App");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Entreprise";

                MySqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    res.Read();
                    lesEntreprise.Add(new Entreprise((string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["ville"], (string)res["codePostal"], (string)res["commentaire"], (bool)res["entrepriseCreer"]));
            }

                return lesEntreprise;

            }

        public static List<Entreprise> readAllWs(string connect)
        {
            List<Entreprise> lesEntreprise = new List<Entreprise>();
            open("App");

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Entreprise WHERE entrepriseCreer = 0";

            MySqlDataReader res = cmd.ExecuteReader();
            while (res.Read())
            {
                res.Read();
                lesEntreprise.Add(new Entreprise((string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["ville"], (string)res["codePostal"], (string)res["commentaire"], (bool)res["entrepriseCreer"]));
            }

            return lesEntreprise;

        }

        public static void delete(int unId)
            {
                try
                {
                    open("App");

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM Entreprise WHERE id=@id";
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
                    cmd.CommandText = "UPDATE Entreprise SET numeroSiret=@numeroSiret,nomEntreprise=@nomEntreprise,adresse=@adresse,ville=@ville,commentaire=@commentaire,entrepriseCreer=@entrepriseCreer WHERE id=@identreprise";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@identreprise", uneEntreprise.IdEntreprise);
                    cmd.Parameters.AddWithValue("@numeroSiret", uneEntreprise.NumeroSiret);
                    cmd.Parameters.AddWithValue("@nomEntreprise", uneEntreprise.NomEntreprise);
                    cmd.Parameters.AddWithValue("@adresse", uneEntreprise.Adresse);
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

        public static void updateWs(Entreprise uneEntreprise)
        {
            try
            {
                open("App");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Entreprise SET entrepriseCreer=@entrepriseCreer WHERE id=@identreprise";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@entrepriseCreer", 1);

                cmd.ExecuteNonQuery();
                close();
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
                cmd.CommandText = "SELECT * FROM Entreprise";

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
    }
}
