using System;

// Delegate
delegate void MyDelegate(int x);

class Lab9
{
    static void Main(string[] args)
    {
        // Delegate
        MyDelegate delegateInstance = new MyDelegate(DisplayNumber);
        delegateInstance(5); // Output: Number: 5

        // Multicast delegate
        MyDelegate multiDelegate = DisplayNumber;
        multiDelegate += DisplaySquare;
        multiDelegate(5); // Output: Number: 5, Square: 25

        // Func delegate
        Func<int, int> squareFunction = Square;
        int result = squareFunction(5); // Output: 25
        Console.WriteLine($"Square using Func delegate: {result}");

        // Action delegate
        Action<int> displayAction = DisplayNumber;
        displayAction(5); // Output: Number: 5

        // Anonymous Method
        MyDelegate anonymousDelegate = delegate (int x)
        {
            Console.WriteLine($"Anonymous Method: {x}");
        };
        anonymousDelegate(5); // Output: Anonymous Method: 5

        // Event
        Counter counter = new Counter();
        counter.ThresholdReached += ThresholdReachedEventHandler;

        // Increment the counter
        for (int i = 0; i < 10; i++)
        {
            counter.Add(1);
        }
        Console.WriteLine("\nLab no. : 9 \nName : Pratik Shah \nRoll No. : 64/077");

    }

    static void DisplayNumber(int number)
    {
        Console.WriteLine($"Number: {number}");
    }

    static void DisplaySquare(int number)
    {
        Console.WriteLine($"Square: {number * number}");
    }

    static int Square(int number)
    {
        return number * number;
    }

    static void ThresholdReachedEventHandler(object sender, EventArgs e)
    {
        Console.WriteLine("Threshold reached!");
    }
}

class Counter
{
    private int threshold = 5;
    private int total;

    public event EventHandler ThresholdReached;

    public void Add(int x)
    {
        total += x;
        if (total >= threshold)
        {
            OnThresholdReached(EventArgs.Empty);
        }
    }

    protected virtual void OnThresholdReached(EventArgs e)
    {
        EventHandler handler = ThresholdReached;
        handler?.Invoke(this, e);
    }
}
