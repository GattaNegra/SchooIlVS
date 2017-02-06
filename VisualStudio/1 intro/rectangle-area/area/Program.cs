using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for side A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for side B");
            double h = double.Parse(Console.ReadLine());
            double area = a * h;
            Math.Round(area);
            Console.WriteLine("Rectangle Area = {0}", area);
        }
    }
}