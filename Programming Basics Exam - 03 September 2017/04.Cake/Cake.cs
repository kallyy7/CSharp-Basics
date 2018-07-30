using System;

public class Cake
{
    public static void Main()
    {
        int widthCake = int.Parse(Console.ReadLine());
        int lenghtCake = int.Parse(Console.ReadLine());
        int S = widthCake * lenghtCake;
        int left = S;

        while (left >= 0)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                left -= n;
            }
            catch
            {
                Console.WriteLine("{0} pieces are left.", left);
                break;
            }
        }

        if (left < 0)
        {
            Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(left));
        }
    }
}
