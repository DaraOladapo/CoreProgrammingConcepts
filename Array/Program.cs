using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStringArray=new string[]{
                "Item1","Item2","Item3","Item4","Item5",
                "Item6","Item7","Item8","Item9","Item10"
            };
            Console.WriteLine($"Item at index 2 is: {myStringArray[2]}" );
            Console.WriteLine($"myStringArray contains {myStringArray.Length}");
            Console.WriteLine("All the content of the myStringArray");
            foreach (var arrayItem in myStringArray)
            {
                Console.WriteLine(arrayItem);
            }
        }
    }
}
