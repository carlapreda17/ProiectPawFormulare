using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPawFormulare
{
    public partial class Form1 : Form
    {

        List<Raion> listaRaioane = new List<Raion>();
        List<Produs> listaProduse = new List<Produs>();
        public Magazin m = new Magazin();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ai reusit sa faci click!");
            if (codTb.Text == "")
                errorProvider1.SetError(codTb, "Introduceti codul");
            if (pretTb.Text == "")
                errorProvider1.SetError(pretTb, "Introduceti pretul");
            if (numeTb.Text == "")
                errorProvider1.SetError(numeTb, "Introduceti numele");
            if (tipTb.Text == "")
                errorProvider1.SetError(tipTb, "Introduceti tipul");
            if (cantitateTb.Text == "")
                errorProvider1.SetError(tipTb, "Introduceti cantitatea");
            try
            {
                int cod = Convert.ToInt32(codTb.Text);
                float pret = Convert.ToSingle(pretTb.Text);
                string nume = numeTb.Text;
                string tip = tipTb.Text;
                int cantitate = Convert.ToInt32(cantitateTb.Text);


                Produs p = new Produs(cod, nume, tip, pret);
                Tuple<Produs, int> produsCantitate = new Tuple<Produs, int>(p, cantitate);
                listaProduse.Add(p);

                for (int i = 0; i < m.ListaRaioane.Count; i++)
                {
                    if (m.ListaRaioane[i].Nume_raion.ToLower() == tip.ToLower())
                    {
                        m.ListaRaioane[i] = m.ListaRaioane[i] + produsCantitate;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    //afiseaza eroarea
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
            MessageBox.Show(m.ToString());
        }
    }
}
