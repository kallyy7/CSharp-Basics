using System;

class USDToBGN
{
    public static void Main()
    {
        double USD = double.Parse(Console.ReadLine());
        double BGN = USD * 1.79549;

        Console.WriteLine("{0} BGN", Math.Round(BGN, 2));
    }
}

