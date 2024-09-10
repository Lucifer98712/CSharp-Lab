using System;
using System.Collections; // for non-generic collections
using System.Collections.Generic; // for generic collections

class Lab10
{
    static void Main(string[] args)
    {
        // Non-generic collection: ArrayList
        Console.WriteLine("Non-generic collection (ArrayList):");
        ArrayList arrayList = new ArrayList();
        arrayList.Add(10); // Adding integer
        arrayList.Add("Hello"); // Adding string
        arrayList.Add(3.14); // Adding double

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Generic collection: List<T>
        Console.WriteLine("\nGeneric collection (List<int>):");
        List<int> intList = new List<int>();
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);

        foreach (var item in intList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nLab no. : 10 \nName : Pratik Shah \nRoll No. : 64/077");
    }
}
