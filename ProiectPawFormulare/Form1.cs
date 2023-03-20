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
       
        List<Raion> listaRaioane=new List<Raion>();
        List<Produs> listaProduse=new List<Produs>();
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
           try
            {
                int cod = Convert.ToInt32(codTb.Text);
                float pret= Convert.ToSingle(pretTb.Text);
                string nume = numeTb.Text;
                string tip = tipTb.Text;
                
              

                Produs p=new Produs(cod,nume,tip,pret);
                listaProduse.Add(p);
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


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    //afiseaza eroarea
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 frm = new Form2(listaProduse);
            //pt navigare intre ele ShowDialog - doar navigare pe cea deschisa
            frm.ShowDialog();
        }

        
    }
}
