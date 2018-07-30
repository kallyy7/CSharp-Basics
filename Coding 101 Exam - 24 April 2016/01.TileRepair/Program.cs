using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam24April2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());
            var totalArea = n * n;
            var areaPlo = w * l;
            var bench = m * o;
            var areaPokr = totalArea - bench;
            var broyPlo = areaPokr / areaPlo;
            var time = broyPlo * 0.2;
            Console.WriteLine($"{broyPlo:F2}");
            Console.WriteLine($"{time:F2}");
        }
    }
}
