using System;

namespace Primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            var prime = new Prime();
            int number = 0;
            bool success = false;

            // Fortsätter ta emot input tills att inputen är q
            do
            {
                Console.WriteLine("Enter a number or command: (q to quit)");
                input = Console.ReadLine();

                // Kollar om input är int eller inte
                success = int.TryParse(input, out number);
                if (success)
                {
                    if (prime.IsPrime(number))
                    {
                        Console.WriteLine("Prime!");
                    }
                    else
                    {
                        Console.WriteLine("Not Prime!");
                    }
                }
                else if (input == "PrintAll")
                {
                    var temp = prime.GetList();

                    foreach (var num in temp)
                    {
                        Console.WriteLine(num);
                    }
                }
                else if (input == "GenerateNext")
                {
                    prime.GenerateNextPrime();
                }
                else
                {
                    Console.WriteLine("Not a number or command. Try again:");
                }
            } while (input != "q");
        }
    }
}
