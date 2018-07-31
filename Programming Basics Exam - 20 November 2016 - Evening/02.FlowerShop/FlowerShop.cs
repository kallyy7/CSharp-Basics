using System;

public class FlowerShop
{
    public static void Main()
    {
        int magnolias = int.Parse(Console.ReadLine());
        int hyacinths = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int cactus = int.Parse(Console.ReadLine());
        double giftPrice = double.Parse(Console.ReadLine());

        double totalPrice = magnolias * 3.25 + hyacinths * 4 + roses * 3.5 + cactus * 8;
        double earn = totalPrice * 0.95;

        if (earn < giftPrice)
        {
            double needed = Math.Ceiling(giftPrice - earn);
            Console.WriteLine("She will have to borrow {0} leva.", needed);
        }
        else
        {
            double left = Math.Floor(earn - giftPrice);
            Console.WriteLine("She is left with {0} leva.", left);
        }
    }
}