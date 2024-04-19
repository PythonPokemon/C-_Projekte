using System;

namespace DoWhileSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            int längeText = 0;
            string leererText = "";
            // es wird geprüft ob die länge des Textes alsoder Name der Freunde der angegebn wird
            // oder der wert noch insgesamt kleiner 20 ist, sobald es die 20 erreicht endet die schleife
            do
            {
                Console.WriteLine("Bitte trage den Namen eines Freundes ein");
                string nameFreund = Console.ReadLine();
                int aktuelleLänge = nameFreund.Length;
                längeText += aktuelleLänge;
                leererText += nameFreund;
            } while (längeText < 20);
            Console.WriteLine("Danke, das reicht! Deine Freunde sind {0}", leererText);

            // Übungsschleife: addirt von 0 plus +1 bis 10.000 
            Console.WriteLine("\nÜbungsschleife:");
            int counter = 0;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 10000);

            Console.Read();
        }
    }
}
