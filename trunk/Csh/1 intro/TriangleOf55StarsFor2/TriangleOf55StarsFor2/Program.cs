using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55StarsFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 lines
            for (int lines = 1; lines <= 10; lines++)
            {
                // as many stars as lines
                for (int stars = 1; stars <= lines; stars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
