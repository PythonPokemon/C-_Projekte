using System;

namespace ErweiterteIfStatements
{
    class Program
    {
        // Bedingung ? erster_Ausdruck : zweiter_Ausdruck;
        // Bedingung muss entweder wahr oder falsch sein (true /false)
        // Der konditionelle Operator ist rechtdassociativ
        // Der Audruck a ? b : c ? d: e
        // wird so evaluiert a ? b : (c ? d : e),   = wäre richtig
        // und nicht als (a ? b : c) ? d : e.       = wäre falsch
        // Der Kontionelle operator kann nicht überschrieben werden.

        static void Main(string[] args)
        {
            // Temperatur unseres Wassers
            int temperature = -5;
            // Aggregatszustand
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "fest";
            }
            else if (temperature < 100)
            {
                stateOfMatter = "flüssig";
            }
            else
            {
                stateOfMatter = "gas";
            }

            Console.WriteLine("Aggregatszustand ist {0}", stateOfMatter);

            temperature += 30;
            // in Kurzversion
            stateOfMatter = temperature < 0 ? "fest" : "flüssig";
            Console.WriteLine("Aggregatszustand ist {0}", stateOfMatter);

            // hier ist die Temperatur 100
            temperature += 100;
            // doppelpunkt :    | soll oder darstelle, was nach dem doppelpunkt steht
            // fragezeichen ?   | ist wie, ist gleich = zu verstehen bsp.temperature > 100 ? "gas"
            // es wird geprüft ob die temp. größer gleich 100 ist wenn dann wird mit fragezeichen? = gas angezeigt
            // oder doppelpunkt : es wird geprüft ob die temp kleiner 0 ist = fest : ansonsten flüssig
            stateOfMatter = temperature > 100 ? "gas" : (temperature < 0 ? "fest" : "flüssig");
            Console.WriteLine("Aggregatszustand ist {0}", stateOfMatter);

            Console.ReadKey();
        }
    }
}
