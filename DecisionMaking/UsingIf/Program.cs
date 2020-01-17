using System;

namespace UsingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int myValue = int.Parse(Console.ReadLine());
            if (myValue > 2)
            {
                Console.WriteLine($"I'm excecuting because {myValue} is greater than 2");
            }
            //if (myValue < 2)
            //{
            //    Console.WriteLine($"I'm excecuting because {myValue} is less than 2");
            //}
            //if-else
            //if (myValue < 2)
            //{
            //    Console.WriteLine($"I'm excecuting because {myValue} is less than 2");
            //}
            //else
            //{
            //    Console.WriteLine($"I'm excecuting because {myValue} is greater than 2");
            //}
            //if-else-if
            //if (myValue < 2)
            //{
            //    Console.WriteLine($"I'm excecuting because {myValue} is less than 2");
            //}
            //else if (myValue == 2)
            //{
            //    Console.WriteLine($"I'm excecuting because {myValue} is equal to 2");
            //    Console.WriteLine("You win the ticket!!");
            //}
            //else
            //{
            //    Console.WriteLine($"I'm excecuting because {myValue} is greater than 2");
            //}
            //Console.WriteLine("I'm executing anyways.");
            Console.ReadLine();
        }
    }
}
