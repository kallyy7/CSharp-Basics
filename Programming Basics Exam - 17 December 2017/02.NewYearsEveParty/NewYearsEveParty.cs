using System;

public class NewYearsEveParty
{
    public static void Main()
    {
        int numberGuests = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());
        int priceCouvert = 20 * numberGuests;

        if (priceCouvert <= budget)
        {
            double budgetLeft = budget - priceCouvert;
            double fireworks = budgetLeft * 0.4;
            double donation = budgetLeft - fireworks;

            Console.WriteLine("Yes! {0} lv are for fireworks and {1} lv are for donation."
            , Math.Round(fireworks), Math.Round(donation));
        }
        else
        {
            double budgetLeft = priceCouvert - budget;

            Console.WriteLine("They won't have enough money to pay the covert. They will need {0} lv more."
            , Math.Round(budgetLeft));
        }
    }
}