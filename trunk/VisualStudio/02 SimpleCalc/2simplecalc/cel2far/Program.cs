using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cel2far
{
    class Program
    {
        static void Main(string[] args)
        {
            // *1.8+32
            double inFar = double.Parse(Console.ReadLine());
            var incel = (inFar * 1.8) + 32;
            Console.WriteLine(incel);
        }
    }
}
