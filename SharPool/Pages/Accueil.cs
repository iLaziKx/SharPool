using MetroFramework;
using SharPool.Pages;
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

namespace SharPool
{
    public partial class Accueil : MetroFramework.Forms.MetroForm
    {
        DataTable dtListeEntreprise = AdoEntreprise.dtReadAll();

        public Accueil()
        {
            InitializeComponent();

            refreshDTListeEntreprise();
            refreshGrid(dtListeEntreprise);      //Affichage des entreprises dans le tableau
        }
        

        private void metroTile1_Click(object sender, EventArgs e)
        {
            List<Entreprise> lesEntreprises = Ado.AdoEntreprise.readAllWs("App");
            foreach (Entreprise uneEnt in lesEntreprises)
            {
                Ado.AdoEntreprise.create(uneEnt, "Web");
                Ado.AdoEntreprise.updateWs(uneEnt);
            }

            List<Contrat> lesContrats = Ado.AdoContrat.readAllWs("App");
            foreach (Contrat unContrat in lesContrats)
            {
                Ado.AdoContrat.create(unContrat, "Web");
                Ado.AdoContrat.updateWs(unContrat);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns[2].Index && e.RowIndex >= 0)
            {
                Affichage affichage = new Affichage();
                affichage.Show();
                this.Close();
            }                
            else if (e.ColumnIndex == senderGrid.Columns[3].Index && e.RowIndex >= 0)
            {
                Modifier modifier = new Modifier();
                modifier.Show();
                this.Close();
            }
            else if (e.ColumnIndex == senderGrid.Columns[4].Index && e.RowIndex >= 0)
            {
                AjoutContrat ajoutContrat = new AjoutContrat();
                ajoutContrat.Show();
                this.Close();
            }
            else if (e.ColumnIndex == senderGrid.Columns[5].Index && e.RowIndex >= 0)
            {
                DialogResult result = MetroMessageBox.Show(this,"Voulez-vous vraiment supprimé?" , "Confirmation", MessageBoxButtons.YesNo);
            }
        }
        private void refreshDTListeEntreprise()
        {
            dtListeEntreprise = AdoEntreprise.dtReadAll();
        }
        private void refreshGrid(DataTable DataTableForFill)
        {
            //Chargement de la liste des entreprises
            gridRecherche.RowTemplate.MinimumHeight = 35;
            gridRecherche.AutoGenerateColumns = false;
            gridRecherche.Columns[0].DataPropertyName = "numeroSiret";
            gridRecherche.Columns[1].DataPropertyName = "nomEntreprise";
            gridRecherche.DataSource = DataTableForFill;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AjoutEntreprise ajoutEntreprise = new AjoutEntreprise();
            ajoutEntreprise.Show();
            this.Close();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sharPoolDataSet.Entreprise'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.entrepriseTableAdapter.Fill(this.sharPoolDataSet.Entreprise);

        }
    }
}
