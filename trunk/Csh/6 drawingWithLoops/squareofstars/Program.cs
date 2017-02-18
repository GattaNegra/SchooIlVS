using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nxnstarsrectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = int.Parse(Console.ReadLine());
            for (var i = 1; i <= c; i++)
            {
                for (var i1 = 1; i1 <= c-1; i1++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("* ");
            }
        }
    }
}
