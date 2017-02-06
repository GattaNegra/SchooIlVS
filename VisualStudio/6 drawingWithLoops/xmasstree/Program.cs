using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmasstree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(new string(' ', num) + " | ");




            for (int i = 1; i <= num; i++)
            {
                Console.Write(new string(' ', num - i));
                

                for (int ii = 1; ii < i; ii++)
                {
                    Console.Write("*");
                }
                Console.Write("*");
                Console.Write(" | ");

                for (int ii = 1; ii < i; ii++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");

            }




        }
    }
}
