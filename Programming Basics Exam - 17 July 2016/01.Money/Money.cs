using System;

public class Money
{
    public static void Main()
    {
        double bitcoin = int.Parse(Console.ReadLine());
        double CNY = double.Parse(Console.ReadLine());
        double comm = double.Parse(Console.ReadLine());

        const double Onebitcoin = 1168;
        const double OneCNY = 0.15;
        const double OneUSD = 1.76;
        const double OneEUR = 1.95;

        double bitcoins = Onebitcoin * bitcoin;
        double cnys = CNY * OneCNY;
        double BGN = cnys * OneUSD;
        double all = (bitcoins + BGN) / 1.95;
        double commission = all * (comm / 100);
        double result = all - commission;

        Console.WriteLine($"{result:F2}");
    }
}
