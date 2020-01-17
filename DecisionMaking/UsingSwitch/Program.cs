using System;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int myValue = int.Parse(Console.ReadLine());
            switch (myValue)
            {
                case 1:
                    Console.WriteLine($"Jackpot! {myValue} is equal to 1");
                    break;
                case 2:
                    Console.WriteLine($"Jackpot! {myValue} is equal to 2");
                    break;
                case 3:
                    Console.WriteLine($"Jackpot! {myValue} is equal to 3");
                    break;
                default:
                    Console.WriteLine("No case condition was met. So this is what will happen.");
                    break;
            }
        }
    }
}
