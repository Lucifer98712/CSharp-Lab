using System;
using System.Diagnostics;

// Applying built-in attributes
[Obsolete("This method is obsolete. Use NewMethod instead.")]
class MyClass
{
    [Conditional("DEBUG")]
    public void DebugMethod()
    {
        Console.WriteLine("Debug method called.");
    }

    [STAThread]
    public void MethodWithSTAThreadAttribute()
    {
        Console.WriteLine("Method with STAThread attribute called.");
    }
}

class Lab16a
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();

        // Calling methods
        obj.DebugMethod(); // This method will be called only if DEBUG symbol is defined
        obj.MethodWithSTAThreadAttribute();
        Console.WriteLine("\nLab no. : 16a \nName : Pratik Shah \nRoll No. : 64/077");

    }
}
