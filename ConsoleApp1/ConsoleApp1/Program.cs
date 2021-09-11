using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            Console.WriteLine("Kā tevi sauc? ");
            string userAnswer = Console.ReadLine();

            Console.WriteLine($"Sveiks, {userAnswer}");

            //Exercise 2

            Console.WriteLine("Kāds ir tavs vecums?");
            int userAgeAnswer = int.Parse(Console.ReadLine());

            bool isUserAdult = userAgeAnswer >= 18;
            int ageNextYear = userAgeAnswer + 1;

            Console.WriteLine($"Nākamgad tev paliks {ageNextYear}. Tu esi pilngadīgs: {isUserAdult}");


            //Exercise 3

            Console.WriteLine("Ievadi 1. skaitli: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi 2. skaitli: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Lielākais skaitlis ir: {Math.Max(firstNumber, secondNumber)}");

            //Exercise 4

            Console.WriteLine("Ievadi 1. skaitli: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi 2. skaitli: ");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Mazākais skaitlis ir: {Math.Min(firstNum, secondNum)}");

            //Exercise 5

            Console.WriteLine("Ievadi 1. skaitli: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi 2. skaitli: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dalījuma atlikums ir: {first % second}");

            //Exercise 6

            Console.WriteLine("Ievadi skaitli: ");
            int oddOrEven = int.Parse(Console.ReadLine());

            bool even = oddOrEven % 2 == 0;
            bool odd = oddOrEven % 2 == 1;

            Console.WriteLine($"Ievadītais skaitlis ir pāra skaitlis: {even}");
            Console.WriteLine($"Ievadītais skaitlis ir nepāra skaitlis: {odd}");

            //Exercise 7

            Console.WriteLine("Ievadi taisnstūra platumu: ");
            double firstN = double.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi taisnstūra garumu: ");
            double secondN = double.Parse(Console.ReadLine());

            double area = firstN * secondN;

            Console.WriteLine($"Mazākais skaitlis ir: {Math.Round((area), 2)}");

            //Exercise 8

            Console.WriteLine("Ievadi vienādsānu trīsstūra augstumu (cm): ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi vienādsānu trīsstūra pamata garumu (cm): ");
            double baseLength = double.Parse(Console.ReadLine());

            double triangleArea = height * baseLength / 2;

            Console.WriteLine($"Trīsstūra laukums ir: {Math.Round((triangleArea), 2)} cm\xB2");

            //Exercise 9

            Console.WriteLine("Kāds ir tavs vārds? ");
            string userName = Console.ReadLine();

            Console.WriteLine("Kāds ir tavs vecums? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sveiks, {userName}, tavs vecums ir {age}");
        }
    }
}
