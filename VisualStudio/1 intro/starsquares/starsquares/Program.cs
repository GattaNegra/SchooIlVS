using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starsquares
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            // TODO: print the rectangle N (2 ≤ N ≤100), 

            Console.WriteLine(new string('*', N));
            for (int i = 1; i <= N - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', N - 2) + "*");
            }
            Console.WriteLine(new string('*', N));

        }
    }
}
