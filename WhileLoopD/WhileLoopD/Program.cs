using System;
/*
 * ist eine kopfgesteuerte schleife
 */
namespace WhileLoopD
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // deklaration | ganzzahl, bezeichner = variable 0
            string enteredText = ""; // überprüfen ob enteredText ein leerer String ist
            
            while (enteredText.Equals(""))// hier wird überprüft , ob der text der eingegeben wurde einen leeren text entspricht
            {
                Console.WriteLine("Bitte drücke Enter um, um eins hochzuzählen, oder gib etwas anderes ein, um die Zählung zu beenden");
                
                enteredText = Console.ReadLine();// Benutzereingabe
                Console.WriteLine("Aktuelle Anzahl der Schüler im Bus: {0}", counter);
                
                counter++;// Zählen hoch
            }
            Console.WriteLine("{0} Schüler sind im Bus. Es kann losgehen. Drücke Enter um loszufahren", counter);


            Console.ReadKey();
        }
    }
}
