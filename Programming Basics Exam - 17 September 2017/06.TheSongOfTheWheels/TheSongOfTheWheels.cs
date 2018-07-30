using System;

public class TheSongOfTheWheels
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstNum = 0;
        int secondNum = 0;
        int thirdNum = 0;
        int fourthNum = 0;
        int sum = 0;

        for (int a = 1; a <= 9; a++)
        {
            for (int b = 1; b <= 9; b++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    for (int d = 1; d <= 9; d++)
                    {
                        if ((a * b) + (c * d) == n && a < b && c > d)
                        {
                            Console.Write($"{a}{b}{c}{d} ");
                            sum += 1;

                            if (sum == 4)
                            {
                                firstNum = a;
                                secondNum = b;
                                thirdNum = c;
                                fourthNum = d;
                            }
                        }
                    }
                }

            }
        }

        if (firstNum != 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Password: {firstNum}{secondNum}{thirdNum}{fourthNum}");
        }
        else
        {
            if (sum == 0)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
        }
    }
}
