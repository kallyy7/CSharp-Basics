using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";
            string data = Console.ReadLine();
            DateTime userDate = DateTime.ParseExact(data, format, null);
            Console.WriteLine(userDate.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
