using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string simvol = Console.ReadLine();

            if (simvol == "+")
            {
                double result = number1 + number2;
                Console.Write("{0} + {1} = {2}",number1,number2,result);
                if (result % 2 == 0 && result != 1)
                {
                    Console.WriteLine(" - even");
                }
                else
                {
                    Console.WriteLine(" - odd");
                }
            }
            else if (simvol == "-")
            {
                double result = number1 - number2;
                Console.Write("{0} - {1} = {2}", number1, number2, result);
                if (result % 2 == 0 && result != 1)
                {
                    Console.WriteLine(" - even");
                }
                else
                {
                    Console.WriteLine(" - odd");
                }
            }
            else if (simvol == "*")
            {
                double result = number1 * number2;
                Console.Write("{0} * {1} = {2}", number1, number2, result);
                if (result % 2 == 0 && result != 1)
                {
                    Console.WriteLine(" - even");
                }
                else
                {
                    Console.WriteLine(" - odd");
                }
            }
            else if (simvol == "/")
            {
                double result = number1 / number2;
                if (number1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number2);
                }
                else if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    Console.WriteLine($"{number1} / {number2} = {result:F2}");
                }
            }
            else if (simvol == "%")
            {
                double result = number1 % number2;
                if (number1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number2);
                }
                else if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    Console.WriteLine("{0} % {1} = {2}", number1, number2, result);
                }
            }
            
        }
    }
}
