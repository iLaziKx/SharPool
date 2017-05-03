using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Webservice
{
    public class Ado
    {
        public static MySqlConnection conn = null;

        public static void Open(String connection)
        {
            if (connection == "App")
            {
                string cs = "Data Source=192.128.1.241; Initial Catalog=sharpoolapp; User ID=sharpool; Password=sio2alt";
                try
                {
                    conn = new MySqlConnection(cs);
                    conn.Open();
                    Console.WriteLine("SQL : {0}", conn.ServerVersion);
                    //MessageBox.Show("Connection application reussi");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    Console.WriteLine("Connexion application fail");

                }
            }
            else if (connection == "Web")
            {
                string cs = "Data Source=localhost; Initial Catalog=sharpoolweb; User ID=sharpool; Password=sio2alt";
                try
                {
                    conn = new MySqlConnection(cs);
                    conn.Open();
                    Console.WriteLine("SQL : {0}", conn.ServerVersion);
                    //MessageBox.Show("Connection web service reussi");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    Console.WriteLine("Connexion web service fail");

                }
            }
        }


        protected static void Close()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
