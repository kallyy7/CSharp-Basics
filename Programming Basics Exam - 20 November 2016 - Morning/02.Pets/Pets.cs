using System;

public class Pets
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int totalFood = int.Parse(Console.ReadLine());
        double dog = double.Parse(Console.ReadLine());
        double cat = double.Parse(Console.ReadLine());
        double turtle = double.Parse(Console.ReadLine());

        double dogFood = days * dog;
        double catFood = days * cat;
        double turtleFood = days * (turtle / 1000);
        double total = dogFood + catFood + turtleFood;

        if (total <= totalFood)
        {
            double left = Math.Floor(totalFood - total);
            Console.WriteLine("{0} kilos of food left.", left);
        }
        else
        {
            double needed = Math.Ceiling(total - totalFood);
            Console.WriteLine("{0} more kilos of food are needed.", needed);
        }
    }
}