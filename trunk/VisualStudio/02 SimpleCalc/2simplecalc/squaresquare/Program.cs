using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squaresquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var a =int.Parse(Console.ReadLine());
            double square = Math.Pow(a, 2);
            Console.WriteLine(square);
        }
    }
}
