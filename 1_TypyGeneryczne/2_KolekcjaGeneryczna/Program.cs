using System;
using System.Collections.Generic;

namespace _2_KolekcjaGeneryczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik[] pracownicy = new Pracownik[]
            {
                new Pracownik {Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik {Imie = "Jan", Nazwisko = "Kowalski"},
                new Pracownik {Imie = "Magda", Nazwisko = "Kowalska"}
            };
            foreach (var item in pracownicy)
            {
                Console.WriteLine(item.Imie + " " + item.Nazwisko);
            }
            for (int i = 0; i < pracownicy.Length; i++)
            {
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }
            Array.Resize(ref pracownicy, 10);
            pracownicy[9] = new Pracownik { Imie = "Anatol", Nazwisko = " Jakiś" };
            Console.ReadKey();
        }
    }
}
