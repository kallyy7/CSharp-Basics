using System;

public class MultiplyTable
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstNum = n % 10;
        n /= 10;
        int secondNum = n % 10;
        n /= 10;
        int thirdNum = n % 10;

        for (int a = 1; a <= firstNum; a++)
        {
            for (int b = 1; b <= secondNum; b++)
            {
                for (int c = 1; c <= thirdNum; c++)
                {
                    Console.WriteLine("{0} * {1} * {2} = {3};", a, b, c, (a * b * c));
                }
            }
        }
    }
}
