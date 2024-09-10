//a) When index is of int type
using System;

namespace Lab
{
    public class Lab4
    {
        private string[] data = new string[5];

        // Indexer with int type index
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < data.Length)
                    return data[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < data.Length)
                    data[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }

    class Lab4a
    {
        static void Main(string[] args)
        {
            Lab4 example = new Lab4();

            // Setting values using indexer
            example[0] = "Hello";
            example[1] = "World";

            // Accessing values using indexer
            Console.WriteLine(example[0]); 
            Console.WriteLine(example[1]); 

            
            Console.WriteLine("\nLab no. : 4a \nName : Pratik Shah \nRoll No. : 64/077");

        }
    }
}
