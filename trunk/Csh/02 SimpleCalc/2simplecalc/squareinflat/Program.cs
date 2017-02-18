using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareinflat
{
    class Program
    {
        static void Main(string[] args)
        {
            //a=x2-x1
            //b=y2-y1
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1-y2);

            Console.WriteLine(a*b);
            Console.WriteLine((a+b)*2);

        }
    }
}
