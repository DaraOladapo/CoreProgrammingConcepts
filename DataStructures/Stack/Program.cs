using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
           Stack myStringStack=new Stack();
           myStringStack.Push("Item1");
           myStringStack.Push("Item2");
           myStringStack.Push("Item3");
           myStringStack.Push("Item4");
           myStringStack.Push("Item5");
           myStringStack.Push("Item6");
           myStringStack.Push("Item7");
           myStringStack.Push("Item8");
           myStringStack.Push("Item9");
           myStringStack.Push("Item10");
           Console.WriteLine($"Initial stack count: {myStringStack.Count}");
        }
    }
}
