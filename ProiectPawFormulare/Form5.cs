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

            FileStream fs = new FileStream("produse.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            if (new FileInfo("produse.dat").Length != 0)
                produse = (List<Produs>)bf.Deserialize(fs);
            fs.Close();

            FileStream fs1 = new FileStream("tranzactii.dat", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            if (new FileInfo("tranzactii.dat").Length != 0)
               tranzactii = (List<Tranzactii>)bf1.Deserialize(fs1);
            fs1.Close();


            foreach (Raion r in m.ListaRaioane)
            {
                int suma = 0;
                string stringProduse = "";
                foreach (Produs produs in produse)
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

            foreach (Tranzactii tranzactii in tranzactii)
            {
                textBox1.Text += tranzactii.ToString() + Environment.NewLine;
            }



        }

       
        
    }
}
