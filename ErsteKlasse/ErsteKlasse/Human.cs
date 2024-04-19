using System;
using System.Collections.Generic;
using System.Text;

namespace ErsteKlasse
{
    // Mensch Klasse
    // Eine Blaupause für einen Datentypen

    // Füge zwei weitere Membervariablen "eyeColor" und "age" zu Human hinzu.
    // Erweitere den Konstruktor, sodass er alle vier Variablen verwendet, wenn ein Objekt von Human angelegt wird
    // Erstelle zwei Objekte von Human

    class Human
    {
        // Membervariable Vorname
        string firstname;
        // Membervariable Nachname
        string lastname;
        string eyeColor;
        int age;

// public | ist ein zurgriffs-modifizierer der besagt ob die klasse öffentlich oder privat sein soll
        
        // Default Konstruktor
        public Human() 
        {
            Console.WriteLine("Default Konstruktor aufgerufen");
            age = 0;
            eyeColor = "braun";
            firstname = "Unbekannt";
            lastname = "Unbekannt";
        }

        // Parameterisierter Konstruktor
        public Human(string firstname, string lastname, string eyeColor, int age)
        {
            this.firstname = firstname; // mit| this.bezeichner = bezeichner |sagt man das die variable string aus dem konstruktotr, eine member variable aus der klasse human sein soll!
            this.lastname = lastname;
            this.eyeColor = eyeColor;
            this.age = age;
            Console.WriteLine("Objekt von Human erstellt");
        }

        public Human(string firstname, string lastname, string eyeColor)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
        }

        public Human(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public Human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }


        // Member Methode
        public void IntroduceMyself()
        {
            if (age != 0 && lastname != null && eyeColor != null && firstname != null)
            {
                Console.WriteLine("Hi, Ich bin {0} {1}, meine Augenfarbe ist {2}" +
                                " und ich bin {3} Jahr alt.", firstname, lastname, eyeColor, age);
            }
            else if (lastname != null && eyeColor != null && firstname != null)
            {
                Console.WriteLine("Hi, Ich bin {0} {1}, meine Augenfarbe ist {2}" +
                "", firstname, lastname, eyeColor);
            }
            else if (lastname != null && age != 0 && firstname != null)
            {
                Console.WriteLine("Hi, Ich bin {0} {1}, und bin {2} Jahre alt" +
                "", firstname, lastname, age);
            }

            else if (lastname != null && firstname != null)
            {
                Console.WriteLine("Hi, ich bin {0} {1}", firstname, lastname);
            }


        }
    }
}
