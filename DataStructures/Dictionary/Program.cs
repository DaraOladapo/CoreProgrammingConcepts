using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myStringDictionary = new Dictionary<string, string>();
            myStringDictionary.Add("Key1", "Item 1");
            myStringDictionary.Add("Key2", "Item 2");
            myStringDictionary.Add("Key3", "Item 3");
            myStringDictionary.Add("Key4", "Item 4");
            myStringDictionary.Add("Key5", "Item 5");
            myStringDictionary.Add("Key6", "Item 6");
            myStringDictionary.Add("Key7", "Item 7");
            myStringDictionary.Add("Key8", "Item 8");
            myStringDictionary.Add("Key9", "Item 9");
            myStringDictionary.Add("Key10", "Item 10");
            Console.WriteLine($"Dictionary has {myStringDictionary.Count}");
            Console.WriteLine($"Item that has 'Key3' is{myStringDictionary["Key3"]}");
            Console.WriteLine();
            myStringDictionary.Remove("Key4");
            Console.WriteLine($"Dictionary now has {myStringDictionary.Count} items");
        }
    }
}
