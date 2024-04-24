using System;                                   // Importieren des System-Namespace, der grundlegende Klassen und Funktionen bereitstellt

namespace Person                                // Definition eines eigenen Namespaces "Person"
{
    public class Person                         // Definition einer öffentlichen Klasse "Person"
    {
        private string name;                    // Private Feldvariable "name" vom Typ string, die den Namen einer Person speichert

        // Beispiel für eine Property "Name", die den Zugriff auf das private Feld "name" ermöglicht
        public string Name
        {
            get { return name; }                // Getter-Methode, die den aktuellen Wert von "name" zurückgibt
            set { name = value; }               // Setter-Methode, die einen neuen Wert für "name" setzt
        }
    }

    public class Program                         // Definition einer öffentlichen Klasse "Program"
    {
        public static void Main(string[] args)  // Haupteinstiegspunkt des Programms
        {
            // Verwendung der Property "Name"
            Person person = new Person();       // Erstellen einer neuen Instanz der Klasse "Person"
            person.Name = "John";               // Setzen des Namens der Person auf "John" mithilfe der Property
            Console.WriteLine(person.Name);     // Ausgabe des Namens der Person auf der Konsole, gibt "John" aus
        }
    }
}
