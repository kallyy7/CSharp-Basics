using System;

public class FinalCompetition
{
    public static void Main()
    {
        int numberOfDancers = int.Parse(Console.ReadLine());
        double score = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string location = Console.ReadLine();

        double charity = 0;
        double moneyPerDancer = 0;

        if (location == "Bulgaria")
        {
            double money = numberOfDancers * score;

            if (season == "winter")
            {
                money *= 0.92;
            }
            else if (season == "summer")
            {
                money *= 0.95;
            }
            charity = money * 0.75;
            double leftMoney = money - charity;
            moneyPerDancer = leftMoney / numberOfDancers;
        }
        else if (location == "Abroad")
        {
            double money = numberOfDancers * score;
            money = money + (money * 0.5);

            if (season == "winter")
            {
                money *= 0.85;
            }
            else if (season == "summer")
            {
                money *= 0.90;
            }
            charity = money * 0.75;
            double leftMoney = money - charity;
            moneyPerDancer = leftMoney / numberOfDancers;
        }

        Console.WriteLine($"Charity - {charity:F2}");
        Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
    }
}