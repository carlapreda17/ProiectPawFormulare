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
    public partial class Form2 : Form
    {
        public Magazin m;
        List<Produs> produse=new List<Produs>();
        public Form2(Magazin magazin)
        {
            InitializeComponent();
            m = magazin;
            foreach (Raion r in m.ListaRaioane)
            {
                foreach (Tuple<Produs, int> p in r.ListaProduse)
                {
                   // textBox1.Text = p.Item1.ToString() + Environment.NewLine;
                    listBoxProduse.Items.Add(p.Item1);
                }
            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3(m);
            form.Show();

        }

      

        

        private void citireProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BinaryFormatter bf3 = new BinaryFormatter();
            FileStream fs3 = new FileStream("produse.dat", FileMode.Open, FileAccess.Read);


            listBoxProduse.Items.Clear();
            if (new FileInfo("produse.dat").Length != 0)
                   produse  = (List<Produs>)bf3.Deserialize(fs3);
                 fs3.Close();
            foreach (Produs produs in produse)
            {

                listBoxProduse.Items.Add(produs);
            }
        }

        
    }


}
