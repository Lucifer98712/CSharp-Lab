using System;
using System.Collections.Generic;
using System.Linq;

class Lab14
{
    static void Main(string[] args)
    {
        // Lambda Expression Example
        Console.WriteLine("Lambda Expression Example:");
        // Lambda expression to square a number
        Func<int, int> square = x => x * x;
        Console.WriteLine($"Square of 5: {square(5)}");

        // LINQ with Lambda Expression Example
        Console.WriteLine("\nLINQ with Lambda Expression Example:");
        // Sample list of numbers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ query using lambda expression to filter even numbers
        var evenNumbers = numbers.Where(x => x % 2 == 0);

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Another example: find names starting with 'A'
        List<string> names = new List<string> { "John", "Alice", "Bob", "Charlie", "David" };

        // LINQ query using lambda expression to find names starting with 'A'
        var namesStartingWithA = names.Where(name => name.StartsWith("A"));

        Console.WriteLine("\nNames starting with 'A':");
        foreach (var name in namesStartingWithA)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\nLab no. : 14 \nName : Pratik Shah \nRoll No. : 64/077");
    }
}
