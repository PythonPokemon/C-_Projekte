using System;

namespace IfBedingungenEinführung
{
    class Program
    {
        static void Main(string[] args)
        {

            // if(Bedingung)
            // {
            //      auszuführender Code
            // }
            Console.WriteLine("Wie warm ist es gerade? Trage den Wert als Zahl ein");
            // Benutzereingabe
            string temperatureInput = Console.ReadLine();
            //int temperature = int.Parse(temperatureInput);
            int temperature;
            int number;

            bool userEnteredANumber = int.TryParse(temperatureInput, out number);

            if (userEnteredANumber)
            {
                temperature = number;
            }
            else
            {
                temperature = 0;
            }


            if (temperature < 20)
            {
                Console.WriteLine("Zieh deine Jacke an!");
            }
            else if (temperature == 20)
            {
                Console.WriteLine("Es ist genau 20 Grad C° Warm");
            }
            else if (temperature > 30)
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
