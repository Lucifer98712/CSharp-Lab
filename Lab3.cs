using System;


namespace Lab
{
    internal class Lab3
    {
        static void Main(string[] args)
        {
     

            int[][,] jaggedArray =
            [
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            ];

            Console.Write("{0}", jaggedArray[0][1, 0]);
            Console.WriteLine("\n"+jaggedArray.Length);
            Console.WriteLine("\nLab no. : 3 \nName : Pratik Shah \nRoll No. : 64/077");

        }
    }
}
