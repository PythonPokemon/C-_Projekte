using System;

namespace CubeProject // Hier geben wir dem Namespace den Namen des Projekts
{
    public class Cube
    {
        public double Height { get; set; } // Property für die Höhe des Würfels
        public double Length { get; set; } // Property für die Länge des Würfels

        // Property für die Vorderseite des Würfels
        public double FrontSide
        {
            get { return Height * Length; } // Berechnung der Vorderseite basierend auf Höhe und Länge
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Erstellen einer Instanz der Klasse "Cube"
            Cube myCube = new Cube();

            // Setzen der Höhe und Länge des Würfels
            myCube.Height = 5.0;
            myCube.Length = 3.0;

            // Zugriff auf die Vorderseite des Würfels und Ausgabe des Ergebnisses
            Console.WriteLine("Die Vorderseite des Würfels beträgt: " + myCube.FrontSide);
        }
    }
}
