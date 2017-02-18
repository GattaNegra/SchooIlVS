using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            //var even = (num % 2 == 0).

            var num = double.Parse(Console.ReadLine());
            var even = (num % 2 == 0);
            if (even)
            {
                Console.WriteLine("even");
            }
            else
            { 
            Console.WriteLine("odd");
        }

        }
    }
}
