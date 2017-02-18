using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2k_1while
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int num = 1;
            while (num <= c)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }

    }
}

