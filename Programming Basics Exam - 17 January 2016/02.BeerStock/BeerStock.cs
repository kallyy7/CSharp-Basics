using System;

public class BeerStock
{
    public static void Main()
    {
        long amountOfBeers = long.Parse(Console.ReadLine());
        string typeOfBeer = Console.ReadLine();

        long cases = 0;
        long sixpack = 0;
        long beers = 0;
        long total = 0;

        while (typeOfBeer != "Exam Over")
        {
            string[] parameters = typeOfBeer.Split();
            long amount = long.Parse(parameters[0]);
            string type = parameters[1];

            if (type == "cases")
            {
                cases += amount;
            }
            else if (type == "sixpacks")
            {
                sixpack += amount;
            }
            else if (type == "beers")
            {
                beers += amount;
            }

            typeOfBeer = Console.ReadLine();
        }

        total = beers + (cases * 24) + (sixpack * 6);

        if (total >= 100)
        {
            total = total - (total / 100);
        }

        long leftOrNeed = Math.Abs(total - amountOfBeers);
        cases = leftOrNeed / 24;
        sixpack = (leftOrNeed - (cases * 24)) / 6;
        beers = (leftOrNeed - (cases * 24)) - (sixpack * 6);

        if (total >= amountOfBeers)
        {
            Console.WriteLine($"Cheers! Beer left:{cases} cases, {sixpack} sixpacks and {beers} beers.");
        }
        else
        {
            Console.WriteLine($"Not enough beer. Beer needed:{cases} cases, {sixpack} sixpacks and {beers} beers.");
        }
    }
}