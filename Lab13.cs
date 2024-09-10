using System;
using System.Collections.Generic;
using System.Linq;

class Lab13
{
    static void Main(string[] args)
    {
        // Sample list of numbers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Query syntax
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;

        // Method syntax
        var oddNumbersQuery = numbers.Where(num => num % 2 != 0);

        // Execution
        Console.WriteLine("Even numbers (Query Syntax):");
        foreach (var num in evenNumbersQuery)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nOdd numbers (Method Syntax):");
        foreach (var num in oddNumbersQuery)
        {
            Console.WriteLine(num);
        }

        // Example with strings
        List<string> names = new List<string> { "John", "Alice", "Bob", "Charlie", "David" };

        // Query syntax
        var namesStartingWithBQuery = from name in names
                                      where name.StartsWith("B")
                                      select name;

        // Method syntax
        var namesEndingWithDQuery = names.Where(name => name.EndsWith("d"));

        // Execution
        Console.WriteLine("\nNames starting with 'B' (Query Syntax):");
        foreach (var name in namesStartingWithBQuery)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nNames ending with 'd' (Method Syntax):");
        foreach (var name in namesEndingWithDQuery)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\nLab no. : 13 \nName : Pratik Shah \nRoll No. : 64/077");
    }
}
