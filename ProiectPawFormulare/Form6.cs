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

        public Magazin m;

        Graphics gr;
        const int marg = 10;
        Bitmap bmp;

        // public Magazin magazin;
        public Form6()
        {
            InitializeComponent();

            BinaryFormatter bf3 = new BinaryFormatter();
            FileStream fs3 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);

            if (new FileInfo("magazin.dat").Length != 0)
                m = (Magazin)bf3.Deserialize(fs3);
            fs3.Close();

            gr = panel1.CreateGraphics();


        }

      
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + marg, panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 3 * marg);
            Pen pen = new Pen(Color.White, 3);
            gr.DrawRectangle(pen, rec);
           


            double latime = rec.Width / m.ListaTranzactii.Count / 2;
            double distanta = (rec.Width - m.ListaTranzactii.Count * latime) / (m.ListaTranzactii.Count + 1);
            double vMax = 0;
            int cantitate;
            for (int i = 0; i < m.ListaTranzactii.Count; i++)
            {
                if (m.ListaTranzactii[i].Cantitate_produs > vMax)
                    vMax = m.ListaTranzactii[i].Cantitate_produs;
            }


                Brush b = new SolidBrush(Color.Yellow);

            Rectangle[] recs = new Rectangle[m.ListaTranzactii.Count];
            for (int i = 0; i < m.ListaTranzactii.Count; i++)
            {
                recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime), (int)(rec.Location.Y + rec.Height - m.ListaTranzactii[i].Cantitate_produs / vMax * rec.Height), (int)latime, (int)(m.ListaTranzactii[i].Cantitate_produs / vMax * rec.Height));  
                                                                                                                                                                                                                                                                  
                gr.DrawString(m.ListaTranzactii[i].Cantitate_produs.ToString(), this.Font, b, recs[i].Location.X, recs[i].Location.Y - this.Font.Height); //scadem inaltimea fontului
                Font miniFont = new Font(this.Font.Name, (float)(this.Font.Size * 0.97));
                gr.DrawString(m.ListaTranzactii[i].Data, this.Font,
                       b, recs[i].Location.X - miniFont.Size, recs[i].Location.Y + recs[i].Height);
            }
            gr.FillRectangles(b, recs);

            for (int i = 0; i < m.ListaTranzactii.Count - 1; i++)

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
