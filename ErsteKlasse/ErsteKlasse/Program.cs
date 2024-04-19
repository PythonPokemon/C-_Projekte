using System;
using System.Security.Cryptography;

namespace ErsteKlasse
{



    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen eines Objektes meiner Human Klasse
            Human denis = new Human("Denis", "Panjuta", "grün", 30);
            denis.IntroduceMyself();

            Human michael = new Human("Michael", "Müller", "braun", 35);
            michael.IntroduceMyself();

            Human amalia = new Human("Amalia", "Panjuta", "blau", 1);
            amalia.IntroduceMyself();

            Human martina = new Human("Martina", "Müller", "grün");
            martina.IntroduceMyself();

            Human frank = new Human("Frank", "Martinez", 13);
            frank.IntroduceMyself();

            Human sissy = new Human("Sissy", "DieMissy");
            sissy.IntroduceMyself();

            Human unbekannterMensch = new Human();
            unbekannterMensch.IntroduceMyself();
            Console.ReadKey();
        }
    }
}
