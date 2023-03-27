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
                DateTime data;
                if (DateTime.TryParseExact(dataTb.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                {
                    Tranzactii t = new Tranzactii(dataTb.Text,Int32.Parse(codPTb.Text), Int32.Parse(cantTB.Text));
                    tranzactiiList.Add(t);


                    FileStream fs = new FileStream("tranzactii.dat", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, tranzactiiList);
                    fs.Close();


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
    }
}
