using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuel
{
    class Program
    {
        static void Main(string[] args)
        {
            double harchi = 7.2;
            Console.WriteLine("Fuel Amount?");

            double rezervoar = double.Parse(Console.ReadLine());
            
            Console.WriteLine("How much will we run?");

            int probeg = int.Parse(Console.ReadLine());

            double mayrun = (rezervoar / harchi * probeg);

            bool isFuelEnough = mayrun >= probeg;
            if (!isFuelEnough)
            {
                Console.WriteLine("Run straight to Target");
            }
            
                Console.WriteLine("Stop for Fuel");
                //   Console.WriteLine("Stop for Food");
            
        }
    }
}
