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
            //Напишете програма, която въвежда n цели числа (n > 0) 
            //и намира най - голямото измежду тях.
            //Първо се въвежда броят числа n, 
            //а след това самите n числа, по едно на ред.

            int n = int.Parse(Console.ReadLine());
            decimal max = -10000000000000000;
            decimal numMax = 0;
            for (int i = 0; i < n; i++)

            {
                // int num = 0;
                decimal num = decimal.Parse(Console.ReadLine());


                if (num > max)
                {
                    max = num;
                }

                numMax = max;

            }
            Console.WriteLine(numMax);




        }
    }
}