using System;

public class EnergyLoss
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int dancers = int.Parse(Console.ReadLine());

        int totalEnergy = 100 * dancers * days;
        int evenDevenH = 0;
        int evenDoddH = 0;
        int oddDevenH = 0;
        int oddDoddH = 0;
        double leftEnergy = 0;
        double leftEnPerDancer = 0;

        for (int i = 1; i <= days; i++)
        {
            int hours = int.Parse(Console.ReadLine());

            if (i % 2 == 0 && i != 1)
            {
                if (hours % 2 == 0 && hours != 1)
                {
                    int sum = 68 * dancers;
                    evenDevenH += sum;
                }
                else
                {
                    int sum = 65 * dancers;
                    evenDoddH += sum;
                }
            }
            else
            {
                if (hours % 2 == 0 && hours != 1)
                {
                    int sum = 49 * dancers;
                    oddDevenH += sum;
                }
                else
                {
                    int sum = 30 * dancers;
                    oddDoddH += sum;
                }
            }
        }
        leftEnergy = totalEnergy - (evenDevenH + evenDoddH + oddDevenH + oddDoddH);
        leftEnPerDancer = leftEnergy / dancers / days;

        if (leftEnPerDancer <= 50)
        {
            Console.WriteLine($"They are wasted! Energy left: {leftEnPerDancer:F2}");
        }
        else
        {
            Console.WriteLine($"They feel good! Energy left: {leftEnPerDancer:F2}");
        }
    }
}