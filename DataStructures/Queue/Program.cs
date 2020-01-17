using System;
using System.Collections;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myStringQueue = new Queue();
            myStringQueue.Enqueue("Item 1");
            myStringQueue.Enqueue("Item 2");
            myStringQueue.Enqueue("Item 3");
            myStringQueue.Enqueue("Item 4");
            myStringQueue.Enqueue("Item 5");
            myStringQueue.Enqueue("Item 6");
            myStringQueue.Enqueue("Item 7");
            myStringQueue.Enqueue("Item 8");
            myStringQueue.Enqueue("Item 9");
            myStringQueue.Enqueue("Item 10");
            Console.WriteLine($"Initial Queue count: {myStringQueue.Count}");
            Console.WriteLine($"First item to get out of queue will be {myStringQueue.Peek()}");
            Console.WriteLine();
            var qValue = myStringQueue.Dequeue();
            Console.WriteLine($"Dequeued item is {qValue.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"Queue count is now {myStringQueue.Count}");
            Console.WriteLine($"Next item for dequeueing is {myStringQueue.Peek()}");

        }
    }
}
