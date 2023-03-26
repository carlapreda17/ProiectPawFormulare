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
    public partial class Form4 : Form
    {
        public Magazin m=new Magazin();
        public Form4(Magazin m)
        {
            InitializeComponent();
            foreach(Tranzactii t in m.ListaTranzactii)
            {
                textBox1.Text = t.ToString() + Environment.NewLine;
                listBox1.Items.Add(t);
            }
        }

        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt"; //filtrare fisiere
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                foreach(Tranzactii t in listBox1.Items)
                    sw.WriteLine(t.ToString());

                sw.Close();
                textBox1.Clear();
            }
        }

        private void citireFisierToolStripMenuItem_Click(object sender, EventArgs e)
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
