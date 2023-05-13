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
    public partial class Form1 : Form
    {

        List<Raion> listaRaioane = new List<Raion>();
        List<Produs> listaProduse = new List<Produs>();
        List<Tranzactii> listaTranzactii = new List<Tranzactii>();
       
        public Magazin m = new Magazin();

        public Form1()
        {
            InitializeComponent();
            /* FileStream fs = new FileStream("produse.dat", FileMode.Open, FileAccess.Read);
             BinaryFormatter bf = new BinaryFormatter();
             if (new FileInfo("produse.dat").Length != 0)
                 listaProduse = (List<Produs>)bf.Deserialize(fs);
             fs.Close();

             FileStream fs1 = new FileStream("tranzactii.dat", FileMode.Open, FileAccess.Read);
             BinaryFormatter bf1 = new BinaryFormatter();
             if (new FileInfo("tranzactii.dat").Length != 0)
                 listaTranzactii = (List<Tranzactii>)bf1.Deserialize(fs1);
             fs1.Close();*/

            FileStream fs1 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            if (new FileInfo("magazin.dat").Length != 0)
                m= (Magazin)bf1.Deserialize(fs1);
            fs1.Close();

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cod = new Random().Next(10000);
            codTb.Text = cod.ToString();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var ok = 1;
            if (codTb.Text == "")
            {
                errorProvider1.SetError(codTb, "Introduceti codul");
                ok = 0;
            }
            if (pretTb.Text == "")
            {
                errorProvider1.SetError(pretTb, "Introduceti pretul");
                ok = 0;
            }
            if (numeTb.Text == "")
            {
                errorProvider1.SetError(numeTb, "Introduceti numele");
                ok = 0;
            }
               
            if (tipTb.Text == "")
            {
                errorProvider1.SetError(tipTb, "Introduceti tipul");
                ok = 0;
            }
           
            if (cantitateTb.Text == "")
            {
                errorProvider1.SetError(cantitateTb, "Introduceti cantitatea");
                ok = 0;
            }
            if (ok == 1)
            {
                foreach (char c in tipTb.Text)
                {
                    if (!Char.IsLetter(c))
                    {
                        ok = 0;
                        MessageBox.Show("Tip Invalid!");
                        break;
                    }
                    
                   
                }

                if (ok == 1)
                {
                   

                  
                   

                    MessageBox.Show("Ai reusit sa adaugi produsul!");
                }


            }
            try
            {

                int cod = Convert.ToInt32(codTb.Text);
                float pret = Convert.ToSingle(pretTb.Text);
                string nume = numeTb.Text;
                string tip = tipTb.Text;
                int cantitate = Convert.ToInt32(cantitateTb.Text);


                Produs p = new Produs(cod, nume, tip, pret,cantitate);
               
                listaProduse.Add(p);

                for (int i = 0; i < m.ListaRaioane.Count; i++)
                {
                    if (m.ListaRaioane[i].Nume_raion.ToLower() == tip.ToLower())
                    {
                        m.ListaRaioane[i] = m.ListaRaioane[i] + p;
                    }
                }
                FileStream fs = new FileStream("magazin.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, m);
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    //afiseaza eroarea
            }
            finally
            {
                    codTb.Clear();
                    pretTb.Clear(); 
                    tipTb.Clear();
                    numeTb.Clear();
                    cantitateTb.Clear();
                    int cod = new Random().Next(10000);
                    codTb.Text = cod.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2(m);
            //pt navigare intre ele ShowDialog - doar navigare pe cea deschisa
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           // MessageBox.Show(m.ToString());
            Form5 from = new Form5(m);
            from.Show();
        }

        private void vizulaizareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(m);
            //pt navigare intre ele ShowDialog - doar navigare pe cea deschisa
            frm.ShowDialog();
        }

        private void vizualizareMagazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(m.ToString());
            Form5 from = new Form5(m);
            from.Show();
        }

      
    }
}
