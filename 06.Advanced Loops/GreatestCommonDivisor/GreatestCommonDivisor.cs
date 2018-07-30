using System;

class GreatestCommonDivisor
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int nod = 0;

        while (b != 0)
        {
            nod = b;
            b = a % b;
            a = nod;
        }

        Console.WriteLine(nod);
    }
}
