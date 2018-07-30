using System;

public class ChristmasPreparation
{
    public static void Main()
    {
        int rollsWrappingPaper = int.Parse(Console.ReadLine());
        int rollsTextile = int.Parse(Console.ReadLine());
        double glue = double.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        double wrappingPaperPrice = rollsWrappingPaper * 5.80;
        double textilePrice = rollsTextile * 7.20;
        double gluePrice = glue * 1.20;
        double allPrice = wrappingPaperPrice + textilePrice + gluePrice;
        double allPriceWithDiscount = allPrice - ((allPrice * discount) / 100);

        Console.WriteLine($"{allPriceWithDiscount:F3}");
    }
}