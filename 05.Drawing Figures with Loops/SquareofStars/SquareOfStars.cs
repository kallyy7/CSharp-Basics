using System;

class SquareOfStars
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int row = 1; row <= inputNumber; row++)
        {
            Console.Write("*");

            for (int col = 1; col < inputNumber; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
