using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharPool.Classes
{
    class Contrat
    {
        int id_contrat;
        DateTime date_debut;
        DateTime date_fin;
        string satisfaction;
        string descrption;
        string nom_tuteur;
        string tel_tuteur;
        string mail_tuteur;
        string nom_eleve;
        string prenom_eleve;
        bool archivage;
        int id_entreprise;
        int id_promotion;
        int id_types;

        public Contrat(int id_contrat, DateTime dateDebut, DateTime dateFin, string satisfaction, string descriptionPoste, string nomTuteur, string numeroResponsable, string mailTuteur, string nomEleve, string prenomEleve, bool archivage, int idType, int idEntreprise, int idPromotion)
        {
            this.id_contrat = id_contrat;
            this.date_debut = dateDebut;
            this.date_fin = dateFin;
            this.satisfaction = satisfaction;
            this.descrption = descriptionPoste;
            this.nom_tuteur = nomTuteur;
            this.tel_tuteur = numeroResponsable;
            this.mail_tuteur = mailTuteur;
            this.nom_eleve = nomEleve;
            this.prenom_eleve = prenomEleve;
            this.archivage = archivage;
            this.id_types = idType;
            this.id_entreprise = idEntreprise;
            this.id_promotion = idPromotion;
        }

        public Contrat(DateTime dateDebut, DateTime dateFin, string satisfaction, string descriptionPoste, string nomTuteur, string numeroResponsable, string mailTuteur, string nomEleve, string prenomEleve, bool archivage, int idType, int idEntreprise, int idPromotion)
        {
            this.id_contrat = 0;
            this.date_debut = dateDebut;
            this.date_fin = dateFin;
            this.satisfaction = satisfaction;
            this.descrption = descriptionPoste;
            this.nom_tuteur = nomTuteur;
            this.tel_tuteur = numeroResponsable;
            this.mail_tuteur = mailTuteur;
            this.nom_eleve = nomEleve;
            this.prenom_eleve = prenomEleve;
            this.archivage = archivage;
            this.id_types = idType;
            this.id_entreprise = idEntreprise;
            this.id_promotion = idPromotion;
        }

        public int IdContrat
        {
            get
            {
                return id_contrat;
            }

            set
            {
                id_contrat = value;
            }
        }

        public DateTime DateDebut
        {
            get
            {
                return date_debut;
            }

            set
            {
                date_debut = value;
            }
        }

        public DateTime DateFin
        {
            get
            {
                return date_fin;
            }

            set
            {
                date_fin = value;
            }
        }

        public string Satisfaction
        {
            get
            {
                return satisfaction;
            }

            set
            {
                satisfaction = value;
            }
        }

        public string DescriptionPoste
        {
            get
            {
                return descrption;
            }

            set
            {
                descrption = value;
            }
        }

        public string NomTuteur
        {
            get
            {
                return nom_tuteur;
            }

            set
            {
                nom_tuteur = value;
            }
        }

        public string NumeroResponsable
        {
            get
            {
                return tel_tuteur;
            }

            set
            {
                tel_tuteur = value;
            }
        }

        public string MailTuteur
        {
            get
            {
                return mail_tuteur;
            }

            set
            {
                mail_tuteur = value;
            }
        }

        public string NomEleve
        {
            get
            {
                return nom_eleve;
            }

            set
            {
                nom_eleve = value;
            }
        }

        public string PrenomEleve
        {
            get
            {
                return prenom_eleve;
            }

            set
            {
                prenom_eleve = value;
            }
        }

        public bool Archivage
        {
            get
            {
                return archivage;
            }

            set
            {
                archivage = value;
            }
        }

        public int IdType
        {
            get
            {
                return id_types;
            }

            set
            {
                id_types = value;
            }
        }

        public int IdEntreprise
        {
            get
            {
                return id_entreprise;
            }

            set
            {
                id_entreprise = value;
            }
        }

        public int IdPromotion
        {
            get
            {
                return id_promotion;
            }

            set
            {
                id_promotion = value;
            }
        }
    }
}
