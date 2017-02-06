using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace _1000days
{
    class Program
    {
        static void Main(string[] args)
        {
                 var BD= DateTime
                .ParseExact(Console.ReadLine(),
                "dd-MM-yyyy",
                
                CultureInfo.InvariantCulture);
            var thousandDaysAfterBirth = BD.AddDays(999);
            Console.WriteLine(thousandDaysAfterBirth.ToString("dd-MM-yyy"));

        }
    }
}
