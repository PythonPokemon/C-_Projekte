using System;

namespace DoWhileSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Bitte trage den Namen eines Freundes ein");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Danke, das reicht! Deine Freunde sind {0}", wholeText);

            // 1. Zählervariable anlegen
            int counter = 25;
            do
            {
                Console.WriteLine(counter);
                // 3. Dafür sorgen, dass Bedingung irgendwann nicht mehr erfüllt ist. 
                counter++;
                // 2. Bedingung einfügen
            } while (counter < 5);

            Console.Read();
        }
    }
}
