using System;

public class MatchTickets
{
    public static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int nOfPeople = int.Parse(Console.ReadLine());
        double leftMoney = 0;
        double transport = 0;

        if (nOfPeople >= 1 && nOfPeople <= 4)
        {
            transport = budget * 0.75;
        }
        else if (nOfPeople >= 5 && nOfPeople <= 9)
        {
            transport = budget * 0.60;
        }
        else if (nOfPeople >= 10 && nOfPeople <= 24)
        {
            transport = budget * 0.50;
        }
        else if (nOfPeople >= 25 && nOfPeople <= 49)
        {
            transport = budget * 0.40;
        }
        else if (nOfPeople >= 50)
        {
            transport = budget * 0.25;
        }
        leftMoney = budget - transport;

        if (category == "Normal")
        {
            double priceForTickets = nOfPeople * 249.99;

            if (leftMoney > priceForTickets)
            {
                double left = leftMoney - priceForTickets;
                Console.WriteLine($"Yes! You have {left:F2} leva left.");
            }
            else
            {
                double need = priceForTickets - leftMoney;
                Console.WriteLine($"Not enough money! You need {need:F2} leva.");
            }
        }
        else if (category == "VIP")
        {
            double priceForTckets = nOfPeople * 499.99;

            if (leftMoney > priceForTckets)
            {
                double left = leftMoney - priceForTckets;
                Console.WriteLine($"Yes! You have {left:F2} leva left.");
            }
            else
            {
                double need = priceForTckets - leftMoney;
                Console.WriteLine($"Not enough money! You need {need:F2} leva.");
            }
        }
    }
}

