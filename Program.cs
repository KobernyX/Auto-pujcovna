namespace Pujcovna_Automobilu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            auticko auto = new auticko(); // propojeí class
            zakaznik zakaznik = new zakaznik();
            Pujcicka pujcicka = new Pujcicka(auto.auticka, zakaznik.zakaznici);

            string volbaMenu;
            do
            {
                // Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkYellow;   // text hl. m.
                Console.WriteLine("|-HLAVNÍ-MENU-|");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Vyber jednu z možností: ");
                Console.WriteLine("1. Pridat Auto");
                Console.WriteLine("2. Vypsat Auta");
                Console.WriteLine("3. Odebrat Auto");
                Console.WriteLine("4. Upravit Auto");
                Console.WriteLine("5. Pridat Zákazníka");
                Console.WriteLine("6. Vypsat Zákazníky");
                Console.WriteLine("7. Odebrat Zákazníka");
                Console.WriteLine("8. Upravit zákazníka");
                Console.WriteLine("9. Udělat půjčku");
                Console.WriteLine("10. Vypsat seznam půjček");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Pro ukončení Pprogramu napiš");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" konec");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                volbaMenu = Console.ReadLine();
                Console.Clear();

                switch (volbaMenu)   //volite si možnost
                {
                    case "1":
                        auto.PridatAuto();
                        break;
                    case "2":
                        auto.VypisAut();
                        break;
                    case "3":
                        auto.SmazatAuto();
                        break;
                    case "4":
                        auto.UpravitAuto();
                        break;
                    case "5":
                        zakaznik.PridatZakaznika();
                        break;
                    case "6":
                        zakaznik.VypisZakazniku();
                        break;
                    case "7":
                        zakaznik.OdebratZakaznika();
                        break;
                    case "8":
                        zakaznik.UpravitZakaznika();
                        break;
                    case "9":
                        if (pujcicka.MuzuUdelatPujcku() == true)
                        {
                            pujcicka.UdelatPujcku();
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "10":
                        pujcicka.SeznamPujcek();
                        break;

                }
            } while (volbaMenu != "konec");
            /*1. Funkcni aplikace
             2. Pristup na Github - full kod s komentarema
            3. kratka dokumentace
              - popis trid a metod
              - vyuziti get, set; private, public
              - celkovy popis funkci aplikace*/
        }
    }
}
