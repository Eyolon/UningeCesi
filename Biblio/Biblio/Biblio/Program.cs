using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblio
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

            MySQLManager mysqlm = new MySQLManager();

            Form1 IHM = new Form1(mysqlm);   
            Application.Run(IHM);

        }
    }
}
