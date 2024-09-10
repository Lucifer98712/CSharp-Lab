using System;

// Custom exception class
public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message)
    {
    }
}

class Lab15
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nLab no. : 15 \nName : Pratik Shah \nRoll No. : 64/077");

        // a) Exception handling using try, catch, and finally blocks
        try
        {
            int result = Divide(10, 0); // Division by zero will throw an exception
            Console.WriteLine("Result: " + result); // This line will not be executed
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        // b) Dealing with throw keyword
        try
        {
            int age = -1;
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }

        // c) Custom exception handling
        try
        {
            int result = Divide(10, 0); // Division by zero will throw an exception
            Console.WriteLine("Result: " + result); // This line will not be executed
        }
        catch (DivideByZeroException ex)
        {
            throw new MyCustomException("Custom Exception: Division by zero is not allowed.");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine("Custom Exception caught: " + ex.Message);
        }

    }

    // Method to perform division
    static int Divide(int dividend, int divisor)
    {
        return dividend / divisor;
    }
}
