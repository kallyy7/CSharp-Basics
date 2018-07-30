using System;

class FruitOrVegetable
{
    public static void Main()
    {
        string product = Console.ReadLine();
        bool fruit = product == "banana" || product == "apple" ||
                     product == "kiwi" || product == "cherry" ||
                     product == "lemon" || product == "grapes";
        bool vegetable = product == "tomato" || product == "cucumber" ||
                         product == "pepper" || product == "carrot";

        if (fruit)
        {
            Console.WriteLine("fruit");
        }
        else if (vegetable)
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
