using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunglasses
{
    class Program
    {
        static void Main(string[] args)

        {

            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', 2 * c) + new string(' ', c) + new string('*', 2 * c));

            for (int i = 0; i < c - 2; i++)
            {

                if (i == (c - 1) / 2 - 1)
               {
                    Console.WriteLine('*' + new string('/', 2 * c - 2) + '*' + new string('|', c) + '*' + new string('/', 2 * c - 2) + '*');

                }
                else
                {
                Console.WriteLine('*' + new string('/', 2 * c - 2) + '*' + new string(' ', c) + '*' + new string('/', 2 * c - 2) + '*');

                }


            }

        Console.WriteLine(new string('*', 2* c) + new string(' ', c) + new string('*', 2*c));

        }
}
}
