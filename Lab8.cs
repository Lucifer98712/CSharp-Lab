using System;

// Structure (struct)
public struct Point
{
    public int X;
    public int Y;
}

// Enumeration (enum)
public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

// Partial class
public partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void DisplayFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}

public partial class Person
{
    public int Age { get; set; }
}

class Lab8
{
    static void Main(string[] args)
    {
        // Structure (struct)
        Point point;
        point.X = 10;
        point.Y = 20;
        Console.WriteLine($"Point: ({point.X}, {point.Y})");

        // Enumeration (enum)
        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine($"Today is: {today}");

        // Partial class
        Person person = new Person();
        person.FirstName = "Pratik";
        person.LastName = "Shah";
        person.Age = 23;
        person.DisplayFullName();
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine("\nLab no. : 8 \nName : Pratik Shah \nRoll No. : 64/077");

    }
}
