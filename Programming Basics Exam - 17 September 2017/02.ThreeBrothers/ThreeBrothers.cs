using System;

public class ThreeBrothers
{
    public static void Main()
    {
        double firstBrother = double.Parse(Console.ReadLine());
        double secondBrother = double.Parse(Console.ReadLine());
        double thirdBrother = double.Parse(Console.ReadLine());
        double father = double.Parse(Console.ReadLine());

        double totalTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
        double timeWithBreak = totalTime + (totalTime * 0.15);

        Console.Write("Cleaning time: ");
        Console.WriteLine($"{timeWithBreak + 0,01:F2}");

        double leftTime = father - timeWithBreak;

        if (leftTime > 0)
        {
            Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(leftTime));
        }
        else
        {
            double NoSurp = timeWithBreak - father;
            Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(NoSurp));
        }
    }
}