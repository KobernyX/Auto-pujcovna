namespace Pujcovna_Automobilu
{
    internal class Auto
    {
        public StavAuta stavAuta = StavAuta.Volny;
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NajetoKm { get; set; }


        public Auto(string brand, string model, int najetokm)
        {
            Brand = brand;
            Model = model;
            NajetoKm = najetokm;
        }
        public void VypisPole()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Značka: {0}", Brand);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Najeto km: {0}", NajetoKm);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /*identifikace vozidla (vin), spz, vyrobce, model, rok vyroby, cena za den,
        dostupnost, stav tachometru (pocet mist)*/

        //Metody: Zmena stavu, vypocet ceny, konstruktor tridy

    }
}
