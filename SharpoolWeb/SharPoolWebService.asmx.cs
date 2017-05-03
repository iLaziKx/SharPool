using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using System.IO;
using Webservice;


namespace SharpoolWeb
{
    /// <summary>
    /// Description résumée de SharPoolWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class SharPoolWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Test()
        {

            //  SERIALISATION 
           
            List<Entreprise> LesEntreprises = new List<Entreprise>();
            LesEntreprises = AdoEntreprise.readAll();
            File.WriteAllText(@"C:\temp\Test.json", LesEntreprises.ToString());
            string json = JsonConvert.SerializeObject(LesEntreprises, Formatting.Indented);

            return json;
        }


    }
}
