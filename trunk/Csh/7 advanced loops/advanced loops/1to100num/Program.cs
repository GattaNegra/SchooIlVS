using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to100num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in the range[1...100]:");
            int num = int.Parse(Console.ReadLine());
            
            while (1 > num || num > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Enter a number in the range[1...100]:");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", num);



        }
    }
}
