namespace Pujcovna_Automobilu
{

    internal class auticko
    {
        public List<Auto> auticka; 
        public auticko()
        {
            auticka = new List<Auto>();
        }
        public void PridatAuto() // pridej auto jupiii
        {
            Console.WriteLine("Zadavas nové auto");
            Console.WriteLine("Značka: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Kolik má najeto: ");
            int najetokm = int.Parse(Console.ReadLine());
            
            Auto auto = new Auto(brand, model, najetokm);
            auticka.Add(auto);
            Console.Clear();
        }
        public void VypisAut()  //vypis seznam aut
        {
            Console.WriteLine("Výpis auťáků: ");
            foreach (Auto auto in auticka)
            {
                auto.VypisPole();
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void SmazatAuto() //neni auto :(
        {
            Console.WriteLine("Které auto chceš odebrat");
            for (int i = 0; i < auticka.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, auticka[i].Brand);
            }
            Console.Write("Poradove cislo pro smazani: ");
            int indexSmazat = int.Parse(Console.ReadLine());
            indexSmazat--;
            if (indexSmazat >= 0 && indexSmazat < auticka.Count)
            {
                Console.WriteLine("Auto: {0} smazano", auticka[indexSmazat].Brand);
                auticka.RemoveAt(indexSmazat);
            }
            else
            {
                Console.WriteLine("spatne cislo ty blbecku");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void UpravitAuto() //upravim udaje mych žiguliku
        {
            Console.WriteLine("UPRAVA Udaju");
            int indexUpravit = VybratIndex();
            if (indexUpravit >= 0)
            {
                Auto auto = auticka[indexUpravit];
                Console.WriteLine("Aktualni značka: {0}\n Chcete upravit? A/N", auto.Brand);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nová značka: ");
                    auto.Brand = Console.ReadLine();
                }
                Console.WriteLine("Aktualni model: {0}\n Chcete upravit? A/N", auto.Model);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nový model: ");
                    auto.Model = Console.ReadLine();
                }
                Console.WriteLine("Aktualni stav tachometru: {0}\n Chcete upravit? A/N", auto.NajetoKm);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nový stav tachometru: ");
                    auto.NajetoKm = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Uprava dokoncena");
                Console.Clear();
            }
        }

        private int VybratIndex() //metoda na to abych mohl vybrat zakaznika pro upravu
        {
            for (int i = 0; i < auticka.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, auticka[i].Brand);
            }
            Console.Write("Poradove cislo pro upravu: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < auticka.Count)
            {
                return index;
            }
            else
            {
                Console.WriteLine("Spatne poradove cislo!");
                return -1;
            }
        }

    }
}
