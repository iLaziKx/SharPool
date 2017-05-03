using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webservice
{
    public class Entreprise
    {
        int idEntreprise;
        string numeroSiret;
        string nomEntreprise;
        string adresse;
        string codePostal;
        string ville;
        string commentaire;
        bool entrepriseCreer;

        public Entreprise(int idEntreprise, string numeroSiret, string nomEntreprise, string adresse, string codePostal, string ville, string commentaire, bool entrepriseCreer)
        {
            this.idEntreprise = idEntreprise;
            this.numeroSiret = numeroSiret;
            this.nomEntreprise = nomEntreprise;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.commentaire = commentaire;
            this.entrepriseCreer = entrepriseCreer;
        }

        public int IdEntreprise { get => idEntreprise; set => idEntreprise = value; }
        public string NumeroSiret { get => numeroSiret; set => numeroSiret = value; }
        public string NomEntreprise { get => nomEntreprise; set => nomEntreprise = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public bool EntrepriseCreer { get => entrepriseCreer; set => entrepriseCreer = value; }
    }
}