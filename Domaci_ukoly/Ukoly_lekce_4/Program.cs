namespace Ukoly_lekce_4
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ukoly z lekce4!");

            //1) Pomocí cyklu vypiš 3x nějakou stejnou zprávu
           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ahoj, přeji Ti krásný den a samé šikovné studenty");
            }

            //2) Pomocí cyklu vypiš čísla 5 až 1 sestupně.
            
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }


            //3) Napiš program, který si bude myslet náhodné číslo od 0 do 10 a uživatel bude moci až 3x hádat.
            //Pokud uhodne, program skončí dříve a vypíše, že číslo uhodl správně.
            //Pro generování náhodného čísla lze použít
            //            Random generator = new Random();
            //            int nahodneCislo = generator.Next(11);

            
            Random generator = new Random();
            int nahodneCislo = generator.Next(11);
            Console.WriteLine("Myslím si přirozené číslo, zkus ho uhádnout. Máš na to tři pokusy.");
                                            
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"tvůj {i}. tip:");
                string zadanyTipUzivatele = Console.ReadLine();
                int tipUzivatele = int.Parse(zadanyTipUzivatele);                             
                
                if (nahodneCislo == tipUzivatele)
                {
                    Console.WriteLine($"výborně, uhádl jsi na {i}. pokus");
                    break;
                }
                Console.WriteLine("bohužel jsi neuhádl");
            }


            //4) Zobrazte trojúhelník z hvězdiček(budete muset použít cyklus v cyklu)

           
                        Console.WriteLine("zadej počet pater:");
                        string zadanyPocetPater = Console.ReadLine();
                        int pocetPater = int.Parse(zadanyPocetPater);


                        for (int i = 1; i <= pocetPater; i++)
                        {
                            int pocetHvezdicek = i;

                            for (int j = 1; j <= pocetHvezdicek; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();

                        }


            // 5) Vypočti faktoriál uživatelem zadaného čísla.
            // Uživatel zadá kladné celé číslo. Nemusíš dělat žádnou validaci vstupu.
            // Spočti faktoriál tohoto čísla podle následujícího vzorce.

            // 5! = 1 * 2 * 3 * 4 * 5 = 120
            // 4! = 1 * 2 * 3 * 4 = 24
            // 3! = 1 * 2 * 3 = 6
            // 2! = 1 * 2 = 2
            // 1! = 1
            // 0! = 1 Pozor faktoriál 0 se rovná 1

            // ## BONUS: Zkus bez použití podmínek. Použij pouze for cyklus.

            
              Console.WriteLine("zadej číslo pro výpočet faktoriálu");

              string zadaneCislo = Console.ReadLine();
              int cislo = int.Parse(zadaneCislo);

              int faktorial = 1;

              for (int i = 1; i <= cislo; i++)
              {

                  faktorial = faktorial * i;

              }
              Console.WriteLine($"Faktoriál čísla {cislo} je {faktorial}");


            // 6) Najdi největší uživatelem zadané číslo.

            // Načítej od uživatele čísla v cyklu, tak dlouho dokud nezadá 0.
            // Po tom co zadá 0 skončí cyklus a vypiš největší číslo, které zadal.
            // Poslední zadanou 0 nepočítej do zadaných čísel.
            // Pokud zadá -4, -2, -8, 0 tak výsledek bude -2
            // Pokud zadá 1, 2, 3, 4, 0 tak výsledek bude 4

            
            Console.WriteLine("zadávej postupně celá čísla, jakmile zadáš nulu, vyhodnotím největší z nich:");

            int cislo1 = int.MinValue;
            string zadaneCilso = Console.ReadLine();
            int cislo2 = int.Parse(zadaneCilso);

            if (cislo2 == 0)
            {
                Console.WriteLine("konec programu");
            }
            else
            {
                while (cislo2 != 0)
                {
                    cislo1 = Math.Max(cislo1, cislo2);
                    string dalsiZadaneCilso = Console.ReadLine();
                    cislo2 = int.Parse(dalsiZadaneCilso);
                }
                Console.WriteLine($"největší ze zadaných čísel je číclo {cislo1}.");
            }

            // 7) Vypiš čísla Fibonacciho posloupnosti.

            // Fibonacciho posloupnost, je nekonečná posloupnost čísel, která začíná čísly 1, 0. Každé další číslo je potom součet dvou předchozích.
            //         0
            //         1
            // 0 + 1 = 2
            // 1 + 2 = 3
            // 2 + 3 = 5
            // 3 + 5 = 8

            // Načti od uživatele int hodnotu, která reprezentuje množství čísel kolik se má z Fibbonacciho posloupnosti vypsat.
            // Uživatle zadá:
            //     0 - Nevypíše se nic.
            //     1 - Vypíše se 0
            //     4 - Vypíše se 0, 1, 1, 2

            // Vypisovat můžete buďto na řádek nebo pod sebe. Jak uznáte za vhodné.

            
             Console.WriteLine("zadej, kolik čísel Fibonacciho posloupnosti mám vypsat");

             string pozadovanyPocetCisel = Console.ReadLine();
             int pocetCiselFP = int.Parse(pozadovanyPocetCisel);

             int a = 0;

             int prvniCislo = 0;
             int druheCislo = 1;
             int dalsiCislo;

             while (true)
             {
                 Console.Write($"{prvniCislo} ");
                 dalsiCislo = prvniCislo + druheCislo;
                 prvniCislo = druheCislo;
                 druheCislo = dalsiCislo;
                 a++;

                 if(a==pocetCiselFP)
                 {
                     break;
                 }
             }
            
         






            Console.ReadLine();
            Console.WriteLine("konec programu");
        }
    }
}
      
       


               

