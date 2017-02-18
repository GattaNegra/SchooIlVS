using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double w = Math.Max(x1, x2) - Math.Min(x1, x2);
            double h = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area = {0}", w * h);
            Console.WriteLine("Perimeter = {0}", (w + h)*2);

        }
    }
}
