using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");
            for (int forCounter = 1; forCounter <= 10; forCounter++)
            {
                Console.WriteLine($"Counter is at {forCounter}");
            }
        }
    }
}
