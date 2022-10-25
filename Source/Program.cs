namespace Malovani
{
    internal class Program
    {
        struct PoziceKurzoru
        {
            public int X;
            public int Y;
        }

        static void Main(string[] args)
        {

            NastaveniBarev();
            Uvod();

            char[,] obrazek = ZiskatObrazek();
            //char[,] obrazek = new char[2, 4] { { 'A', 'H', 'O', 'J' }, { 'J', 'O', 'H', 'A' } };
            PoziceKurzoru kurzor = new PoziceKurzoru() { X = 0, Y = 0 };



            bool konec;
            do
            {
                Vykresleni(kurzor, obrazek);

                ConsoleKeyInfo novaKlavesa = Console.ReadKey();

                VlivOvladaniNaObrazek(novaKlavesa, obrazek);
                kurzor = VlivOvladaniNaKurzor(novaKlavesa);
                konec = ZnaciKonec(novaKlavesa);
            } while (!konec);

            UlozeniObrazku(obrazek);
            Rozlouceni();
        }

        static void UlozeniObrazku(char[,] obrazek)
        {
            throw new NotImplementedException();
        }

        static bool ZnaciKonec(ConsoleKeyInfo novaKlavesa)
        {
            throw new NotImplementedException();
        }

        static void VlivOvladaniNaObrazek(ConsoleKeyInfo novaKlavesa, char[,] obrazek)
        {
            throw new NotImplementedException();
        }

        static PoziceKurzoru VlivOvladaniNaKurzor(ConsoleKeyInfo novaKlavesa)
        {
            throw new NotImplementedException();
        }

        static void Vykresleni(PoziceKurzoru kurzor, char[,] obrazek)
        {
            int prevY = 0;

            for(int y = 0; y < obrazek.GetLength(0); y++)
            {
                for (int x = 0; x < obrazek.GetLength(1); x++)
                {
                    if (prevY != y)
                        Console.WriteLine("");
                        prevY = y;

                    if (kurzor.Y == y && kurzor.X == x)
                    {
                        Console.SetCursorPosition(kurzor.X, kurzor.Y);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(obrazek[y, x]);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else Console.Write(obrazek[y, x]);
                }
            }
        }

        static char[,] ZiskatObrazek()
        {
            Console.WriteLine("Napište číslo funkce, kterou chcete zvolit.");
            Console.WriteLine("1) Tvorba nového obrázku.");
            Console.WriteLine("2) Otevření existujícího obrázku.");
            Console.WriteLine("3) Ukončení aplikace.");
            Console.WriteLine("");

            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.NumPad1)
            {
               // Defaultni rozmery console 120 x 30 znaku
               Console.WriteLine("Maximální šířka obrázku je 30");
               Console.WriteLine("Zde zadejte šířku obrázku: ");
               // získání šířky
               string input_width = Console.ReadLine();
               int width = Convert.ToInt32(input_width);
               if (width > 120)
               {
                    Console.WriteLine("Zadaná šířka je větší než maximální");
                    Console.WriteLine("Šířka bude 30");
                    width = 120;
               }
                Console.WriteLine();
                Console.WriteLine("Maximální výška obrázku je 120");
                Console.WriteLine("Zde zadejte výšku obrázku: ");
                // získání výšky
                string input_length = Console.ReadLine();
                int length = Convert.ToInt32(input_length);
                if (length > 30)
                {
                    Console.WriteLine("Zadaná výška je větší než maximální");
                    Console.WriteLine("výška bude 120");
                    length = 30;
                }

                char[,] obrazek;
                obrazek = new char[length, width];

                for (int x = 0; x < obrazek.GetLength(0); x++)
                {
                    for (int y = 0; y < obrazek.GetLength(1); y++)
                    {
                        obrazek[y, x] = ' ';
                    }
                }
                
                return obrazek;

            }

            if (key == ConsoleKey.NumPad2)
            {
               //NacteniObrazku();
                Console.WriteLine("Zmáčkli jste 2");
            }

            if (key == ConsoleKey.NumPad3)
            {
                System.Environment.Exit(0);
            }

            if (key != ConsoleKey.NumPad1 && key !=  ConsoleKey.NumPad2 && key != ConsoleKey.NumPad3)
            {
                Console.WriteLine("Neplatná hodnota");
                Console.WriteLine("");
                ZiskatObrazek();
            }

            throw new NotImplementedException();
        }

        static void NastaveniBarev()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }

        static void Uvod()
        {
            Console.Clear();
            Console.WriteLine("ASCII Malování");
            Console.WriteLine("--------------");
            Console.WriteLine();

            Console.WriteLine("Pro spuštění stiskněte libovolnou klávesu...");
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.Clear();
        }

        static void Rozlouceni()
        {
            Console.Clear();
            Console.WriteLine("Děkujeme za použití naší aplikace!");
            Console.WriteLine();

            Console.WriteLine("Pro ukončení stiskněte libovolnou klávesu...");
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.Clear();
        }
    }
}
