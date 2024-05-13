using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pujcovna_Automobilu
{
    internal class Pujcka
    {
        public Auto Auto;

        public Zakaznicek Zakaznik;
        public int PocetDni { get; set; }
        public int PricePerDay { get; set; }
        public Pujcka(Auto auto, Zakaznicek zakaznik, int pocetDni, int priceperday)
        {
            Auto = auto;
            Zakaznik = zakaznik;
            PocetDni = pocetDni;
            PricePerDay = priceperday;
        }
    }
}