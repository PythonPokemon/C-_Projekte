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

                if (counter % 2 == 0) // wenn restwert gerate oder gleich 0, ist skipp zum nächten duzrchlauf
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

            // Variante 3 | es wird von null hoch adiert +1 bis kleiner 10
            for (int counter = 0; counter < 10; counter++)
            {
                
                if (counter == 3) // aber wenn das ergebnis gleich 3 ist wird übersprungen/fortgesetzt
                {
                    Console.WriteLine("Bei drei überspringen wir!");
                    continue;
                }
                Console.WriteLine(counter);
            }

            // Variante 4 | Durchschnittspunktzahl für den Lehrer

            int sum = 0;
            int count = 0;

            Console.WriteLine("Willkommen! Bitte geben Sie die Punktzahlen der Schüler ein.");
            Console.WriteLine("Geben Sie -1 ein, um die Eingabe zu beenden und den Durchschnitt zu berechnen.");

            while (true)
            {
                Console.Write("Punktzahl eingeben (zwischen 1 und 6): ");
                string input = Console.ReadLine();

                // Überprüfen, ob der Benutzer die Eingabe beendet hat
                if (input == "-1")
                {
                    break;
                }

                // Versuchen, die eingegebene Zeichenfolge in eine Zahl umzuwandeln
                if (int.TryParse(input, out int score))
                {
                    // Überprüfen, ob die Punktzahl im gültigen Bereich liegt
                    if (score >= 1 && score <= 6)
                    {
                        sum += score;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Punktzahl! Bitte geben Sie eine Zahl zwischen 1 und 6 ein.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine ganze Zahl ein.");
                }
            }

            // Überprüfen, ob mindestens eine Punktzahl eingegeben wurde
            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("Durchschnittliche Punktzahl der Schüler: " + average.ToString("0.00"));
            }
            else
            {
                Console.WriteLine("Keine gültigen Punktzahlen eingegeben.");
            }


            Console.ReadKey();
        }
    }
}
