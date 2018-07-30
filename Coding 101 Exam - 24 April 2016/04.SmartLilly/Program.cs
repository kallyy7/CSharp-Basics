using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int countSteels = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 10 / 2;
                    countSteels++;
                }
                else
                {
                    toys++;
                }
            }
            decimal sellToysMoney = toys * toyPrice;
            decimal totalMoney = sellToysMoney - countSteels + money;
            if (totalMoney >= price)
            {
                Console.WriteLine("Yes! {0:f2}", totalMoney - price);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", price - totalMoney);
            }
        }
    }
}
