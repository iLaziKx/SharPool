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

namespace SharPool
{
    public partial class Affichage : MetroFramework.Forms.MetroForm
    {
        public Affichage()
        {
            InitializeComponent();

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

        }
    }
}
