using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectanglearea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Side:");
            var firstSide =
            decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Side:");
            var secondSide =
            decimal.Parse(Console.ReadLine());
            var area = firstSide * secondSide;

            Console.Write("Area is:");
            Console.WriteLine(area);
        }
    }
}
