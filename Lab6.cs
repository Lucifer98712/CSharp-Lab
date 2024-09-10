using System;

public class Parent
{
    public virtual void Display()
    {
        Console.WriteLine("Parent's Display method");
    }

    public void Show()
    {
        Console.WriteLine("Parent's Show method");
    }
}

public class Child : Parent
{
    public override void Display()
    {
        Console.WriteLine("Child's Display method");
    }

    public new void Show()
    {
        Console.WriteLine("Child's Show method");
    }
}

class Lab6
{
    static void Main(string[] args)
    {
        Parent parent = new Parent();
        parent.Display(); // Output: Parent's Display method
        parent.Show();    // Output: Parent's Show method

        Child child = new Child();
        child.Display();  // Output: Child's Display method
        child.Show();     // Output: Child's Show method

        Parent referenceToChild = new Child();
       
        // Output: Child's Display method (dynamic polymorphism)
        referenceToChild.Display();

        // Output: Parent's Show method (no dynamic polymorphism, hiding)
        referenceToChild.Show();

        Console.WriteLine("\nLab no. : 6 \nName : Pratik Shah \nRoll No. : 64/077");

    }
}
