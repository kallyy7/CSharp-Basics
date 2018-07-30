using System;

class SquareFrame
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        if (inputNumber == 2)
        {
            Console.WriteLine("+ +");
        }
        else
        {
            for (int row = 1; row <= inputNumber; row++)
            {
                if (row == 1)
                {
                    Console.Write("+");
                }

                if (row > 1 && row < inputNumber)
                {
                    Console.Write("|");
                }

                if (row == inputNumber)
                {
                    Console.Write("+");
                }

                for (int col = 1; col < inputNumber - 1; col++)
                {
                    Console.Write(" -");

                    if (col == (inputNumber - 2) && row == 1)
                    {
                        Console.Write(" +");
                    }

                    if (col == (inputNumber - 2) && row == inputNumber)
                    {
                        Console.Write(" +");
                    }

                    if (col == (inputNumber - 2) && row != inputNumber && row != 1)
                    {
                        Console.Write(" |");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
