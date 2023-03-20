using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPawFormulare
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Magazin m = new Magazin();
            m.Nume_magazin = "Candyland";
            m.Adresa = "Penes Curcanul 16-18";

            Raion r1 = new Raion();
            r1.Nume_raion = "ciocolata";

            Raion r2 = new Raion();
            r2.Nume_raion = "bomboane";

            Raion r3 = new Raion();
            r3.Nume_raion = "jeleuri";

            Raion r4 = new Raion();
            r4.Nume_raion = "biscuiti";

            m.AdaugaRaion(r1);
            m.AdaugaRaion(r2);
            m.AdaugaRaion(r3);
            m.AdaugaRaion(r4);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
