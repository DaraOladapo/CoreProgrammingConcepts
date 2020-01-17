using System;
using System.Collections;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStringStack = new Stack();
            myStringStack.Push("Item 1");
            myStringStack.Push("Item 2");
            myStringStack.Push("Item 3");
            myStringStack.Push("Item 4");
            myStringStack.Push("Item 5");
            myStringStack.Push("Item 6");
            myStringStack.Push("Item 7");
            myStringStack.Push("Item 8");
            myStringStack.Push("Item 9");
            myStringStack.Push("Item 10");
            Console.WriteLine($"Initial stack count: {myStringStack.Count}");
            Console.WriteLine();
            while (myStringStack.Count > 0)
            {
                var popItem = myStringStack.Pop();
                Console.WriteLine($"{popItem} has been popped off the stack");
                Console.WriteLine($"New stack count: {myStringStack.Count}");
                Console.WriteLine();
            }
        }
    }
}
