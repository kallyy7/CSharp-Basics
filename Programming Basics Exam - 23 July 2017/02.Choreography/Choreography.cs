using System;

public class Choreography
{
    public static void Main()
    {
        double numberOfSteps = double.Parse(Console.ReadLine());
        double dancers = double.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());

        double stepsForDay = Math.Ceiling(((numberOfSteps / days) / numberOfSteps) * 100);
        double percentSteps = stepsForDay / dancers;

        if (stepsForDay <= 13)
        {
            Console.Write("Yes, they will succeed in that goal! ");
            Console.Write($"{percentSteps:F2}");
            Console.WriteLine("%.");
        }
        else
        {
            Console.Write("No, They will not succeed in that goal! Required ");
            Console.Write($"{percentSteps:F2}");
            Console.WriteLine("% steps to be learned per day.");
        }
    }
}