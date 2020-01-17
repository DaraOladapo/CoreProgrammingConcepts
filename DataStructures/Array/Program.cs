using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStringArray=new string[]{
                "Item 1","Item 2","Item 3","Item 4","Item 5",
                "Item 6","Item 7","Item 8","Item 9","Item 10"
            };
            Console.WriteLine($"Item at index 2 is: {myStringArray[2]}" );
            Console.WriteLine();
            Console.WriteLine($"myStringArray contains {myStringArray.Length}");
            Console.WriteLine();
            Console.WriteLine("All the content of the myStringArray");
            foreach (var arrayItem in myStringArray)
            {
                Console.WriteLine(arrayItem);
            }
        }
    }
}
