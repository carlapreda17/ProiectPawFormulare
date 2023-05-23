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
using System.Drawing.Printing;

namespace ProiectPawFormulare
{
    public partial class Form4 : Form
    {
        public Magazin m=new Magazin();
        List<Tranzactii> list=new List<Tranzactii>();
        public Form4(Magazin magazin)
        {
            InitializeComponent();
            m= magazin;

           

        }

      

        private void citireFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf4 = new BinaryFormatter();
            FileStream fs4 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);

            listBox1.Items.Clear();
            if (new FileInfo("magazin.dat").Length != 0)
                   m= (Magazin)bf4.Deserialize(fs4);
            fs4.Close();
            foreach (Tranzactii tranzactii in m.ListaTranzactii)
            {

                listBox1.Items.Add(tranzactii);
            }
        }

        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf4 = new BinaryFormatter();
            FileStream fs4 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);

            //listBox1.Items.Clear();
            if (new FileInfo("magazin.dat").Length != 0)
                m = (Magazin)bf4.Deserialize(fs4);
            fs4.Close();
            List<Tranzactii> listaSelectare = new List<Tranzactii>();
         foreach (Tranzactii t in listBox1.SelectedItems)
            {
                listaSelectare.Add(t);
            }

            foreach (Tranzactii t in listaSelectare)
            {
                for (int i = 0; i < m.ListaTranzactii.Count; i++)
                {
                    Tranzactii tr = m.ListaTranzactii[i];
                    if (tr.Cod == t.Cod && tr.Data == t.Data && tr.Cantitate_produs == t.Cantitate_produs)
                    {
                        listBox1.Items.Remove(t);
                        m.ListaTranzactii.Remove(tr);
                        i--;
                        foreach (Raion r in m.ListaRaioane)
                        {
                            foreach (Produs p in r.ListaProduse)
                            {
                                if(p.CodProdus==t.Cod)
                                {
                                    p.Cantitate = p.Cantitate + t.Cantitate_produs;
                                }
                            }
                        }
                        MessageBox.Show("Tranzactia a fost eliminata cu succes");

                    }
                }
            }
            FileStream fs = new FileStream("magazin.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m);
            fs.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form6 frm = new Form6();
                frm.Show();
           
        }
    }
       
}
