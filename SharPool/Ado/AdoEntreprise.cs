using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SharPool.Classes;

namespace SharPool.Ado
{
    class AdoEntreprise : Ado
        {
            public static void create(Entreprise uneEntreprise, string connect)
            {
                try
                {
                    open(connect);

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Entreprise (identreprise,numeroSiret,nomEntreprise,adresse,ville,mail,telphoneEntreprise,commentaire,entCreer) VALUES (@identreprise,@numeroSiret,@nomEntreprise,@adresse,@ville,@mail,@telphoneEntreprise,@commentaire,@entCreer)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@numeroSiret", uneEntreprise.NumeroSiret);
                    cmd.Parameters.AddWithValue("@nomEntreprise", uneEntreprise.NomEntreprise);
                    cmd.Parameters.AddWithValue("@adresse", uneEntreprise.Adresse);
                    cmd.Parameters.AddWithValue("@ville", uneEntreprise.Ville);
                    cmd.Parameters.AddWithValue("@mail", uneEntreprise.Mail);
                    cmd.Parameters.AddWithValue("@telphoneEntreprise", uneEntreprise.TelephoneEntreprise);
                    cmd.Parameters.AddWithValue("@commentaire", uneEntreprise.Commentaire);
                    cmd.Parameters.AddWithValue("@entCreer", uneEntreprise.EntCreer);

                cmd.ExecuteNonQuery();
                    close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());

                }
            }
            public static Entreprise readOne(int unId)
            {
                Entreprise uneEntreprise;
                open("App");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Entreprise WHERE id= " + unId;

                SqlDataReader res = cmd.ExecuteReader();
                res.Read();
                uneEntreprise = new Entreprise((string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["ville"], (string)res["codePostal"], (string)res["mail"], (string)res["telephoneEntreprise"], (string)res["commentaire"], (bool)res["entCreer"]);

                close();
                return uneEntreprise;

            }
            public static List<Entreprise> readAll()
            {
                List<Entreprise> lesEntreprise = new List<Entreprise>();
                open("App");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Entreprise";

                SqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    res.Read();
                    lesEntreprise.Add(new Entreprise((string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["ville"], (string)res["codePostal"], (string)res["mail"], (string)res["telephoneEntreprise"], (string)res["commentaire"], (bool)res["entCreer"]));
            }

                return lesEntreprise;

            }

        public static List<Entreprise> readAllWs(string connect)
        {
            List<Entreprise> lesEntreprise = new List<Entreprise>();
            open("App");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Entreprise WHERE entCreer = 0";

            SqlDataReader res = cmd.ExecuteReader();
            while (res.Read())
            {
                res.Read();
                lesEntreprise.Add(new Entreprise((string)res["numeroSiret"], (string)res["nomEntreprise"], (string)res["adresse"], (string)res["ville"], (string)res["codePostal"], (string)res["mail"], (string)res["telephoneEntreprise"], (string)res["commentaire"], (bool)res["entCreer"]));
            }

            return lesEntreprise;

        }

        public static void delete(int unId)
            {
                try
                {
                    open("App");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM Entreprise WHERE id=@id";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@id", unId);

                    cmd.ExecuteNonQuery();
                    close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());

                }
            }

            public static void update(Entreprise uneEntreprise)
            {
                try
                {
                    open("App");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Entreprise SET numeroSiret=@numeroSiret,nomEntreprise=@nomEntreprise,adresse=@adresse,ville=@ville,mail=@mail,telphoneEntreprise=@telphoneEntreprise,commentaire=@commentaire,entCreer=@entCreer WHERE id=@identreprise";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@identreprise", uneEntreprise.IdEntreprise);
                    cmd.Parameters.AddWithValue("@numeroSiret", uneEntreprise.NumeroSiret);
                    cmd.Parameters.AddWithValue("@nomEntreprise", uneEntreprise.NomEntreprise);
                    cmd.Parameters.AddWithValue("@adresse", uneEntreprise.Adresse);
                    cmd.Parameters.AddWithValue("@ville", uneEntreprise.Ville);
                    cmd.Parameters.AddWithValue("@mail", uneEntreprise.Mail);
                    cmd.Parameters.AddWithValue("@telphoneEntreprise", uneEntreprise.TelephoneEntreprise);
                    cmd.Parameters.AddWithValue("@commentaire", uneEntreprise.Commentaire);
                    cmd.Parameters.AddWithValue("@entCreer", uneEntreprise.EntCreer);

                    cmd.ExecuteNonQuery();
                    close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }

            }

        public static void updateWs(Entreprise uneEntreprise)
        {
            try
            {
                open("App");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Entreprise SET entCreer=@entCreer WHERE id=@identreprise";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@entCreer", 1);

                cmd.ExecuteNonQuery();
                close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }

        }
    }
}
