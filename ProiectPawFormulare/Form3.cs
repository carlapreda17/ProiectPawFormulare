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

namespace ProiectPawFormulare
{
   
    public partial class Form3 : Form
    {

        List<Tranzactii> tranzactiiList = new List<Tranzactii>();
        public Magazin m;
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
               /* var ok1 = 0;
                foreach (Raion r in m.ListaRaioane)
                {
                    foreach (Tuple<Produs, int> p in r.ListaProduse)
                    {
                        if(p.Item1.CodProdus.ToString()==codPTb.Text)
                        {
                            ok1 = 1;
                            break;
                        }
                    }
                }*/

                        DateTime data;
                if (DateTime.TryParseExact(dataTb.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
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

                Tranzactii t = new Tranzactii(data, cantitate_produs, cod);
                m.AdaugaTranzactie(t);
              
                FileStream fs = new FileStream("magazin.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, m);
                fs.Close();


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

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 frm= new Form6();
            frm.Show();
        }
    }
}
