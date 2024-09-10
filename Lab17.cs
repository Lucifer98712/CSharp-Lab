using System;
using System.Threading.Tasks;

class Lab17
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Main method started.");

        // Call asynchronous method
        await Task.Delay(2000); // Simulate delay of 2 seconds

        Console.WriteLine("Asynchronous operation completed.");

        Console.WriteLine("Main method finished.");
        Console.WriteLine("\nLab no. : 17 \nName : Pratik Shah \nRoll No. : 64/077");

    }
}
