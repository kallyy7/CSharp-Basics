using System;

class SmallShop
{
    public static void Main()
    {
        string product = Console.ReadLine();
        string city = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        if (product == "coffee")
        {
            if (city == "Sofia")
            {
                Console.WriteLine(Math.Round((quantity * 0.50), 2));
            }
            else if (city == "Plovdiv")
            {
                Console.WriteLine(Math.Round((quantity * 0.40), 2));
            }
            else if (city == "Varna")
            {
                Console.WriteLine(Math.Round((quantity * 0.45), 2));
            }
        }
        else if (product == "water")
        {
            if (city == "Sofia")
            {
                Console.WriteLine(Math.Round((quantity * 0.80), 2));
            }
            else if (city == "Plovdiv")
            {
                Console.WriteLine(Math.Round((quantity * 0.70), 2));
            }
            else if (city == "Varna")
            {
                Console.WriteLine(Math.Round((quantity * 0.70), 2));
            }
        }
        else if (product == "beer")
        {
            if (city == "Sofia")
            {
                Console.WriteLine(Math.Round((quantity * 1.20), 2));
            }
            else if (city == "Plovdiv")
            {
                Console.WriteLine(Math.Round((quantity * 1.15), 2));
            }
            else if (city == "Varna")
            {
                Console.WriteLine(Math.Round((quantity * 1.10), 2));
            }

        }
        else if (product == "sweets")
        {
            if (city == "Sofia")
            {
                Console.WriteLine(Math.Round((quantity * 1.45), 2));
            }
            else if (city == "Plovdiv")
            {
                Console.WriteLine(Math.Round((quantity * 1.30), 2));
            }
            else if (city == "Varna")
            {
                Console.WriteLine(Math.Round((quantity * 1.35), 2));
            }
        }
        else if (product == "peanuts")
        {
            if (city == "Sofia")
            {
                Console.WriteLine(Math.Round((quantity * 1.60), 2));
            }
            else if (city == "Plovdiv")
            {
                Console.WriteLine(Math.Round((quantity * 1.50), 2));
            }
            else if (city == "Varna")
            {
                Console.WriteLine(Math.Round((quantity * 1.55), 2));
            }
        }
    }
}
