using System;

namespace BreakUndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variante 1
            for (int counter = 0; counter < 10; counter++)
            {

                if (counter % 2 == 0)
                {
                    Console.WriteLine("Als nächstes kommt eine ungerade Zahl");
                    continue;
                }

                Console.WriteLine(counter);
            }

            // Variante 2 | es wird von null hoch adiert +1 bis kleiner 10
            for (int counter = 0;counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter  == 3) // aber wenn das ergebnis gleich 3 ist wird abgebrochen
                {
                    Console.WriteLine("Bei drei machen wir schluss!");
                    break;
                }
                
            }

            Console.ReadKey();
        }
    }
}
