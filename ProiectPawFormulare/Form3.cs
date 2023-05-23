using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ProiectPawFormulare
{
   
    public partial class Form3 : Form
    {

        List<Tranzactii> tranzactiiList = new List<Tranzactii>();
        public Magazin m;
        Graphics gr;
        public Form3(Magazin magazin)
        {
            InitializeComponent();
            m = magazin;

            BinaryFormatter bf3 = new BinaryFormatter();
            FileStream fs3 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);

            if (new FileInfo("magazin.dat").Length != 0)
                m = (Magazin)bf3.Deserialize(fs3);
            fs3.Close();
            

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ok = 1;
            if(codPTb.Text=="")
            {
                errorProvider1.SetError(codPTb, "Introduceti codul");
                ok = 0;
            }
            if (dataTb.Text == "")
            {
                errorProvider1.SetError(dataTb, "Introduceti data");
                ok = 0;
            }
               
            if (cantTB.Text == "")
            {
                errorProvider1.SetError(cantTB, "Introduceti codul");
                ok = 0;
            }
            
            if (ok == 1)
            {
                var ok1 = 0;
                foreach (Raion r in m.ListaRaioane)
                {
                    foreach (Produs p in r.ListaProduse)
                    {
                        if(p.CodProdus.ToString()==codPTb.Text)
                        {
                            ok1 = 1;
                            break;
                        }
                    }
                }

                 DateTime data;
                if (DateTime.TryParseExact(dataTb.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data) && ok1==1)
                {
                   

                    MessageBox.Show("Ai reusit sa adaugi tranzactia!");
                }
                else
                {
                    MessageBox.Show("Data invalida!");
                }
                   

            }
            try
            {
                int cod = Convert.ToInt32(codPTb.Text);
                int cantitate_produs = Convert.ToInt32(cantTB.Text);
                string data = dataTb.Text;

                var ok2 = 0;
                foreach (Raion r in m.ListaRaioane)
                {
                    foreach (Produs p in r.ListaProduse)
                    {
                        if (p.CodProdus.ToString() == codPTb.Text)
                        {
                            ok2 = 1;
                            break;
                        }
                    }
                }
                if(ok2==1)
                {
                    Tranzactii t = new Tranzactii(data, cantitate_produs, cod);
                    m.AdaugaTranzactie(t);

                    FileStream fs = new FileStream("magazin.dat", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, m);
                    fs.Close();
                }
                else
                {
                    MessageBox.Show("Nu exista produsul selectat");
                }

               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                codPTb.Clear();
                cantTB.Clear();
                dataTb.Clear();
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(m);
            form.Show();

        }

       

        private void Form3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Produs)))
            {
                
                e.Effect = DragDropEffects.Move;
                //MessageBox.Show("Operatiunea de tragere s-a realizat cu succes!");
               
            }
            else
            {
               
                e.Effect = DragDropEffects.None; 
            }
        }

        private void Form3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Produs)))
            {

                Produs produsTras = (Produs)e.Data.GetData(typeof(Produs));
                codPTb.Text = produsTras.CodProdus.ToString();

            }
        }
        private void pd_print(object sender, PrintPageEventArgs e)
        {
            gr = e.Graphics;
            int i = m.ListaTranzactii.Count - 1;
              
            e.Graphics.DrawString("Detalii tranzactie -Magazinul CandyLand", new Font("Arial", 20), Brushes.RoyalBlue, new Point(50, 50));
            e.Graphics.DrawString("**********************************************************",new Font("Arial", 14), Brushes.RoyalBlue, new Point(50, 100));
            e.Graphics.DrawString("ID PRODUS:", new Font("Arial", 16), Brushes.RoyalBlue, new Point(50, 130));
            e.Graphics.DrawString(m.ListaTranzactii[i].Cod.ToString(), new Font("Arial", 16), Brushes.RoyalBlue, new Point(190, 130));
            e.Graphics.DrawString("VALOARE TRANZACȚIE: ", new Font("Arial", 16), Brushes.RoyalBlue, new Point(50, 170));
            e.Graphics.DrawString(m.ListaTranzactii[i].Cost_final.ToString()+" ron", new Font("Arial", 16), Brushes.RoyalBlue, new Point(300, 170));
            e.Graphics.DrawString("DATA TRANZACȚIE: ", new Font("Arial", 16), Brushes.RoyalBlue, new Point(50, 210));
            e.Graphics.DrawString(m.ListaTranzactii[i].Data.ToString(), new Font("Arial", 16), Brushes.RoyalBlue, new Point(255, 210));


        }
        private void button4_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
