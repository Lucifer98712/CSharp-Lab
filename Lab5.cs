using System;
public class Lab5
{
    protected int num = 10;//base field

    public Lab5()
    {
        Console.WriteLine("This is base constructor!");
    }
    public virtual void displayBase()
    {
        Console.WriteLine("This is base class!");
    }
}

public class Lab5inherit : Lab5
{
    public Lab5inherit() : base() //Calling base class constructor
    {
        Console.WriteLine("This is derived constructor");
    }
    public  override void displayBase()
    {
        Console.WriteLine("Value of num : {0}", base.num);//Calling base class field
        
        //Accessing base method
        base.displayBase();
        Console.WriteLine("Displayed in Derived class!");
    }
}

class Lab5Pro
{
    static void Main(string[] args)
    {
        Lab5inherit derived = new Lab5inherit();
        derived.displayBase();
        Console.WriteLine("\nLab no. : 5 \nName : Pratik Shah \nRoll No. : 64/077");
    }
}