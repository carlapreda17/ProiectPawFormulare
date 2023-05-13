using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPawFormulare
{
    [Serializable]
    public class Raion
    {
        
        private string nume_raion;
        private List<Produs> listaProduse; //adaugare produs+cantitate


        public string Nume_raion { get => nume_raion; set => nume_raion = value; }
        public List<Produs> ListaProduse { get => listaProduse; set => listaProduse = value; }

        public Raion()
        {
            
            nume_raion = "";
           listaProduse = new List<Produs>();
        }

        public Raion(string nume, List<Produs> lista)
        {
            this.nume_raion = nume;
           List<Produs> listaNoua = new List<Produs>();
            foreach (var p in lista)
                    listaNoua.Add(p);
            listaProduse.AddRange(listaNoua);   //adauga elementele listei noi in listaProduse

        }

        public override string ToString()
        {
            string rezultat = "Raionul " + nume_raion + " are urmatoarele produse "+ Environment.NewLine;
            int suma = 0;
            foreach(Produs p in listaProduse)
            {
               
                suma++;
            }
            if(suma==0)
            {
                rezultat=rezultat + "Raionul " + nume_raion + " nu are produse!" + Environment.NewLine;
            }
            else
            {
                foreach (Produs p in listaProduse)
                {
                    rezultat=rezultat+ p.ToString()+Environment.NewLine;
                }
            }
           
            return rezultat;
        }

        public static Raion operator +(Raion r, Produs p)
        {

            r.listaProduse.Add(p);
            return r;
        }

        public static Raion operator -(Raion r, Produs p)
        {


            r.listaProduse.Remove(p);
            return r;
        }

       

    }
}
