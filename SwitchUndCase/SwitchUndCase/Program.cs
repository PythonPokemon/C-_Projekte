using System;
/**
 * Switch Case = ist wie ein schalter der meherer position durchläuft, 
 * wenn einer dieser position eine bedingung erfüllt, wird der code an der position ausgeführt
 * */
namespace SwitchUndCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alter
            int age = 16;

            switch (age)
            {
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("Zu jung zum Feiern");
                    break;
                case 25:
                    Console.WriteLine("Alles klar, abgehts");
                    break;
                
                default:// wie Else bei einer If Bedingung
                    Console.WriteLine("Wie alt bist du eigentlich?");
                    break;
            }

            //---------------------------------------------------------
            // genau das gleiche nur mit IF- Else

            if (age == 15)
            {
                Console.WriteLine("Zu jung zum Feiern");
            }
            else if (age == 25)
            {
                Console.WriteLine("Alles klar, abgehts");
            }
            else
            {
                Console.WriteLine("Wie alt bist du eigentlich?");
            }

            string username = "I am Groot";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("Benutzername ist Denis");
                    break;
                case "root":
                    Console.WriteLine("Benutzername ist root");
                    break;
                default:    // default trit bei einer fehlereingabe ein
                    Console.WriteLine("Benutzername unbekannt");
                    break;  // mit break wird das programm beendet
            }



            Console.ReadLine();
        }
    }
}
