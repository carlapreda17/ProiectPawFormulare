using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ProiectPawFormulare
{
    public partial class Form6 : Form
    {
        //Chart chart = new Chart();
        List<Tranzactii> tranzactii = new List<Tranzactii>();
        
        Graphics gr;
        const int marg = 10;
        Bitmap bmp;

        // public Magazin magazin;
        public Form6()
        {
            InitializeComponent();

            FileStream fs1 = new FileStream("tranzactii.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            if (new FileInfo("tranzactii.dat").Length != 0)
                tranzactii = (List<Tranzactii>)bf1.Deserialize(fs1);
            fs1.Close();

            gr = panel1.CreateGraphics();


        }

      
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + marg, panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 3 * marg);
            Pen pen = new Pen(Color.White, 3);
            gr.DrawRectangle(pen, rec);
           


            double latime = rec.Width / tranzactii.Count / 2;
            double distanta = (rec.Width - tranzactii.Count * latime) / (tranzactii.Count + 1);
            double vMax = 0;
            for (int i = 0; i < tranzactii.Count; i++)
            {
                if (tranzactii[i].Cantitate_produs > vMax)
                    vMax = tranzactii[i].Cantitate_produs;
            }

            Brush b = new SolidBrush(Color.Yellow);

            Rectangle[] recs = new Rectangle[tranzactii.Count];
            for (int i = 0; i < tranzactii.Count; i++)
            {
                recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime), (int)(rec.Location.Y + rec.Height - tranzactii[i].Cantitate_produs / vMax * rec.Height), (int)latime, (int)(tranzactii[i].Cantitate_produs / vMax * rec.Height));  //rectangle primeste doar valori int
                                                                                                                                                                                                                                                                    // gr.FillRectangle(b, recs[i]);
                gr.DrawString(tranzactii[i].Cantitate_produs.ToString(), this.Font, b, recs[i].Location.X, recs[i].Location.Y - this.Font.Height); //scadem inaltimea fontului
            }
            gr.FillRectangles(b, recs);

            for (int i = 0; i < tranzactii.Count - 1; i++)

                gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), recs[i + 1].Location.Y), new Point((int)(recs[i].Location.X + latime / 2), recs[i + 1].Location.Y));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

      
    }
}
