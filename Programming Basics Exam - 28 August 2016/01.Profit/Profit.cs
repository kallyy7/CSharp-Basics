using System;

public class Profit
{
    public static void Main()
    {
        int workingDays = int.Parse(Console.ReadLine());
        decimal money = decimal.Parse(Console.ReadLine());
        decimal courseUSDToBGN = decimal.Parse(Console.ReadLine());

        decimal monthSalary = workingDays * money;
        decimal yearSalary = (monthSalary * 12) + (monthSalary * 2.5);
        decimal taxes = yearSalary * 0.25;
        decimal salaryWithoutTaxesUSD = yearSalary - taxes;
        decimal salaryWithoutTaxesBGN = salaryWithoutTaxesUSD * courseUSDToBGN;
        decimal dailyMoney = salaryWithoutTaxesBGN / 365;

        Console.WriteLine($"{dailyMoney:F2}");
    }
}