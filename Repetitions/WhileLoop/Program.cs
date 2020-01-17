using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Loops");
            int whileCounter = 1;
            while (whileCounter <= 10)
            {
                Console.WriteLine($"Counter value is at {whileCounter}");
                whileCounter++;
            }
        }
    }
}
