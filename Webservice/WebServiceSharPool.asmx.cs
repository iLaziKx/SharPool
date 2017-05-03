using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using System.IO;

namespace Webservice
{
    /// <summary>
    /// Description résumée de WebServiceSharPool
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceSharPool : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
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
