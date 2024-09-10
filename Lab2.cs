using System;

namespace Lab
{
    internal class Lab2
    {
        public string Name { get; set; }//Auto Property
        public int ID { get; } = 101;//Read-Only Property 


        static void Main(string[] args)
        {
            Lab2 obj1 = new Lab2();
            obj1.Name = "Pratik";
            Console.WriteLine(obj1.Name);
            Console.WriteLine(obj1.ID);
            Console.WriteLine("Lab no. : 2 \nName : Pratik Shah \nRoll No. : 64/077");
        }
    }
}
