using System;

namespace VerschachtelteIfBedingungen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = true;
            bool isRegistered = true;
            string userName = ""; // wird hier deklariert userName = Console.ReadLine();
            Console.WriteLine("Bitte trage deinen Benutzernamen ein!");
            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName == "Admin") // UND abfrage ob registriert & nutzername Admin ist, muss beides True sein
            {
                Console.WriteLine("Hallo registrierter Nutzer!");
                Console.WriteLine("Hi {0}", userName);
                Console.WriteLine("Hallo Admin!");

            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("Du bist eingeloggt");
            }

            Console.ReadKey();
        }
    }
}
