namespace Pujcovna_Automobilu
{
    internal class zakaznik
    {
        public List<Zakaznicek> zakaznici; 
        public zakaznik()
        {
            zakaznici = new List<Zakaznicek>();
        }
        public void PridatZakaznika()
        {
            Console.WriteLine("Přijel nový zákazník");  //zadavani noveho zakaznika
            Console.WriteLine("Jméno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Příjmení: ");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Věk: ");
            int vek = int.Parse(Console.ReadLine());
            while (vek < 18)
            {
                Console.WriteLine("Nemůžeš si půjčit auto jsi moc mladý!");
                Console.WriteLine("Zadej věk znova: ");
                vek = int.Parse(Console.ReadLine()); //nemuze si pujcit auto kdyz je pod 18
            }

            Zakaznicek zakaznik = new Zakaznicek(jmeno, prijmeni, vek);
            zakaznici.Add(zakaznik);
        }
        public void VypisZakazniku() // vypise seznam
        {
            Console.WriteLine("Výpis zákazníčků: ");
            foreach (Zakaznicek zakaznik in zakaznici)
            {
                zakaznik.VypisPole();
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void OdebratZakaznika() //muzeme odebrat zakaznika
        {
            Console.WriteLine("Kterého zakazníka chceš odebrat");
            for (int i = 0; i < zakaznici.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, zakaznici[i].Jmeno);
            }
            Console.Write("Poradove cislo pro smazani: ");
            int indexSmazat = int.Parse(Console.ReadLine());
            indexSmazat--;
            if (indexSmazat >= 0 && indexSmazat < zakaznici.Count)
            {
                Console.WriteLine("Zakazník: {0} smazán", zakaznici[indexSmazat].Prijmeni);
                zakaznici.RemoveAt(indexSmazat);
            }
            else
            {
                Console.WriteLine("spatne cislo ty blbecku");
            }
        }
        public void UpravitZakaznika() //uprava udaju
        {
            Console.WriteLine("UPRAVA Udaju");
            int indexUpravit = VybratIndex();
            if (indexUpravit >= 0)
            {
                Zakaznicek zakaznicek = zakaznici[indexUpravit];
                Console.WriteLine("Aktualni jméno: {0}\n Chcete upravit? A/N", zakaznicek.Jmeno);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nové jméno: ");
                    zakaznicek.Jmeno = Console.ReadLine();
                }
                Console.WriteLine("Aktualni příjmení: {0}\n Chcete upravit? A/N", zakaznicek.Prijmeni);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nové příjmení: ");
                    zakaznicek.Prijmeni = Console.ReadLine();
                }
                Console.WriteLine("Aktualni věk: {0}\n Chcete upravit? A/N", zakaznicek.Vek);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nový věk: ");
                    zakaznicek.Vek = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Uprava dokoncena");
                Console.Clear();
            }
        }

        private int VybratIndex() //metoda na to abych mohl vybrat auto pro upravu
        {
            for (int i = 0; i < zakaznici.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, zakaznici[i].Jmeno);
            }
            Console.Write("Poradove cislo pro upravu: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < zakaznici.Count)
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
