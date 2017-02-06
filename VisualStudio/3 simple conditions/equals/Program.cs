using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equals
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var c = decimal.Parse(Console.ReadLine());

            bool H = a == b;
            bool Q = b == c;

            if (H && Q)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }
        }
    }
}
