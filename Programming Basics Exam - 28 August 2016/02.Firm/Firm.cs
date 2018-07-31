using System;

public class Firm
{
    public static void Main()
    {
        int neededHours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int overtimeWorkers = int.Parse(Console.ReadLine());

        double hoursForWork = (days * 0.9) * 8;
        double overtime = overtimeWorkers * (2 * days);
        double total = Math.Floor(hoursForWork + overtime);

        if (total >= neededHours)
        {
            double left = total - neededHours;
            Console.WriteLine("Yes!{0} hours left.", left);
        }
        else
        {
            double needed = neededHours - total;
            Console.WriteLine("Not enough time!{0} hours needed.", needed);
        }
    }
}