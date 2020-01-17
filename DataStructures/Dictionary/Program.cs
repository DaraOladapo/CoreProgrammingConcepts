using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myStringDictionary = new Dictionary<string, string>();
            myStringDictionary.Add("Daddy", "E. Oladapo");
            myStringDictionary.Add("Mummy", "G. Oladapo");
            myStringDictionary.Add("FirstBorn", "O. Oladapo");
            myStringDictionary.Add("SecondBorn", "I. Oladapo");
            myStringDictionary.Add("LastBorn", "D. Oladapo");
            Console.WriteLine($"Oladapo family has {myStringDictionary.Count} people");
            Console.WriteLine($"FirstBorn's name is {myStringDictionary["FirstBorn"]}");
            Console.WriteLine();
        }
    }
}
