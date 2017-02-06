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

            var n= int.Parse(Console.ReadLine());
            var num = 1;
            Console.WriteLine(num);
            for (int i = 0; i < n; i++)
            {
                num = num * 2;
                Console.WriteLine(num);
            }
            
        }
    }
}
