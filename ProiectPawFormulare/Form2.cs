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
    public partial class Form2 : Form
    {

        public Form2(Magazin m)
        {
            InitializeComponent();

            foreach (Raion r in m.ListaRaioane)
            {
                foreach (Tuple<Produs, int> p in r.ListaProduse)
                {
                    textBox1.Text = p.Item1.ToString() + Environment.NewLine;
                    listBoxProduse.Items.Add(p.Item1);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantitate = Convert.ToInt32(cantTb);

           // List<Tuple<Produs, int>> lista = new List<Tuple<Produs, int>>();
            //for (int i = 0; i < listaProduse.Count; i++)
            //{

               // for (int j = 0; j < listaRaioane.Count; j++)
                //{
                   // if (listaProduse[i].Tip == listaRaioane[j].Nume_raion)
                    //{

                        // listaRaioane[j] += new Tuple<Produs, int>(listaProduse[i], cantitate);
                      //  textBox1.Text = listaRaioane[j].ToString() + Environment.NewLine;

                    //}

            
                //}

            }
      
    }

       
}

