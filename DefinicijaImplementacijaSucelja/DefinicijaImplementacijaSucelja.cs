using System;

namespace Vsite.CSharp
{
    // definicija sučelja:
    interface IMojeSučelje
    {
        // deklaracija (samo potpis) metode:
        void MojaMetoda(int argument);
        // deklaracija svojstva:
        string Svojstvo { get; }
        // deklaracija indeksera:
        string this[int indeks] { get; }
        // deklaracija dogadjaja:
        event MojDelegat MojDogađaj;
    }

    // deklaracija delegata
    delegate void MojDelegat(object sender, EventArgs e);


    // TODO: Napišite kod klase Implementacija tako da implementira sučelje IMojeSučelje. 
    // TODO: Implementirajte kod za Svojstvo i indekser tako da vraćaju neki tekst
    class Implementacija : IMojeSučelje
    {
        #region IMojeSučelje Members

        public void MojaMetoda(int argument)
        {
            throw new NotImplementedException();
        }
        public string Svojstvo
        {
            get { return "svojstvo"; }
        }
        public string Indekser
        {
            get { return "indekser"; }
        }
        public event MojDelegat{ }
     
    }

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Inicijalizirajte objekt ms instancom objekta Implementacija i provjerite što će se ispisati izvođenjem koda
            IMojeSučelje ms = null;

            IspišiSvojstvo(ms);
            IspišiIndekser(ms);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        // metode kao argument ne primaju konkretne tipove nego sučelja! 
        static void IspišiSvojstvo(IMojeSučelje ms)
        {
            Console.WriteLine(ms.Svojstvo);
        }

        static void IspišiIndekser(IMojeSučelje ms)
        {
            Console.WriteLine(ms[1]);
        }
    }
}
