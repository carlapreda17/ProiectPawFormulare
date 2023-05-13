using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProiectPawFormulare
{
    public partial class Form5 : Form
    {
        List<Raion> raioane=new List<Raion>();
        List<Tranzactii> tranzactii=new List<Tranzactii>();
        List<Produs> produse=new List<Produs>();
        public Magazin m;
        public Form5(Magazin magazin)
        {
            InitializeComponent();
            m = magazin;
            BinaryFormatter bf3 = new BinaryFormatter();
            FileStream fs3 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);

            if (new FileInfo("magazin.dat").Length != 0)
                m = (Magazin)bf3.Deserialize(fs3);
            fs3.Close();

            textBox1.Text=m.ToString();

          /*  foreach (Raion r in m.ListaRaioane)
            {
                int suma = 0;
                string stringProduse = "";
                foreach (Produs produs in r.ListaProduse)
                {
                    if (produs.Tip.ToLower() == r.Nume_raion.ToLower())
                    {
                        suma++;
                        stringProduse += produs.ToString() + Environment.NewLine;
                    }
                }
                if (suma == 0)
                {
                    textBox1.Text += "Raionul " + r.Nume_raion + " nu are produse!" + Environment.NewLine;
                }
                else
                {
                    textBox1.Text += "Raionul " + r.Nume_raion + " are urmatoarele produse:" + Environment.NewLine;
                    textBox1.Text += stringProduse;
                }
            }

            foreach (Tranzactii tranzactii in m.ListaTranzactii)
            {

                textBox1.Text += tranzactii.ToString() + Environment.NewLine;
            }*/



        }

       
        
    }
}
