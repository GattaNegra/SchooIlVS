using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            Console.WriteLine("Enter first:");
            var int1 = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter second:");
            var int2 = int.Parse(Console.ReadLine());

            if (int1>int2)
            {
                Console.WriteLine("Greater number: {0}", int1);
            }
            else
            {
                Console.WriteLine("Greater number: {0}", int2);
            }
        }
    }
}
