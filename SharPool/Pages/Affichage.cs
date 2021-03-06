﻿using MetroFramework;
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
    public partial class Affichage : MetroFramework.Forms.MetroForm
    {
        Entreprise laEntreprise;
        public Affichage(string idEntreprise)
        {
            InitializeComponent();
            laEntreprise = AdoEntreprise.readOne(Convert.ToInt32(idEntreprise));

            siretLabel.Text = laEntreprise.NumeroSiret;
            entLabel.Text = laEntreprise.NomEntreprise;
            adresseLabel.Text = laEntreprise.Adresse;
            cpLabel.Text = laEntreprise.CodePostal;
            villeLabel.Text = laEntreprise.Ville;
            comLabel.Text = laEntreprise.Commentaire;

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void historiqueBtn_Click(object sender, EventArgs e)
        {
            HistoriqueContrat historique = new HistoriqueContrat();
            historique.Show();
            this.Close();
        }

        private void newContratBtn_Click(object sender, EventArgs e)
        {
            AjoutContrat ajout = new AjoutContrat(laEntreprise.IdEntreprise.ToString());
            ajout.Show();
            this.Close();
        }
    }
}
