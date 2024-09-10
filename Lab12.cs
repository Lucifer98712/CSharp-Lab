using System;
using System.IO;

class Lab12
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text to write to file (type 'exit' to finish):");

        // Open or create a file for writing
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            string input;
            do
            {
                // Read input from the console
                input = Console.ReadLine();

                // Write input to the file
                if (input.ToLower() != "exit")
                {
                    writer.WriteLine(input);
                }
            } while (input.ToLower() != "exit");
        }

        Console.WriteLine("Data written to file successfully.");
        Console.WriteLine("\nLab no. : 12 \nName : Pratik Shah \nRoll No. : 64/077");

    }
}
