using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do-While Loop");
            int doWhileCounter = 1;
            do
            {
                Console.WriteLine($"Counter is at {doWhileCounter}");
            } while (doWhileCounter <= 10);
        }
    }
}
