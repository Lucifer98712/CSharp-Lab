using System;

// Custom attribute class
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Applying custom attribute
[Author("Pratik Shah")]
[Author("Alice Smith")]
class MyClass1
{
    [Author("Pratik Shah")]
    public void Method1()
    {
        Console.WriteLine("Method 1 called.");
    }

    [Author("Alice Smith")]
    public void Method2()
    {
        Console.WriteLine("Method 2 called.");
    }
}

class Lab16b
{
    static void Main(string[] args)
    {
        // Retrieving custom attributes
        Type type = typeof(MyClass1);
        object[] classAttributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);
        foreach (AuthorAttribute attribute in classAttributes)
        {
            Console.WriteLine($"Class author: {attribute.Name}");
        }

        var methods = type.GetMethods();
        foreach (var method in methods)
        {
            var methodAttributes = method.GetCustomAttributes(typeof(AuthorAttribute), false);
            foreach (AuthorAttribute attribute in methodAttributes)
            {
                Console.WriteLine($"Method author: {attribute.Name}");
            }            
        }
        Console.WriteLine("\nLab no. : 16b \nName : Pratik Shah \nRoll No. : 64/077");
    }
}
