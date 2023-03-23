﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProiectPawFormulare
{
    public partial class Form2 : Form
    {
        public Magazin m;
        public Form2(Magazin magazin)
        {
            InitializeComponent();
            m = magazin;
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
            Form3 form = new Form3(m);
            form.Show();

        }

        private void salvareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt"; //filtrare fisiere
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                foreach (Raion r in m.ListaRaioane)
                {
                    foreach (Tuple<Produs, int> p in r.ListaProduse)
                    {
                        sw.WriteLine(p.Item1.ToString() + Environment.NewLine);
                    }
                }
                
                sw.Close();
                textBox1.Clear();
            }
        }

        private void citireProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }


}
