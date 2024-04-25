using System;

namespace TestObjeke
{
    class Program
    {
        class Fahrzeug
        {
            // Eigenschaften eines Fahrzeugs
            public string Marke { get; set; }
            public string Modell { get; set; }
            public string Farbe { get; set; }
            public int Geschwindigkeit { get; private set; }

            // Konstruktor für die Initialisierung der Eigenschaften
            public Fahrzeug(string marke, string modell, string farbe)
            {
                Marke = marke;
                Modell = modell;
                Farbe = farbe;
                Geschwindigkeit = 0; // Startgeschwindigkeit ist 0
            }

            // Methode zum Beschleunigen des Fahrzeugs
            public void Beschleunigen(int erhöhung)
            {
                Geschwindigkeit += erhöhung;
            }

            // Methode zum Anzeigen der Fahrzeuginformationen in der Konsole
            public void Anzeigen()
            {
                Console.WriteLine($"Fahrzeug: {Marke} {Modell}, Farbe: {Farbe}, Geschwindigkeit: {Geschwindigkeit} km/h");
            }
        }

        static void Main(string[] args)
        {
            // Erstellen eines Fahrzeugs
            Fahrzeug auto = new Fahrzeug("BMW", "X5", "Blau");

            // Anzeigen der Informationen über das Fahrzeug in der Konsole
            auto.Anzeigen();
        }
    }
}
