using System;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for feedback between 1 and 5 where 1 is Very Bad and 5 is Excellent:");
            int myValue = int.Parse(Console.ReadLine());
            var UserFeedback = (Feedback)myValue;
            switch (UserFeedback)
            {
                case Feedback.VeryBad:
                    Console.WriteLine("We're very sorry. We'll do better next time.");
                    break;
                case Feedback.Bad:
                    Console.WriteLine("We're very sorry. We'll do better next time.");
                    break;
                case Feedback.Moderate:
                    Console.WriteLine("What can we do better?");
                    break;
                case Feedback.Good:
                    Console.WriteLine("Thanks for your feedback. We wish to see you again.");
                    break;
                case Feedback.VeryGood:
                    Console.WriteLine("Wheeeeew! Thank you!. We look forward to serving you next time.");
                    break;
                default:
                    Console.WriteLine("Input value out of range");
                    break;
            }
            Console.ReadLine();
        }
    }
}
