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
        public AjoutContrat()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int satisfaction;
            if (this.chkPasSatisfait.Checked)
            {
                satisfaction = 0;
            }
            else if (this.chkPasSatisfait.Checked)
            {
                satisfaction = 1;
            }
            else if (this.chkSatisfait.Checked)
            {
                satisfaction = 2;
            }
            else if (this.chkTresSatisfait.Checked)
            {
                satisfaction = 3;
            }
            else
            {
                satisfaction = 0;
            }

            // Contrat unContrat = new Contrat(0, this.dteDebut.Value, this.dteFin.Value, satisfaction, this.tbxCommentaire.Text, this.tbxNomTuteur, tbxTelTuteur, this.tbxMailTuteur, this.tbxNomApprenti, this.tbxPrenomApprenti, 0, 1, int idEntreprise, int idPromotion);
            // AdoContrat.create(unContrat, "App");
        }
    }
}
