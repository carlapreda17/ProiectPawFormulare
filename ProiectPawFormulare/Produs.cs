﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPawFormulare
{
    [Serializable]
        public class Produs:IComparable
        {
        private int codProdus;
        private float pret;
        string nume;
        string tip;

        public int CodProdus { get => codProdus; set => codProdus = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Tip { get => tip; set => tip = value; }
        public float Pret { get => pret; set => pret = value; }

        public Produs()
        {
            codProdus = 0;
            tip = " ";
            nume = " ";
            pret = 0.0f;
                
        }

        public Produs(int codProdus,string nume,string tip,float pret)
        {
            this.codProdus = codProdus;
            this.nume = nume;       
            this.tip = tip;
            this.pret = pret;   
        }
        public override string ToString()
        {
            return "Numele produsului este " + nume + ", de tip " + tip + ", cod: " + codProdus+", are pretul de "+pret+" lei";
        }

        public int CompareTo(object obj)
        {
            Produs p=(Produs)obj;
            if (codProdus == p.codProdus)
                return -1;
            else
                return string.Compare(tip, p.tip);
        }
    }
}
