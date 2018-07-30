using System;

public class Hospitality
{
    public static void Main()
    {
        uint b = uint.Parse(Console.ReadLine());
        uint r = uint.Parse(Console.ReadLine());
        uint c = uint.Parse(Console.ReadLine());
        uint t = uint.Parse(Console.ReadLine());
        uint o = uint.Parse(Console.ReadLine());
        decimal n = decimal.Parse(Console.ReadLine());
        decimal u = decimal.Parse(Console.ReadLine());
        decimal s = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());

        decimal builders = b * 1500.04M;
        decimal receptionist = r * 2102.10M;
        decimal chambermaids = c * 1465.46M;
        decimal technicians = t * 2053.33M;
        decimal other = o * 3010.98M;
        decimal nikiSalary = n * u;
        decimal total = s + nikiSalary + other + technicians + chambermaids + receptionist + builders;

        Console.WriteLine($"The amount is: {total:F2} lv.");

        if (total <= m)
        {
            Console.WriteLine($@"YES \ Left: {Math.Abs(m - total):F2} lv.");
        }
        else
        {
            Console.WriteLine($@"NO \ Need more: {Math.Abs(m - total):F2} lv.");
        }
    }
}
