using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion");
            Console.WriteLine("Enter an integer number: ");
            var userInput = int.Parse(Console.ReadLine());
            long factorialValue = Factorial(userInput);
            Console.WriteLine($"{userInput}!={factorialValue}");
        }
        static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
