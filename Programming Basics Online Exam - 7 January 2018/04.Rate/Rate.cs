using System;

public class Rate
{
    public static void Main()
    {
        double S = double.Parse(Console.ReadLine());
        int months = int.Parse(Console.ReadLine());

        double simple = S;
        double complex = S;

        for (int a = 1; a <= months; a++)
        {
            simple += S * 0.03;
        }

        for (int b = 1; b <= months; b++)
        {
            complex += complex * 0.027;
        }
        Console.WriteLine($"Simple interest rate: {simple:F2} lv. ");
        Console.WriteLine($"Complex interest rate: {complex:F2} lv.");

        if (simple > complex)
        {
            double win = simple - complex;
            Console.WriteLine($"Choose a simple interest rate. You will win {win:F2} lv.");
        }
        else
        {
            double win = complex - simple;
            Console.WriteLine($"Choose a complex interest rate. You will win {win:F2} lv.");
        }
    }
}