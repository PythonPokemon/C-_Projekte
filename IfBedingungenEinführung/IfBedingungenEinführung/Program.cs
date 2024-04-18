using System;

namespace IfBedingungenEinführung
{
    class Program
    {
        static void Main(string[] args)
        {

            // if(Bedingung) falls eine bedingung zutrifft, dann ...
            // {
            //      auszuführender Code
            // }
            // else = sonst das...
            Console.WriteLine("Wie warm ist es gerade? Trage den Wert als Zahl ein");
            // Benutzereingabe
            string temperatureInput = Console.ReadLine();
            //int temperature = int.Parse(temperatureInput);
            int temperature;
            int number;

            // Methode wo eine fehlerhaft eingabe abgefangen wird bsp. 0
            bool userEnteredANumber = int.TryParse(temperatureInput, out number);

            if (userEnteredANumber)
            {
                temperature = number;
            }
            else
            {
                temperature = 0;
            }

            // wenn es zum abfangen des fehlers kommt, wird im anschluss die nächst logische zeile ausgeführt
            // indem fall temperatur unter 20 grad = zieh eine jacke an

            if (temperature < 20) // falls es kleiner 20 grad ist
            {
                Console.WriteLine("Zieh deine Jacke an!");
            }
            else if (temperature == 20) // falls es genau 20 grad ist
            {
                Console.WriteLine("Es ist genau 20 Grad C° Warm");
            }
            else if (temperature > 30) // falls es über 30 heiß sein wird
            {
                Console.WriteLine("Es ist eine Bullenhitze!");
            }
            else
            {
                Console.WriteLine("Zwischen 21 und 30 Grad - T-Shirt und kurze Hose reicht!");
            }

            Console.ReadKey();
        }
    }
}
