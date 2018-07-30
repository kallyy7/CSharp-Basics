using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n + 1;
            int dash = (2 * n) + 1;
            Console.WriteLine($@"{new string('.', dots)}{new string('_', dash)}{new string('.', dots)}");
            dash -= 2;
            dots -= 1;
            for (int i = 0; i < n + 1; i++)
            {
                if (i == n)
                {
                    Console.WriteLine($@"{new string('.', dots)}//{new string('_', (dash / 2) - 2)}STOP!{new string('_', (dash / 2) - 2)}\\{new string('.', dots)}");
                }
                else
                {
                    Console.WriteLine($@"{new string('.', dots)}//{new string('_', dash)}\\{new string('.', dots)}");
                    dots -= 1;
                    dash += 2;
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($@"{new string('.', dots)}\\{new string('_', dash)}//{new string('.', dots)}");
                dots += 1;
                dash -= 2;
            }
        }
    }
}
