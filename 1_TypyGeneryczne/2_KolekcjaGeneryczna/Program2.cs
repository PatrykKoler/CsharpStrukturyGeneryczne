using System;
using System.Collections.Generic;

namespace _2_KolekcjaGeneryczna
{
    class Program2
    {
        static void Main(string[] args)
        {
            Queue<Pracownik> Kolejka = new Queue<Pracownik>();
            Kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            Kolejka.Enqueue(new Pracownik { Imie = "Magda", Nazwisko = "Kowalska" });
            Kolejka.Enqueue(new Pracownik { Imie = "Ala", Nazwisko = "Zajac" });
            Kolejka.Enqueue(new Pracownik { Imie = "Marek", Nazwisko = "Paweł" });

            while (Kolejka.Count > 0 )
            {
                var pracownik = Kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
            
        }
    }
}
