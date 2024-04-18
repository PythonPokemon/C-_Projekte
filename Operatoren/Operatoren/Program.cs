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
            num3 = -num1;
            Console.WriteLine("num3 ist {0}", num3);

            bool isSunny = true;
            Console.WriteLine("ist es sonnig? {0}", !isSunny);

            // Inkrementoperatoren
            int num = 0;
            num++;
            Console.WriteLine("num ist {0}", num);
            Console.WriteLine("num ist {0}", num++);
            // pre increment
            Console.WriteLine("num ist {0}", ++num);

            // decrement Operator
            num--;
            Console.WriteLine("num ist {0}", num);
            Console.WriteLine("num ist {0}", num--);

            // pre decrement
            Console.WriteLine("num ist {0}", --num);

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
            // Modulo
            result = num1 % num2;
            Console.WriteLine("Ergebnis von num1:{0} % num2:{1} ist {2}", num1, num2, result);

            // Relationale und Typoperatoren
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Ergebnis von num1:{0} < num2:{1} ist {2}", num1, num2, isLower);

            // Gleichheit
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Ergebnis von num1:{0} == num2:{1} ist {2}", num1, num2, isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Ergebnis von num1:{0} != num2:{1} ist {2}", num1, num2, isEqual);

            // Konditionelle Operatoren
            bool isLowerAndSunny;
            // Kondition1 UND Kondition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Ergebnis von num1:{0} && num2:{1} ist {2}", num1, num2, isLowerAndSunny);
            // Kondition1 ODER Kondition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Ergebnis von num1:{0} || num2:{1} ist {2}", num1, num2, isLowerAndSunny);

            Console.ReadKey();
        }
    }
}
