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
           
                


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3(m);
            form.Show();

        }

      

        

        private void citireProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BinaryFormatter bf3 = new BinaryFormatter();
            FileStream fs3 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);


            listBoxProduse.Items.Clear();
            if (new FileInfo("magazin.dat").Length != 0)
                  m  = (Magazin)bf3.Deserialize(fs3);
                 fs3.Close();

            foreach (Raion r in m.ListaRaioane)
            {
                foreach (Produs p in r.ListaProduse)
                    listBoxProduse.Items.Add(p);
            }
        }

        
    }


}
