using System;

public class Bills
{
    public static void Main()
    {
        int months = int.Parse(Console.ReadLine());
        double water = 20;
        double internet = 15;
        double electricity = 0;
        double other = 0;
        double average = 0;

        for (int i = 1; i <= months; i++)
        {
            double electricityBills = double.Parse(Console.ReadLine());
            electricity += electricityBills;
            double sum = (electricityBills + water + internet) + ((electricityBills + water + internet) * 0.20);
            other += sum;
        }
        water *= months;
        internet *= months;
        average = (electricity + water + internet + other) / months;

        Console.WriteLine($"Electricity: {electricity:F2} lv");
        Console.WriteLine($"Water: {water:F2} lv");
        Console.WriteLine($"Internet: {internet:F2} lv");
        Console.WriteLine($"Other: {other:F2} lv");
        Console.WriteLine($"Average: {average:F2} lv");
    }
}