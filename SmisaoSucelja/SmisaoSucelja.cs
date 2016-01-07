using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Osoba> popisOsoba = new List<Osoba>();

            popisOsoba.Add(new Osoba("Ana", "Ani?", new DateTime(1975, 7, 12)));
            popisOsoba.Add(new Osoba("�arko", "�arki?", new DateTime(1965, 12, 4)));
            popisOsoba.Add(new Osoba("Marko", "Marki?", new DateTime(1983, 4, 2)));

            Console.WriteLine("Ispis prije sortiranja:");
            Ispi�i(popisOsoba);
            Console.WriteLine();

            Console.WriteLine("Sortiramo po ne�emu:");
            popisOsoba.Sort();
            Ispi�i(popisOsoba);
            Console.WriteLine();

            Console.WriteLine("Sortiramo po imenu:");
            // List<T>.Sort(IComparer<T>)
            popisOsoba.Sort(new UsporedbaPoImenu());
            Ispi�i(popisOsoba);

            Console.WriteLine();

            Console.WriteLine("Sortiramo po datumu rodjenja:");
            popisOsoba.Sort((Osoba a, Osoba b) =>
            {
                int rezultat = a.Prezime.CompareTo(b.Prezime);
                if (rezultat != 0)
                    return rezultat;
                rezultat = a.Ime.CompareTo(b.Ime);
                if (rezultat != 0)
                    return rezultat;
                return a.DatumRodjenja.CompareTo(b.DatumRodjenja);
            }
            );
            Ispi�i(popisOsoba);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

        }

        static void Ispi�i(List<Osoba> list)
        {
            foreach (Osoba o in list)
            {
                Console.WriteLine("{0}, {1:d}", o.Ime, o.DatumRodjenja);
            }
        }
    }
}
