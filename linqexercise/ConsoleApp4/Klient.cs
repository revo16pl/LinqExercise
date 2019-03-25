using System;
using System.Collections.Generic;

namespace LinqExercise
{
    public class Klient
    {
        public int IDKlienta { get; set; }
        public string NazwaKlienta { get; set; }
        public List<Zamowienie> Zamowienia { get; set; }

        public Klient(int iDKlienta, string nazwaKlienta, List<Zamowienie> zamowienie)
        {
            this.IDKlienta = iDKlienta;
            this.NazwaKlienta = nazwaKlienta;
            this.Zamowienia = zamowienie;
        }
    }

    public class Zamowienie
    {
        public DateTime DataZamowienia { get; set; }
        public decimal Kwota { get; set; }

        public Zamowienie(decimal kwota, DateTime dataZamowienia)
        {
            this.DataZamowienia = dataZamowienia;
            this.Kwota = kwota;
        }
    }
         
}
