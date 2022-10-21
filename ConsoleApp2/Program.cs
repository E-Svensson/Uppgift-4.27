using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ut ett meddelande. Detta meddelande kommer sedan skrivas ut vertikalt.");

            Console.Write("\nSkriv här: "); string inputString = Console.ReadLine();

            char[] inputArray = inputString.ToCharArray();

            Console.WriteLine("\nDu ska nu bestämma hur långt åt höger meddelandet ska skickas mätt i mellanslag.");
            Console.WriteLine("Helt enkelt, skriver du \"1\" så kommer meddelandet skickas ett mellanslag åt höger.");

            Console.Write("\nSkriv här: "); int längd = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < längd; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(inputArray[i]);
            }
        }
    }
}