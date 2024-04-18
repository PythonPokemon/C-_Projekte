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
            num3 = -num1; // bedeutet die ganzzahl num3 wird als num1 deklariert aber negiert, bedeutet ins minus gesetzt = -5
            Console.WriteLine("num3 ist {0}", num3);

            bool isSunny = true;
            Console.WriteLine("ist es sonnig? {0}", !isSunny); // der bezeichner isSunny wird mit ! ausrufezeichen vor dem string negiert = bedeutet False

            // Inkrementoperatoren
            int num = 0;
            num++;  // afix++ bedeutet addition +1
            Console.WriteLine("num ist {0}", num); // 0
            Console.WriteLine("num ist {0}", num++); // konsolenausgabe +1
            // pre increment
            Console.WriteLine("num ist {0}", ++num);    // ++präfix bedeutet addition +1 = 3

            // decrement Operator
            num--;
            Console.WriteLine("num ist {0}", num); // 3 -1 = 2
            Console.WriteLine("num ist {0}", num--); // 2 -1 = 1 wird aber nur zwischen gespeichert

            // pre decrement
            Console.WriteLine("num ist {0}", --num); // 1 -1 = 0 | bezieht sich ab das zwischgespeicherte ergebnis 1

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
            isLower = num1 < num2; // Boolena ist ein wahrheitswert es wird geprüft ob 5 kleiner 3 ist = False
            Console.WriteLine("Ergebnis von num1:{0} < num2:{1} ist {2}", num1, num2, isLower);

            // Gleichheit
            bool isEqual;
            isEqual = num1 == num2; // ob 5 gleich 3 ist = False
            Console.WriteLine("Ergebnis von num1:{0} == num2:{1} ist {2}", num1, num2, isEqual);

            isEqual = num1 != num2; // ob 5 ungliech 3 ist = True
            Console.WriteLine("Ergebnis von num1:{0} != num2:{1} ist {2}", num1, num2, isEqual);

            // Konditionelle Operatoren
            bool isLowerAndSunny;
            // Kondition1 UND Kondition2
            isLowerAndSunny = isLower && isSunny; // UND | bedeutet beide müssen True sein
            Console.WriteLine("Ergebnis von num1:{0} && num2:{1} ist {2}", num1, num2, isLowerAndSunny);
            // Kondition1 ODER Kondition2
            isLowerAndSunny = isLower || isSunny; // ODER | vergleich eins von den werten muss True sein
            Console.WriteLine("Ergebnis von num1:{0} || num2:{1} ist {2}", num1, num2, isLowerAndSunny);

            Console.ReadKey();
        }
    }
}
