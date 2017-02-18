using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad2deg
{
    class Program
    {
        static void Main(string[] args)
        {
            //1deg=0.01745329252 rads
            double radsInDeg = 57.2957795;
            double inRad = double.Parse(Console.ReadLine());
            double inDeg = inRad * radsInDeg;
            Console.WriteLine(Math.Round(inDeg));

        }
    }
}
