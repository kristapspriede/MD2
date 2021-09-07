using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā tevi sauc? ");
            string userAnswer = Console.ReadLine();

            Console.WriteLine($"Sveiks, {userAnswer}");
        }
    }
}
