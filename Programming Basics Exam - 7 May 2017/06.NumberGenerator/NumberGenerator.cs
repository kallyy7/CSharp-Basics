using System;

public class NumberGenerator
{
    public static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());
        int specialNumber = int.Parse(Console.ReadLine());
        int controlNumber = int.Parse(Console.ReadLine());

        for (int a = M; a >= 1; a--)
        {
            for (int b = N; b >= 1; b--)
            {
                for (int c = L; c >= 1; c--)
                {
                    int num = a * 100 + b * 10 + c;
                    Console.WriteLine(num);

                    if (specialNumber > controlNumber)
                    {
                        break;
                    }

                    if (num % 3 == 0)
                    {
                        specialNumber += 5;
                    }
                    else if (num % 5 == 0 && num % 10 != 0)
                    {
                        specialNumber -= 2;
                    }
                    else if (num % 2 == 0 && num != 1)
                    {
                        specialNumber *= 2;
                    }
                }
            }
        }

        if (specialNumber < controlNumber)
        {
            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
        }
        else
        {
            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
        }
    }
}