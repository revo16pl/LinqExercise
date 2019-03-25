using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Polecenie 1 i 2
            Klient K1, K2, K3, K4;
            Initialize(out K1, out K2, out K3, out K4);

            var Klienci = new List<Klient>() { K1, K2, K3,K4 };

            var WybraniKlienci = Klienci.Where(klient => klient.Zamowienia.Any(zamowienie => zamowienie.DataZamowienia.Year >= 2018));

            WybraniKlienci.ToList().ForEach(klient => Console.WriteLine(klient.NazwaKlienta));


            //Polecenie 3

            string RunnerTimes = "00:45,01:32,02:18,03:01,03:44,04:31,05:19,06:01,06:47,07:35";

            int NumberOfLaps = RunnerTimes.Count(x => x == ':');

            Console.WriteLine(NumberOfLaps);
            Console.ReadKey();
            
        }

        private static void Initialize(out Klient K1, out Klient K2, out Klient K3, out Klient K4)
        {
            List<Zamowienie> listaZamowiienK1 = new List<Zamowienie>();
            listaZamowiienK1.Add(new Zamowienie(110, new DateTime(2019,1,1)));
            listaZamowiienK1.Add(new Zamowienie(120, new DateTime(2019, 1, 1)));


            List<Zamowienie> listaZamowiienK2 = new List<Zamowienie>();
            listaZamowiienK2.Add(new Zamowienie(130, new DateTime(2017, 1, 1)));


            List<Zamowienie> listaZamowiienK3 = new List<Zamowienie>();
            listaZamowiienK3.Add(new Zamowienie(140, new DateTime(2019, 1, 1)));


            List<Zamowienie> listaZamowiienK4 = new List<Zamowienie>();
            listaZamowiienK4.Add(new Zamowienie(150, new DateTime(2015, 1, 1)));
            listaZamowiienK4.Add(new Zamowienie(160, new DateTime(2017, 1, 1)));


            K1 = new Klient(1, "Klient01", listaZamowiienK1);
            K2 = new Klient(2, "Klient02", listaZamowiienK2);
            K3 = new Klient(3, "Klient03", listaZamowiienK3);
            K4 = new Klient(4, "Klient04", listaZamowiienK4);
        }
    }
}
