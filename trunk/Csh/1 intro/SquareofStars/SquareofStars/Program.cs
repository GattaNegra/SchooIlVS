using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number?");
            var n = int.Parse(Console.ReadLine());

            // TODO: print the rectangle
            for (int horiz = 1; horiz <= n; horiz++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int vert =1;  vert<=n-2; vert++)
            { 
                Console.Write("*");

                for (int mid = 1; mid <= n-2; mid++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            for (int horiz2 = 1; horiz2 <= n; horiz2++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
