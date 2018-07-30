using System;

class MetricConverter
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string inputUnit = Console.ReadLine();
        string outputUnit = Console.ReadLine();

        if (inputUnit == "mm")
        {
            number = number / 1000;
        }
        else if (inputUnit == "cm")
        {
            number = number / 100;
        }
        else if (inputUnit == "mi")
        {
            number = number / 0.000621371192;
        }
        else if (inputUnit == "in")
        {
            number = number / 39.3700787;
        }
        else if (inputUnit == "km")
        {
            number = number / 0.001;
        }
        else if (inputUnit == "ft")
        {
            number = number / 3.2808399;
        }
        else if (inputUnit == "yd")
        {
            number = number / 1.0936133;
        }
        else if (outputUnit == "mm")
        {
            number = number * 1000;
        }
        else if (outputUnit == "cm")
        {
            number = number * 100;
        }
        else if (outputUnit == "mi")
        {
            number = number * 0.000621371192;
        }
        else if (outputUnit == "in")
        {
            number = number * 39.3700787;
        }
        else if (outputUnit == "km")
        {
            number = number * 0.001;
        }
        else if (outputUnit == "ft")
        {
            number = number * 3.2808399;
        }
        else if (outputUnit == "yd")
        {
            number = number * 1.0936133;
        }

        Console.WriteLine(Math.Round(number, 8));
    }
}

