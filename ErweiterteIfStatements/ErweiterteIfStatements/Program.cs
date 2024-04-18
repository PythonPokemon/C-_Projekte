using System;

namespace ErweiterteIfStatements
{
    class Program
    {
        // Bedingung ? erster_Ausdruck : zweiter_Ausdruck;
        // Bedingung muss entweder wahr oder falsch sein (true /false)
        // Der konditionelle Operator ist rechtdassociativ
        // Der Audruck a ? b : c ? d: e
        // wird so evaluiert a ? b : (c ? d : e),
        // und nicht als (a ? b : c) ? d : e.
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
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : (temperature < 0 ? "fest" : "flüssig");
            Console.WriteLine("Aggregatszustand ist {0}", stateOfMatter);

            Console.ReadKey();
        }
    }
}
