using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            //traPEZOID  (b1 + b2) * h / 2.
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var sqTr = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid area = {0}",sqTr);
        }
    }
}
