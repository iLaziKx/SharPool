﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Webservice
{
    public class Ado
    {
        public static MySqlConnection conn = null;

        public static void open(String connection)
        {
            if (connection == "App")
            {
                string cs = "Data Source=localhost; Initial Catalog=SharPool; User ID=root; Password=";
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
                string cs = "Data Source=localhost; Initial Catalog=WebService_SharPool; User ID=root; Password=";
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


        protected static void close()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
