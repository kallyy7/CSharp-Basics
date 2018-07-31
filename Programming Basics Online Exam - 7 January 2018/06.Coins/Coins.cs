using System;

public class Coins
{
    public static void Main()
    {
        double coins = double.Parse(Console.ReadLine());

        double counter = 0;

        while (coins >= 0.00)
        {
            if (coins >= 2)
            {
                counter += 1;
                coins -= 2;
            }
            else if (coins >= 1)
            {
                counter += 1;
                coins -= 1;
            }
            else if (coins >= 0.50)
            {
                counter += 1;
                coins -= 0.50;
            }
            else if (coins >= 0.20)
            {
                counter += 1;
                coins -= 0.20;
            }
            else if (coins >= 0.10)
            {
                counter += 1;
                coins -= 0.10;
            }
            else if (coins >= 0.05)
            {
                counter += 1;
                coins -= 0.05;
            }
            else if (coins >= 0.02)
            {
                counter += 1;
                coins -= 0.02;
            }
            else if (coins >= 0.009)
            {
                counter += 1;
                coins -= 0.01;
                Console.WriteLine(counter);
                return;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(counter);
    }
}