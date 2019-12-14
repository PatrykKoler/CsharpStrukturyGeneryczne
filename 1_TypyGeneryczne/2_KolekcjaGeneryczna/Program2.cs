using System;
using System.Collections.Generic;

namespace _2_KolekcjaGeneryczna
{
    class Program2
    {
        static void Main(string[] args)
        {
            var liczby = new List<double>();
            var pojemosc = -1;
            while (true)
            {
                if (liczby.Capacity != pojemosc)
                {
                    pojemosc = liczby.Capacity;
                    Console.WriteLine(pojemosc);
                }
                liczby.Add(1);
            }
        }
    }
}
