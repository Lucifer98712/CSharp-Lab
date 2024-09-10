using System;

namespace Lab
{
    internal class Lab1
    {
        int x, y;
        static int num = 0;
        Lab1()//Default Constructor
        {
            Console.WriteLine("Default Constructor Called!");
        }

        Lab1(int x, int y)//Parameterized Constructor
        {
            Console.WriteLine("Parameterized Constructor Called!");
        }

        public Lab1(Lab1 L)//Copy Constructor
        {
            Console.WriteLine("Copy Constructor Called!");
        }

        /* private Lab1()//Private Constructor
         {
             Console.WriteLine("Private Constructor Called");
         }*/

        static Lab1(){//Static Constructor
            Console.WriteLine("Static Constructor Called!");
        }

        static void Main(string[] args)
        {
            Lab1 defCon = new Lab1();
            Lab1 paraCon = new Lab1(1, 2);
            Lab1 cpyCon = new Lab1(paraCon);
            //Console.WriteLine(Lab1.num);
            Console.WriteLine("Lab no. : 1 \nName : Pratik Shah \nRoll No. : 64/077");

        }
    }
}

