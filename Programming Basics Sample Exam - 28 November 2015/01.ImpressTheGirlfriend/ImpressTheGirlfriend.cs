using System;

public class ImpressTheGirlfriend
{
    public static void Main()
    {
        uint r = uint.Parse(Console.ReadLine());
        uint d = uint.Parse(Console.ReadLine());
        uint e = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        uint m = uint.Parse(Console.ReadLine());

        double fromRUBToBGN = Math.Ceiling((r / 100) * 3.5);
        double fromUSDToBGN = Math.Ceiling(d * 1.5);
        double fromEURToBGN = Math.Ceiling(e * 1.95);
        double bPerGame = b / 2;
        double mPerGame = m;

        double maximum = Math.Max(fromRUBToBGN, Math.Max(fromUSDToBGN, Math.Max(fromEURToBGN, Math.Max(bPerGame, mPerGame))));
        Console.WriteLine($"{maximum:F2}");
    }
}