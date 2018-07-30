using System;

class Sunglasses
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        if (inputNumber >= 3 && inputNumber <= 100)
        {
            for (int row = 1; row <= inputNumber; row++)
            {
                //left part
                for (int col = 1; col <= inputNumber * 2; col++)
                {
                    if ((row > 1 && row < inputNumber) && (col > 1 && col < inputNumber * 2))
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                // middle part
                for (int col = 1; col <= inputNumber; col++)
                {
                    if (inputNumber % 2 == 0)
                    {
                        if (row == inputNumber / 2)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (row == (inputNumber / 2) + 1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                // rigth part
                for (int col = 1; col <= inputNumber * 2; col++)
                {
                    if ((row > 1 && row < inputNumber) && (col > 1 && col < inputNumber * 2))
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
