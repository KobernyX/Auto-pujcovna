namespace Pujcovna_Automobilu
{
    internal class Zakaznicek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public Zakaznicek(string jmeno, string prijmeni, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
        }
        public void VypisPole()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Jmeno: {0}", Jmeno);
            Console.WriteLine("Příjmení: {0}", Prijmeni);
            Console.WriteLine("Věk: {0}", Vek);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /*identifikace id, jmeno prijmeni, datum narozeni (pujcit auto jen s opravnenim)
         kontakt*/

        //Metody: Konstruktor
    }
}
