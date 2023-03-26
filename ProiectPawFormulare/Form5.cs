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

namespace ProiectPawFormulare
{
    public partial class Form5 : Form
    {
        public Magazin m;
        public Form5(Magazin magazin)
        {
            InitializeComponent();
            m = magazin;
            textBox1.Text=m.ToString()+Environment.NewLine;
        }

        private void salvareMagazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt"; //filtrare fisiere
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
            
                 sw.WriteLine(m.ToString());

                sw.Close();
                textBox1.Clear();
            }
        }

        private void citireMagazinToolStripMenuItem_Click(object sender, EventArgs e)
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
