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




            Console.ReadKey();
        }
    }
}
