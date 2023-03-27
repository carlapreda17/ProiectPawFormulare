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
    public partial class Form4 : Form
    {
        public Magazin m=new Magazin();
        List<Tranzactii> list=new List<Tranzactii>();
        public Form4(Magazin m)
        {
            InitializeComponent();
            foreach(Tranzactii t in m.ListaTranzactii)
            {
                
                listBox1.Items.Add(t);
            }
        }

        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string numeFisier = "tranzactii.txt";

            StreamWriter sw = new StreamWriter(numeFisier);

            
                
                foreach(Tranzactii t in listBox1.Items)
                    sw.WriteLine(t.ToString());

                sw.Close();
                //textBox1.Clear();
            
        }

        private void citireFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf4 = new BinaryFormatter();
            FileStream fs4 = new FileStream("tranzactii.dat", FileMode.Open, FileAccess.Read);


            if (new FileInfo("tranzactii.dat").Length != 0)
                   list= (List<Tranzactii>)bf4.Deserialize(fs4);
            fs4.Close();
            foreach (Tranzactii tranzactii in list)
            {

                listBox1.Items.Add(tranzactii);
            }
        }

       
    }
}
