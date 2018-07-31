using System;

public class WorkHours
{
    public static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int workingHours = workers * days * 8;

        if (workingHours >= hours)
        {
            int result = workingHours - hours;

            Console.WriteLine("{0} hours left", result);
        }
        else
        {
            int result = hours - workingHours;
            int penalties = result * days;

            Console.WriteLine("{0} overtime", result);
            Console.WriteLine("Penalties: {0}", penalties);
        }
    }
}