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
    public partial class AjoutEntreprise : MetroFramework.Forms.MetroForm
    {
        public AjoutEntreprise()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void ajoutBtn_Click(object sender, EventArgs e)
        {
            Entreprise ent = new Entreprise(siretBox.Text, entBox.Text, adresseBox.Text, cpBox.Text, villeBox.Text, mailBox.Text, telBox.Text, tbxCommentaire.Text, false);
            AdoEntreprise.create(ent, "App");
        }
    }
}
