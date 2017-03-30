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
        public Modifier()
        {
            InitializeComponent();
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
            
        }
    }
}
