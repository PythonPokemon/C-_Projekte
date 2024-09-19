using System;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unäre Operatoren
            num3 = -num1; // bedeutet, die Ganzzahl num3 wird auf -num1 gesetzt, also -5
            Console.WriteLine("num3 ist {0}", num3);

            bool isSunny = true;
            Console.WriteLine("ist es sonnig? {0}", !isSunny); // Der boolesche Wert von isSunny wird negiert = false

            // Inkrementoperatoren
            int num = 0;
            num++;  // postfix++ bedeutet: Erst Ausgabe, dann +1
            Console.WriteLine("num ist {0}", num); // Ausgabe: 1
            Console.WriteLine("num ist {0}", num++); // Ausgabe: 1, danach num = 2
            // pre increment
            Console.WriteLine("num ist {0}", ++num); // Ausgabe: 3 (erst Inkrementierung, dann Ausgabe)

            // decrement Operator
            num--;
            Console.WriteLine("num ist {0}", num); // Ausgabe: 2 (postfix--, erst Ausgabe, dann -1)
            Console.WriteLine("num ist {0}", num--); // Ausgabe: 2, danach num = 1

            // pre decrement
            Console.WriteLine("num ist {0}", --num); // Ausgabe: 0 (erst Dekrementierung, dann Ausgabe)

            int result;
            // Addition
            result = num1 + num2;
            Console.WriteLine("Ergebnis von num1:{0} + num2:{1} ist {2}", num1, num2, result);
            // Subtraktion
            result = num1 - num2;
            Console.WriteLine("Ergebnis von num1:{0} - num2:{1} ist {2}", num1, num2, result);
            // Multiplikation
            result = num1 * num2;
            Console.WriteLine("Ergebnis von num1:{0} * num2:{1} ist {2}", num1, num2, result);
            // Division
            result = num1 / num2;
            Console.WriteLine("Ergebnis von num1:{0} / num2:{1} ist {2}", num1, num2, result);
            // Modulo 5 geteilt durch 3 ist 1 Rest 2
            result = num1 % num2;
            Console.WriteLine("Ergebnis von num1:{0} % num2:{1} ist {2}", num1, num2, result);

            // Relationale und Typoperatoren
            bool isLower;
            isLower = num1 < num2; // Es wird geprüft, ob num1 (5) kleiner als num2 (3) ist = false
            Console.WriteLine("Ergebnis von num1:{0} < num2:{1} ist {2}", num1, num2, isLower);

            // Gleichheit
            bool isEqual;
            isEqual = num1 == num2; // Prüft, ob num1 gleich num2 ist = false
            Console.WriteLine("Ergebnis von num1:{0} == num2:{1} ist {2}", num1, num2, isEqual);

            isEqual = num1 != num2; // Prüft, ob num1 ungleich num2 ist = true
            Console.WriteLine("Ergebnis von num1:{0} != num2:{1} ist {2}", num1, num2, isEqual);

            // Konditionelle Operatoren
            bool isLowerAndSunny;
            // Kondition1 UND Kondition2
            isLowerAndSunny = isLower && isSunny; // Beide müssen true sein, um true zu ergeben
            Console.WriteLine("Ergebnis von num1:{0} && num2:{1} ist {2}", num1, num2, isLowerAndSunny);
            // Kondition1 ODER Kondition2
            isLowerAndSunny = isLower || isSunny; // Mindestens eine Kondition muss true sein
            Console.WriteLine("Ergebnis von num1:{0} || num2:{1} ist {2}", num1, num2, isLowerAndSunny);

            Console.ReadKey();
        }
    }
}
