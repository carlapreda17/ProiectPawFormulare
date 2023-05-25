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



namespace ProiectPawFormulare
{
    public partial class Form7 : Form
    {
        public Magazin m;
        public Form7(Magazin magazin)
        {
            InitializeComponent();
            m = magazin;

            BinaryFormatter bf3 = new BinaryFormatter();
            FileStream fs3 = new FileStream("magazin.dat", FileMode.Open, FileAccess.Read);

            if (new FileInfo("magazin.dat").Length != 0)
                m = (Magazin)bf3.Deserialize(fs3);
            fs3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(tbCod.Text);
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Produse.accdb";
            using (OleDbConnection conexiune = new OleDbConnection(connString))
            {
                OleDbCommand comanda = new OleDbCommand("SELECT Poze FROM Produse WHERE ID = @ID", conexiune);
                comanda.Parameters.AddWithValue("@ID", cod);

                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();

                if (reader.Read())
                {
                    // Verifică dacă există o imagine înregistrată pentru ID-ul de produs
                    if (!reader.IsDBNull(0))
                    {
                        byte[] imageBytes = (byte[])reader.GetValue(0);

                        // Convertă șirul de octeți (byte array) într-o imagine
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produsul nu are poza");
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    // ID-ul de produs nu a fost găsit în bază de date
                    pictureBox1.Image = null;
                }

                reader.Close();
            }

        }

        private void Form7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Produs)))
            {

                e.Effect = DragDropEffects.Move;
                //MessageBox.Show("Operatiunea de tragere s-a realizat cu succes!");

            }
            else
            {

                e.Effect = DragDropEffects.None;
            }
        }

        private void Form7_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Produs)))
            {

                Produs produsTras = (Produs)e.Data.GetData(typeof(Produs));
               tbCod.Text = produsTras.CodProdus.ToString();

            }
        }
    }
}
