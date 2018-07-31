using System;

public class JuiceDiet
{
    public static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int juiceMax = int.Parse(Console.ReadLine());

        double max = 0;
        int maxRasp = 0;
        int maxStraw = 0;
        int maxCherries = 0;

        for (int ras = 0; ras <= r; ras++)
        {
            for (int str = 0; str <= s; str++)
            {
                for (int che = 0; che <= c; che++)
                {
                    double cherries = 15 * che;
                    double strawberries = 7.5 * str;
                    double raspberries = 4.5 * ras;
                    double juice = raspberries + strawberries + cherries;

                    if (juice <= juiceMax)
                    {
                        if (juice > max)
                        {
                            maxRasp = ras;
                            maxStraw = str;
                            maxCherries = che;
                            max = juice;
                        }
                    }

                    if (juice == juiceMax || juice == juiceMax - 1)
                    {
                        if (cherries > strawberries && cherries > raspberries || strawberries > raspberries)
                        {
                            Console.WriteLine($"{ras} Raspberries, {str} Strawberries, {che} Cherries. Juice: {juice} ml.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"{ras} Raspberries, {str} Strawberries, {che} Cherries. Juice: {juice} ml.");
                            return;
                        }
                    }
                }
            }
        }

        Console.WriteLine($"{maxRasp} Raspberries, {maxStraw} Strawberries, {maxCherries} Cherries. Juice: {max} ml.");
    }
}
