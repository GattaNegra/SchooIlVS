using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _1000days1
{
    class Program
    {
        static void Main(string[] args)
        {
          var birDay = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",CultureInfo.InvariantCulture);
          var l000plus = birDay.AddDays(999);
          Console.WriteLine(l000plus.ToString("dd-MM-yyy"));

    
        }

    }
    }
