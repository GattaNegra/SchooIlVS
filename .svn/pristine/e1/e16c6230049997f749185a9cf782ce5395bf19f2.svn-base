using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamondd
{
    class Program
    {
        static void Main(string[] args)
        {

            int z = int.Parse(Console.ReadLine());
            int s = 1;
            int s1 = (z % 2) == 0 ? 2 : 1;
            int d1 = (z % 2) == 0 ? 2 : 1;
            int d2 = ((z - d1) - 2) / 2;
            //if1 or 2
            if (z == 1)
            {
                Console.WriteLine("*");
                return;
            }
            if (z == 2)
            {
                Console.WriteLine("**");
                return;
            }
            //firstline
            Console.WriteLine(
                new string('-', (z - 1) / 2) +
                new string('*', s1) +
                new string('-', (z - 1) / 2)
                );
            //top
            for (int i = 0; i < (z - 1) / 2; i++)
            {
                Console.WriteLine(
                    new string('-', d2) +
                    "*" +
                    new string('-', d1) +
                    "*" +
                    new string('-', d2)
                    );
                d1 += 2;
                d2 -= 1;
            }
            d2 = 1;
            d1 -= 4;
            //bottom -1 lines
            for (int i = 0; i < ((z - 1) / 2) - 1; i++)
            {
                Console.WriteLine(
                    new string('-', d2) +
                    "*" +
                    new string('-', d1) +
                    "*" +
                    new string('-', d2)
                    );
                d1 -= 2;
                d2 += 1;
            }
            //last (in) line :)
            Console.WriteLine(
               new string('-', (z - 1) / 2) +
               new string('*', s1) +
               new string('-', (z - 1) / 2)
               );
        }
    }
}