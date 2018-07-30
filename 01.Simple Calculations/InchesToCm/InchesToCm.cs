using System;

namespace program
{
    class InchesToCm
    {
        public static void Main()
        {
            Console.Write("inches= ");
            
            const double inch = 2.54;
            double number = double.Parse(Console.ReadLine());
            double convert = number * inch;
            
            Console.Write("centimeters= ");
            Console.WriteLine(convert);            
        }
    }
}
