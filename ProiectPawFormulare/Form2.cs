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


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();

        }
    }


}
