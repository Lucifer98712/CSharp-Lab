using System;

public class GenericClass<T>
{
    private T genericField;

    public GenericClass(T value)
    {
        genericField = value;
    }

    public T GenericMethod(T parameter)
    {
        Console.WriteLine($"Generic field value: {genericField}");
        Console.WriteLine($"Parameter value: {parameter}");
        return parameter;
    }
}

class Lab11
{
    static void Main(string[] args)
    {
        // Create an instance of GenericClass with int type
        GenericClass<int> intGenericClass = new GenericClass<int>(10);
        int result1 = intGenericClass.GenericMethod(20);
        Console.WriteLine($"Returned value: {result1}");

        // Create an instance of GenericClass with string type
        GenericClass<string> stringGenericClass = new GenericClass<string>("Hello");
        string result2 = stringGenericClass.GenericMethod("World");
        Console.WriteLine($"Returned value: {result2}");
        Console.WriteLine("\nLab no. : 11 \nName : Pratik Shah \nRoll No. : 64/077");

    }
}
