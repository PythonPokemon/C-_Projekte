using System;
namespace Konstanten
{
    class Program
    {
        /* Konstanten sind Felder die während
         * der Kompilierzeit bekannt sind und danach für die gesamte Laufzéit
         * des Programms nicht verändert werden können.
         *  Konstanten legt man üblicherweise über den Methoden an
         *  dann kann aus den klassen heraus einfach darauf zugreifen!
         * */
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "07.10.1990";
        static void Main(string[] args)
        {
            Console.WriteLine(PI);
            Console.WriteLine(weeks);
            Console.WriteLine("Hallo mein geburtstag ist am " + myBirthday);
            Console.ReadKey();
        }
    }
}