using System;

class PowerOfTwo
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine(sum);
            sum *= 2;
        }
    }
}
