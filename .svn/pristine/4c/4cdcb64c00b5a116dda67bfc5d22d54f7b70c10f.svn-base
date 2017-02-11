using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            String str = "";
            /*
            if (n / 2 == 0)
            {
                str = "-";
            }
            if (n/2!=0)
            {
                str = "*";
            }
            Console.WriteLine(str);

            */
            if (n == 1)
            {
                Console.WriteLine("*");
            }
            if (n % 2 == 1)
            {
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine(new string('-', n / 2 - 1 - i) + "*" + new string('-', 2 * i + 1) + "*" + new string('-', n / 2 - 1 - i));
                }

                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine(new string('-', i + 1) + "*" + new string('-', n - 4 - 2 * 1) + "*" + new string('-', 1 + i));
                }
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
            }

            else if (n % 2 == 0)
            {
                Console.WriteLine(new string('-', n / 2) + "*"
                    + new string('-', n / 2));
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine(new string('-', n / 2 - 1 - i) + "*"
                        + new string('-', 2 * i) + "*"
                        + new string('-', 1 + i));
                }

                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine(new string('-', i + 1) + "*"
                        + new string('-', n - 4 - 2 * i) + "*"
                        + new string('-', i + 1));
                }
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
            }
        }
    }
}
