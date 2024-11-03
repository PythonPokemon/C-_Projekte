using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

/*
Feld (lastName): 
Wird 'klein' geschrieben und ist 'privat'. 
Es speichert tatsächlich den Wert der Daten und wird innerhalb der Klasse verwendet.

Property (LastName): 
Wird 'groß' geschrieben und ist 'öffentlich'. 
Sie bietet einen kontrollierten Zugriff auf das private Feld. 
Die Großschreibung folgt der Konvention für Properties in C#, was den Code klarer und einfacher zu lesen macht.
 */

namespace MVVMTutorial.Model
{
    public class SimplePerson : ObservableObject
    {
        private string lastName;      // Feld, klein geschrieben

        public string LastName        // Property, groß geschrieben
        {
            get { return lastName; }
            set {SetProperty(ref lastName, value); } // damit setzt man der field, also klassen variable den property 'value'
        }


        private string surName;         // Feld, klein geschrieben

        public string SureName         // Property, groß geschrieben
        {
            get { return surName; }
            set {SetProperty(ref surName, value); }
        }


        /*
        hier wird eine neue, leere Sammlung erstellt. 
        Das bedeutet, dass die childs-Liste beim Erstellen eines neuen Objekts der Klasse SimplePerson leer ist 
        und du später string-Elemente hinzufügen oder entfernen kannst.
         */
        private ObservableCollection<string> childs; 

        public ObservableCollection<string> Childs
        {
            get { return childs; }
            set {SetProperty(ref childs, value); }
        }

        /*
         Der Konstruktor SimplePerson sorgt dafür, dass die childs-Liste initialisiert wird 
         und die Zeichenketten-Felder lastName und SureName mit einem sicheren, leeren Wert starten, 
         um potenzielle Fehler zu vermeiden.
         */
        public SimplePerson()   // Konstruktor aufruf der Klasse 'SimplePerson'
        {
            childs = new ObservableCollection<string>();
            lastName = string.Empty; // string.Empty ist eine elegante und explizite Möglichkeit, eine leere Zeichenkette ("") zuzuweisen.
            SureName = string.Empty;
        }

        // Fazit damit können jetzt information vom Model an das ViewModel Übergeben werden!
    }
}
