//b)When index is of other than int type
using System;
using System.Collections.Generic;

public class IndexerExample<T>
{
    private Dictionary<string, T> data = new Dictionary<string, T>();

    // Indexer with string type index
    public T this[string key]
    {
        get
        {
            if (data.ContainsKey(key))
                return data[key];
            else
                throw new KeyNotFoundException();
        }
        set
        {
            data[key] = value;
        }
    }
}

class Lab4b
{
    static void Main(string[] args)
    {
        IndexerExample<int> example = new IndexerExample<int>();

        // Setting values using indexer
        example["one"] = 1;
        example["two"] = 2;

        // Accessing values using indexer
        Console.WriteLine(example["one"]); 
        Console.WriteLine(example["two"]); 

        Console.WriteLine("\nLab no. : 4b \nName : Pratik Shah \nRoll No. : 64/077");

    }
}
