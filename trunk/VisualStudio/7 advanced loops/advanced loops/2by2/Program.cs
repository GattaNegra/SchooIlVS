using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2n
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var num = 1;
            Console.WriteLine(num);
            for (int i = 1; i < n; i+=2)
            {
                num = num *4;
                Console.WriteLine(num);
            }

        }
    }
}
