using System;

namespace WhileLoopD
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            // überprüfen ob enteredText ein leerer String ist
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Bitte drücke Enter um, um eins hochzuzählen, oder gib etwas anderes ein, um die Zählung zu beenden");
                // Benutzereingabe
                enteredText = Console.ReadLine();
                Console.WriteLine("Aktuelle Anzahl der Schüler im Bus: {0}", counter);
                // Zählen hoch
                counter++;
            }
            Console.WriteLine("{0} Schüler sind im Bus. Es kann losgehen. Drücke Enter um loszufahren", counter);


            Console.ReadKey();
        }
    }
}
