using System;

class RadiandToDegrees
{
    public static void Main()
    {
        double radians = double.Parse(Console.ReadLine());
        double degrees = (radians / (Math.PI / 180.0) + 0.5);

        Console.WriteLine(Math.Floor(degrees));
    }
}
