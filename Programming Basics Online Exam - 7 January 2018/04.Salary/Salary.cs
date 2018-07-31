using System;

public class Salary
{
    public static void Main()
    {
        double salary = double.Parse(Console.ReadLine());
        int workTime = int.Parse(Console.ReadLine());
        string syndicate = Console.ReadLine();

        int moreYears = 0;

        for (int i = 1; i <= 1000; i++)
        {
            salary += salary * 0.06;

            if (i % 5 == 0 && i != 1)
            {
                salary += 100;

                if (i % 10 == 0)
                {
                    salary += 100;
                }
            }
            else if (syndicate == "Yes" && i % 5 != 0)
            {
                salary *= 0.99;
            }

            if (salary >= 5000 && i <= workTime)
            {
                Console.WriteLine($"Current salary: 5000");
                Console.WriteLine("0 more years to max salary.");
                return;
            }

            if (i == workTime)
            {
                Console.WriteLine($"Current salary: {salary:F2}");
            }

            if (salary >= 5000)
            {
                moreYears = (i - 1) - workTime;
                Console.WriteLine($"{moreYears} more years to max salary.");
                return;
            }
        }
    }
}