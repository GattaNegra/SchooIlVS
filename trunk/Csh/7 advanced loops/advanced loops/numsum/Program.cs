using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = int.Parse(Console.ReadLine());
            var n = 0;
            while (z != 0)
            {
               
                n+=  z % 10;
                z = z / 10;

            }
                System.Console.WriteLine(n);

        }
    }
}
