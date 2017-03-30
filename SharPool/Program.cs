using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharPool.Ado;

namespace SharPool
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Accueil MainFormListEntreprise = new Accueil();
            MainFormListEntreprise.Show();
            Application.Run();
        }
    }
}
