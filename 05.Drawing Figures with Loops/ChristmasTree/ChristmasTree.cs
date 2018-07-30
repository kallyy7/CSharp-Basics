using System;

class ChristmasTree
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int row = 1; row <= inputNumber + 1; row++)
        {
            for (int col = 1; col <= (inputNumber + 1) - row; col++)
            {
                Console.Write(" ");
            }

            for (int col = 3; col <= row + 1; col++)
            {
                Console.Write("*");
            }
            // second part

            for (int Col = 0; Col <= row; Col++)
            {
                if (Col == 0)
                {
                    Console.Write(" | ");
                }
                else if (Col > 1)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }

    }
}
