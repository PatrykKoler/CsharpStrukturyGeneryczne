using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjaGeneryczna
{
    public class kolejkaKolowa
    {
        private double[] bufor;
        private int poczatek;
        private int koniec;

        public kolejkaKolowa() :this(pojemnosc: 5)  
        {

        }
        public kolejkaKolowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            poczatek = 0;
            koniec = 0;
        }
        public void zapisz(double wartosc)
        {
            bufor[koniec] = wartosc;
            koniec = (koniec + 1) % bufor.Length;
            if (koniec == poczatek)
            {
                poczatek = poczatek + 1 % bufor.Length;
            }
        }
        public double czytaj()
        {
             var wynik = bufor[poczatek];
             poczatek = poczatek + 1 % bufor.Length;
             return wynik;
        }
        public int Pojemosc
        {
            get
            {
                return bufor.Length;
            }  
        }
        public bool JestPusty
        {
            get
            {
                return koniec == poczatek;
            }
        }
        public bool jestPelny
        {
            get
            {
                return (koniec + 1) % bufor.Length == poczatek;
            }
        }

        
    }
}
