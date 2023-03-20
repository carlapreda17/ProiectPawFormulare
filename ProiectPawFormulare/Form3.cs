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
    //List<Tranzactii> tranzactiiList=new List<Tranzactii>();
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai reusit sa adaugi tranzactia!");
            if(codPTb.Text=="")
                errorProvider1.SetError(codPTb, "Introduceti codul");
            if (dataTb.Text == "")
                errorProvider1.SetError(dataTb, "Introduceti data");
            if (cantTB.Text == "")
                errorProvider1.SetError(cantTB, "Introduceti codul");

            int cod=Convert.ToInt32(codPTb.Text);
            int cantitate_produs=Convert.ToInt32(cantTB.Text);
            string data=dataTb.Text;



        }
    }
}
