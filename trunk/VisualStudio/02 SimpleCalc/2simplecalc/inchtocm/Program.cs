using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchtocm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1inch=2.54cm
            var inchInCm = 2.54;
            double lengthInInches =double.Parse(Console.ReadLine());
            double lengthInCm = Math.Abs(lengthInInches * inchInCm);
            Console.WriteLine(lengthInCm);
        }
    }
}
