using System;
/*
 * In C# bezieht sich der Begriff "Property" auf eine spezielle Art von Member einer Klasse, der den Zugriff auf die privaten Felder der Klasse steuert.
 * Properties bieten eine Möglichkeit, den Zustand einer Klasse zu kapseln und den Zugriff darauf zu kontrollieren, 
 * indem sie den Zugriff auf die Felder der Klasse über Getter- und Setter-Methoden bereitstellen.
 */
namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // anlegen eines neuen Objektes | Box bezeichner/name = new Box (Parameter1, P2, P3, usw)
            Box box = new Box(5, 3, 4);
            Console.WriteLine("Die Gesichtsfläche ist {0}", box.FrontSurface);
            Console.WriteLine("Volume ist {0}", box.Volume);

            box.DisplayInfo();

            Console.ReadKey();
        }
    }
}
