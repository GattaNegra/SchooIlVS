using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b!=0)
            {
                //t is just a temporary variable
                var t = b;
                b = a % b;
                a = t;
            }
            Console.WriteLine(a);

        }
    }
}
