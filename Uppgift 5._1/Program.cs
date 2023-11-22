using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = new string[4];

            meningar[0] = "Hej och välkommen!";
            meningar[1] = "Detta program skriver ut fyra meningar.";
            meningar[2] = "Alla meningar är på olika rader.";
            meningar[3] = "De har även ett mellanrum mellan varje rad.";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(meningar[i]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}