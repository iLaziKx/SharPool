using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharPool.Classes
{
    class Entreprise
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
        public Entreprise(string numeroSiret, string nomEntreprise, string adresse, string codePostal, string ville, string commentaire, bool entrepriseCreer)
        {
            this.idEntreprise = 0;
            this.numeroSiret = numeroSiret;
            this.nomEntreprise = nomEntreprise;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.commentaire = commentaire;
            this.entrepriseCreer = entrepriseCreer;
        }

        public int IdEntreprise
        {
            get
            {
                return idEntreprise;
            }

            set
            {
                idEntreprise = value;
            }
        }

        public string NumeroSiret
        {
            get
            {
                return numeroSiret;
            }

            set
            {
                numeroSiret = value;
            }
        }

        public string NomEntreprise
        {
            get
            {
                return nomEntreprise;
            }

            set
            {
                nomEntreprise = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string CodePostal
        {
            get
            {
                return codePostal;
            }

            set
            {
                codePostal = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }
        

        public string Commentaire
        {
            get
            {
                return commentaire;
            }

            set
            {
                commentaire = value;
            }
        }

        public bool EntrepriseCreer
        {
            get
            {
                return entrepriseCreer;
            }

            set
            {
                entrepriseCreer = value;
            }
        }
    }
}
