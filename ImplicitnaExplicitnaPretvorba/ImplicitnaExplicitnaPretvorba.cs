using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Provjeriti koja sučelja implementira klasa System.Collections.Queue

            Queue<string> red = new Queue<string>(new string[] { "Mirko", "Slavko", "Jure" });
            // referiranjem na 'red' možemo dohvatiti bilo koji 
            // član iz tipa Queue ili iz baznog tipa System.Object

            // Napisati naredbu koja će pomoću metode Queue<T>.Enqueue() dodati još jedan element u 'red' 

            red.Enqueue("Pero");

            // Pridružiti objekt 'red' varijabli 'obilaziv' tipa IEnumerable<string> te ispisati sve elemete pozivom metode IspišiSveElemente():
            // IEnumerable<string> obilaziv = ...;

            IEnumerable<string> obilaziv = red;
            IspišiSveElemente(obilaziv);

            // Pridružiti objekt 'obilaziv' varijabli 'kolekcija' tipa ICollection koristeći eksplicitnu pretvorbu. Provjeriti da li se kod ispravno izvodi tako da se na objektu tipa 'kolekcija' dohvati svojstvo 'Count' i ispiše broj članova:
            // ICollection kolekcija = obilaziv;

            ICollection kolekcija = (ICollection)obilaziv;
            Console.WriteLine(kolekcija.Count);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        static void IspišiSveElemente<T>(IEnumerable<T> elementi)
        {
            foreach (var e in elementi)
            {
                Console.WriteLine(e);
            }
        }
    }
}
