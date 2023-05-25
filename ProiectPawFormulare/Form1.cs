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
using System.Data.OleDb;
using System.Drawing.Imaging;

namespace ProiectPawFormulare
{
    public partial class Form1 : Form
    {

        List<Raion> listaRaioane = new List<Raion>();
        List<Produs> listaProduse = new List<Produs>();
        List<Tranzactii> listaTranzactii = new List<Tranzactii>();

        string connString;

        public Magazin m = new Magazin();

        public Form1()
        {
            InitializeComponent();

            FileStream fs1 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            if (new FileInfo("magazin.dat").Length != 0)
                m = (Magazin)bf1.Deserialize(fs1);
            fs1.Close();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Produse.accdb";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cod = new Random().Next(10000);
            codTb.Text = cod.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var ok = 1;
            if (codTb.Text == "")
            {
                errorProvider1.SetError(codTb, "Introduceti codul");
                ok = 0;
            }
            if (pretTb.Text == "")
            {
                errorProvider1.SetError(pretTb, "Introduceti pretul");
                ok = 0;
            }
            if (numeTb.Text == "")
            {
                errorProvider1.SetError(numeTb, "Introduceti numele");
                ok = 0;
            }

            if (tipTb.Text == "")
            {
                errorProvider1.SetError(tipTb, "Introduceti tipul");
                ok = 0;
            }

            if (cantitateTb.Text == "")
            {
                errorProvider1.SetError(cantitateTb, "Introduceti cantitatea");
                ok = 0;
            }
            if (ok == 1)
            {
                foreach (char c in tipTb.Text)
                {
                    if (!Char.IsLetter(c))
                    {
                        ok = 0;
                        MessageBox.Show("Tip Invalid!");
                        break;
                    }


                }

                if (ok == 1)
                {





                    MessageBox.Show("Ai reusit sa adaugi produsul!");
                }


            }
            try
            {

                int cod = Convert.ToInt32(codTb.Text);
                float pret = Convert.ToSingle(pretTb.Text);
                string nume = numeTb.Text;
                string tip = tipTb.Text;
                int cantitate = Convert.ToInt32(cantitateTb.Text);


                Produs p = new Produs(cod, nume, tip, pret, cantitate);

                listaProduse.Add(p);

                for (int i = 0; i < m.ListaRaioane.Count; i++)
                {
                    if (m.ListaRaioane[i].Nume_raion.ToLower() == tip.ToLower())
                    {
                        m.ListaRaioane[i] = m.ListaRaioane[i] + p;
                    }
                }
                FileStream fs = new FileStream("magazin.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, m);
                fs.Close();
                if(pictureBox1.Image != null && !IsEmptyImage(pictureBox1.Image))
                {
                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {


                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imageData = ms.ToArray();
                    }



                    OleDbConnection conexiune = new OleDbConnection(connString);
                    OleDbCommand comanda = new OleDbCommand("INSERT INTO Produse (ID,Poze) VALUES (@ID,@Imagine)", conexiune);

                    comanda.Parameters.AddWithValue("@ID", cod);
                    comanda.Parameters.AddWithValue("@Imagine", imageData);

                    conexiune.Open();
                    comanda.ExecuteNonQuery();
                    conexiune.Close();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    //afiseaza eroarea
            }
            finally
            {
                codTb.Clear();
                pretTb.Clear();
                tipTb.Clear();
                numeTb.Clear();
                cantitateTb.Clear();
                int cod = new Random().Next(10000);
                codTb.Text = cod.ToString();
                if (pictureBox1.Image != null)
                {

                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2(m);
            //pt navigare intre ele ShowDialog - doar navigare pe cea deschisa
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // MessageBox.Show(m.ToString());
            Form5 from = new Form5(m);
            from.Show();
        }

        private void vizulaizareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(m);
            //pt navigare intre ele ShowDialog - doar navigare pe cea deschisa
            frm.Show();
        }

        private void vizualizareMagazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(m.ToString());
            Form5 from = new Form5(m);
            from.Show();
        }
        private bool isImageFile(string filePath)
        {
            string extension = System.IO.Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif";
        }
        private bool IsEmptyImage(Image image)
        {
            using (var bitmap = new Bitmap(image))
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        if (bitmap.GetPixel(x, y).A != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere imagine (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";
            //DialogResult rezultat = dialog.ShowDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                if (isImageFile(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                    byte[] imageBytes = File.ReadAllBytes(imagePath);

                }
            }
        }

        private void galerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 from = new Form7(m);
            from.Show();
        }
    }
}
