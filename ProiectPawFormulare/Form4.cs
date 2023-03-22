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
    public partial class Form4 : Form
    {
        public Magazin m=new Magazin();
        public Form4(Magazin m)
        {
            InitializeComponent();
            foreach(Tranzactii t in m.ListaTranzactii)
            {
                textBox1.Text = t.ToString() + Environment.NewLine;
            }
        }

      
    }
}
