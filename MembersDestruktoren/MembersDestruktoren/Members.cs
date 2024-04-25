using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MembersDestruktoren
{
    class Members
    {
        // member - private fields
        // Mitglieder - Private Felder
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - eröffnet jobTitle auf einem sicheren Wege
        // Properties beginnen mit einem Großbuchstaben
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member Method - kann von anderen Klassen aus aufgerufen werden
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, ich bin {0}, und mein Jobtitel ist {1}, Ich bin {2} Jahre alt.", memberName, jobTitle, age);
            }

        }

        // private member Method | lässt sich sich von anderen klassen aus aufrufen
        private void SharingPrivateInfo()
        {
            Console.WriteLine("Mein Gehalt ist {0}", salary);
        }

        // member constructor - Default Constructor | ist so wie eine  standart schablone
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Entwickler";
            Console.WriteLine("Objekt erzeugt");
        }

        // Member - Finalizer - Destructor | wird verwendet um das Objekt zu löschen
        ~Members()
        {
            // Aufräumarbeiten

        }

    }
}
