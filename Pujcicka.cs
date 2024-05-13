using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Pujcovna_Automobilu
{
    internal class Pujcicka
    {
        List<Pujcka> pujcky = new List<Pujcka>();

        List<Auto> ListAuticka;

        List<Zakaznicek> ListZakaznici;

        public Pujcicka(List<Auto> listAuticka, List<Zakaznicek> listZakaznik)
        {
            ListAuticka = listAuticka;
            ListZakaznici = listZakaznik;
        }
        public void UdelatPujcku()  // nakolik dni a penizky na den
        {
            int zakaznikIndex = VybratZakaznika();
            Zakaznicek zakaznicek = ListZakaznici.ElementAt(zakaznikIndex);
            Auto auto = VybratAuto();
            Console.WriteLine("Na kolik dní si chce auto pujcit: ");
            int pocetDni = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte cenu půjčky za den: ");
            int priceperday = int.Parse(Console.ReadLine());
            pujcky.Add(new Pujcka(auto, zakaznicek, pocetDni, priceperday));
            Console.Clear();
        }
        public void SeznamPujcek() // udela seznam pujcek a dluzniku :)
        {
            foreach (Pujcka pujcka in pujcky)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(pujcka.Zakaznik.Jmeno + " - " + pujcka.Auto.Brand + " - Počet dní: " + pujcka.PocetDni + " - Celková cena: " + (pujcka.PocetDni * pujcka.PricePerDay + "Kč"));
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
            Console.Clear();
        }
        private int VybratZakaznika() //metoda pro vybrani zakaznika ktery mi chce dat svoje penize :)
        {
            for (int i = 0; i < ListZakaznici.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, ListZakaznici[i].Jmeno);
            }
            Console.Write("Vyber zakaznika: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < ListZakaznici.Count)
            {
                return index;
            }
            else
            {
                Console.WriteLine("Spatne poradove cislo!");
                return -1;
            }
        }
        private Auto VybratAuto() //vybrat aauto ktere dam zakaznickovi :(
        {
            for (int i = 0; i < ListAuticka.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}", i + 1, ListAuticka[i].Brand, ListAuticka[i].stavAuta);

            }
            Console.Write("Vyber Auto: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            while (ListAuticka.ElementAt(index).stavAuta == StavAuta.Zabrany && Console.ReadLine() != "zpet")
            {
                index = int.Parse(Console.ReadLine()) - 1;
            }
            if (index >= 0 && index < ListAuticka.Count)
            {
                ListAuticka.ElementAt(index).stavAuta = StavAuta.Zabrany;
                return ListAuticka.ElementAt(index);
            }
            else
            {
                Console.WriteLine("Spatne poradove cislo!");
                return ListAuticka.ElementAt(0);
            }
        }
        public bool MuzuUdelatPujcku() // jestli muzu tak me to pusti gg jinak pridat nekoho dalsiho
        {      
                for (int i = 0; i < ListAuticka.Count; i++)
                {
                     if (ListAuticka[i].stavAuta == StavAuta.Volny)
                     {
                        return true;
                     }
                }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Neni co nebo komu pujcovat :(");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            return false;
        }
        /*Auto- reference na objekt
                 Zakaznik - ref na zakaznika
               */
        //metody Konstruktor, vypocet pujcky (poriz cena auta/ 1500
    }

}
