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
    public partial class Modifier : MetroFramework.Forms.MetroForm
    {
        Entreprise laEntreprise;
        public Modifier(string idEntreprise)
        {
            InitializeComponent();
            laEntreprise = AdoEntreprise.readOne(Convert.ToInt32(idEntreprise));

            siretBox.Text = laEntreprise.NumeroSiret;
            entBox.Text = laEntreprise.NomEntreprise;
            adresseBox.Text = laEntreprise.Adresse;
            cpBox.Text = laEntreprise.CodePostal;
            villeBox.Text = laEntreprise.Ville;
            tbxCom.Text = laEntreprise.Commentaire;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void ValideBox_Click(object sender, EventArgs e)
        {
            AdoEntreprise.update(laEntreprise);
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }
    }
}
