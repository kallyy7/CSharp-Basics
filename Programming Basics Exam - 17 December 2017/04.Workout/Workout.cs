using System;

public class Workout
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double firstDayKm = double.Parse(Console.ReadLine());

        double total = firstDayKm;
        double km = total;
        double runKm = km;

        for (int i = 1; i <= days; i++)
        {
            double procentUvelichenie = double.Parse(Console.ReadLine());

            runKm = km + (km * (procentUvelichenie / 100));
            km = runKm;
            total += runKm;
        }

        if (total >= 1000)
        {
            double result = Math.Ceiling(total - 1000);
            Console.WriteLine("You've done a great job running {0} more kilometers!", result);
        }
        else
        {
            double result = Math.Ceiling(1000 - total);
            Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", result);
        }
    }
}
