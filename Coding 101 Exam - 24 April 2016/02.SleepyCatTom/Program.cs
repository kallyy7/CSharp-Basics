using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double restDays = days * 127;
            double workDays = (365 - days) * 63;
            double total = restDays + workDays;

            if (30000 < total)
            {
                double needed = 30000 - total;
                double hours = Math.Abs(needed / 60);
                double mins = Math.Abs(needed % 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Floor(hours), mins);

            }
            else if (30000 >= total)
            {
                double left = 30000 - total;
                double hours = Math.Abs(left / 60);
                double mins = Math.Abs(left % 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", Math.Floor(hours), mins);
            }
        }
    }
}
