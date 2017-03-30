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
        string mail;
        string telephoneEntreprise;
        string commentaire;
        bool entCreer;

        public Entreprise(string numeroSiret, string nomEntreprise, string adresse, string codePostal, string ville, string mail, string telephoneEntreprise, string commentaire, bool entCreer)
        {
            this.idEntreprise = 0;
            this.numeroSiret = numeroSiret;
            this.nomEntreprise = nomEntreprise;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.mail = mail;
            this.telephoneEntreprise = telephoneEntreprise;
            this.commentaire = commentaire;
            this.entCreer = entCreer;
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

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string TelephoneEntreprise
        {
            get
            {
                return telephoneEntreprise;
            }

            set
            {
                telephoneEntreprise = value;
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

        public bool EntCreer
        {
            get
            {
                return entCreer;
            }

            set
            {
                entCreer = value;
            }
        }
    }
}
