using System;
using System.Security.Cryptography;

namespace ErsteKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen eines Objektes meiner Human Klasse
//Syntax    klasseName  bezeichner = new klassenName ("variableEigenschaftBsp.String", "String", int)semikolon;

            // Objekt Human 1
            Human denis = new Human("Denis", "Panjuta", "grün", 30);
            denis.IntroduceMyself();

            // Objekt Human 2
            Human michael = new Human("Michael", "Müller", "braun", 35);
            michael.IntroduceMyself();

            // Objekt Human 3
            Human amalia = new Human("Amalia", "Panjuta", "blau", 1);
            amalia.IntroduceMyself();

            // Objekt Human 4
            Human martina = new Human("Martina", "Müller", "grün");
            martina.IntroduceMyself();

            // Objekt Human 5
            Human frank = new Human("Frank", "Martinez", 13);
            frank.IntroduceMyself();

            // Objekt Human 6
            Human sissy = new Human("Sissy", "DieMissy");
            sissy.IntroduceMyself();

            Human unbekannterMensch = new Human();
            unbekannterMensch.IntroduceMyself();
            Console.ReadKey();
        }
    }
}
