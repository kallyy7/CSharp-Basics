using System;

public class Digits
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int number = n;
        int thirdNum = n % 10;
        n /= 10;
        int secondNum = n % 10;
        n /= 10;
        int firstNum = n % 10;

        for (int a = 1; a <= firstNum + secondNum; a++)
        {
            for (int b = 1; b <= firstNum + thirdNum; b++)
            {
                if (number % 5 == 0)
                {
                    number -= firstNum;
                }
                else if (number % 3 == 0)
                {
                    number -= secondNum;
                }
                else
                {
                    number += thirdNum;
                }

                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}