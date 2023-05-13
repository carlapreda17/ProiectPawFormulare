using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPawFormulare
{
    [Serializable]
    public class Magazin
    {
        private string nume_magazin;
        private string adresa;
        private List<Raion> listaRaioane;
        private List<Tranzactii> listaTranzactii;

        public string Nume_magazin { get => nume_magazin; set => nume_magazin = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public List<Raion> ListaRaioane
        {
            get => listaRaioane;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Lista de raioane nu poate fi null.");
                }

                listaRaioane = value;
            }
        }
        internal List<Tranzactii> ListaTranzactii
        {
            get => listaTranzactii;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Lista de raioane nu poate fi null.");
                }

                listaTranzactii = value;
            }
        }



        public Magazin()
        {
            this.adresa = "Penes Curcanul 16-18";
            this.nume_magazin = "Candyland";
            listaRaioane = new List<Raion>();
            listaTranzactii = new List<Tranzactii>();

            Raion r1 = new Raion();
            r1.Nume_raion = "ciocolata";

            Raion r2 = new Raion();
            r2.Nume_raion = "bomboane";

            Raion r3 = new Raion();
            r3.Nume_raion = "jeleuri";

            Raion r4 = new Raion();
            r4.Nume_raion = "biscuiti";

            this.AdaugaRaion(r1);
            this.AdaugaRaion(r2);
            this.AdaugaRaion(r3);
            this.AdaugaRaion(r4);
        }

        public Magazin(string nume, string adresa, List<Raion> listaR, List<Tranzactii> listaT)
        {
            this.adresa = adresa;
            this.nume_magazin = nume;
            List<Raion> listaNouaR = new List<Raion>();
            foreach (Raion r in listaR)
                listaNouaR.Add(r);
            listaRaioane.AddRange(listaNouaR);

            List<Tranzactii> listaNouaT = new List<Tranzactii>();
            foreach (Tranzactii t in listaT)
                listaNouaT.Add(t);
            listaTranzactii.AddRange(listaNouaT);



        }

        public override string ToString()
        {
            string rezultat = "Magazinul de dulciuri " + nume_magazin + " de pe strada " + adresa + " are urmatoarele raioane: " + Environment.NewLine;
           

            foreach (Raion r in listaRaioane)
            {
                rezultat += r.ToString() + Environment.NewLine;
            }
            foreach (Tranzactii t in listaTranzactii)
            {
                rezultat += t.ToString() + Environment.NewLine;

            }
            return rezultat;
        }

        public void AdaugaRaion(Raion raion)
        {
            listaRaioane.Add(raion);
        }

        public void StergeRaion(Raion raion)
        {
            listaRaioane.Remove(raion);
        }

        public void AdaugaTranzactie(Tranzactii tranzactie)
        {
            listaTranzactii.Add(tranzactie);
            for (int j = 0; j < listaRaioane.Count; j++)
            {
                var raion = listaRaioane[j];
                for (int i = 0; i < raion.ListaProduse.Count; i++)
                {
                    var produs = raion.ListaProduse[i];
                    if (tranzactie.Cod == produs.CodProdus)
                    {
                        tranzactie.CalculeazaCostFinal(produs.Pret);
                        if (tranzactie.Cantitate_produs <= produs.Cantitate)
                        {
                          //  listaRaioane[j].ListaProduse[i] = new Produs(produs.CodProdus,produs. produs.Item2 - tranzactie.Cantitate_produs);
                            produs.Cantitate = produs.Cantitate-tranzactie.Cantitate_produs;

                        }
                        else if (tranzactie.Cantitate_produs == produs.Cantitate)
                        {
                            //raion.ListaProduse.RemoveAt(i);
                            listaRaioane[j] -= produs;

                        }
                        else
                        {
                            Console.WriteLine("produs invalid");
                        }

                        break;
                    }
                }
            }
        }








    }

}

