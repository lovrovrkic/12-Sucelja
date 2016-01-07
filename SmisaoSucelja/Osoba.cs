using System;

namespace Vsite.CSharp
{
    class Osoba
    {
        public Osoba(string ime, string prezime, DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRodjenja;


    }
}
