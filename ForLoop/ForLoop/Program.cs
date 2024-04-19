using System;

namespace ForLoop
    /* Mit einer for schleife kann man mehrfach code ausführen der sich unterscheidet
     */
{
    class Program
    {
        static void Main(string[] args)

            // Variante 1
            // der zähler wird mit 1 deklariert | zähler kleiner 20 | zähler soll +2 addiert werden
        {
            for (int zaehler = 1; zaehler < 20; zaehler +=2 )
            {
                Console.WriteLine("Zählerwert ist {0}", zaehler); // gibt in der Konsole string & int aus
            }
            // bedeutet es wird solange hochgerächnet +2 solnage zähler kleine 20 ist = bis 19


            // Variante 2
            for (int zaehler = 1000; zaehler > 0; zaehler -= 1)
            {
                Console.WriteLine("Zählerwert ist {0}", zaehler); // gibt in der Konsole string & int aus
            }


            Console.ReadKey();
        }
    }
}
