using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharPool.Classes;
using SharPool.Ado;

namespace SharPool.Pages
{
    public partial class AjoutContrat : MetroFramework.Forms.MetroForm
    {
        Entreprise laEntreprise;
        public AjoutContrat(string idEntreprise)
        {
            InitializeComponent();
            laEntreprise = AdoEntreprise.readOne(Convert.ToInt32(idEntreprise));
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string satisfaction;
            if (this.pasSatisfait.Checked)
            {
                satisfaction = "0";
            }
            else if (this.peuSatisfait.Checked)
            {
                satisfaction = "1";
            }
            else if (this.satisfait.Checked)
            {
                satisfaction = "2";
            }
            else if (this.tresSatisfait.Checked)
            {
                satisfaction = "3";
            }
            else
            {
                satisfaction = "0";
            }

            Contrat cont = new Contrat(this.dteDebut.Value, this.dteFin.Value, satisfaction, dPoste.Text, tbxNomTuteur.Text, tbxTelTuteur.Text, tbxMailTuteur.Text, tbxNomApprenti.Text, tbxPrenomApprenti.Text, false, 1, laEntreprise.IdEntreprise, 1);
            AdoContrat.create(cont, "App");
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
            
            // Contrat unContrat = new Contrat(0, this.dteDebut.Value, this.dteFin.Value, satisfaction, this.tbxCommentaire.Text, this.tbxNomTuteur, tbxTelTuteur, this.tbxMailTuteur, this.tbxNomApprenti, this.tbxPrenomApprenti, 0, 1, int idEntreprise, int idPromotion);
            // AdoContrat.create(unContrat, "App");
        }
    }
}
