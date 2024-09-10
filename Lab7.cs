using System;

//Abstract class
abstract class abs
{
    int SSN { get; set; }
}

//Interface
interface IFirstInterface
{
    void myMethod(); // interface method
}

interface ISecondInterface
{
    void myOtherMethod(); // interface method
}

// Implement multiple inheritance using interfaces
class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("Some other text...");
    }
}
class Lab7
{
    static void Main(string[] args)
    {
        //abs a1 = new abs(); //Will generate error
        DemoClass myObj = new DemoClass();
        myObj.myMethod();
        myObj.myOtherMethod();
        Console.WriteLine("\nLab no. : 7 \nName : Pratik Shah \nRoll No. : 64/077");
    }
}