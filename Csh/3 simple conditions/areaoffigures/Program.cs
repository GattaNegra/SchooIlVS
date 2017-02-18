using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaoffigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //square
            //rectangle
            //circle
            //triangle
            var figureType = Console.ReadLine();
            var figureArea = 1.0;
            if (figureType == "square")
            {
                var squareSide = double.Parse(Console.ReadLine());
                figureArea = squareSide * squareSide;
            }
            else if (figureType == "rectangle")
            {
                var firstside = double.Parse(Console.ReadLine());
                var secondside = double.Parse(Console.ReadLine());
                figureArea = firstside * secondside;
            }

            else if (figureType == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                figureArea = Math.PI * radius * radius;
            }
            else if (figureType == "triangle")
            {
                var firstside = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                figureArea = (firstside * height) / 2;
            }
            Console.WriteLine("{0:F3}",figureArea);
        }
    }
}
