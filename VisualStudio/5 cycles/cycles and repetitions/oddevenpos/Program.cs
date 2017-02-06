using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddevenpos
{
    class Program
    {
        static void Main(string[] args)
        {
            double evenSum = 0.0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;
            double oddSum = 0.0;
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;

            double n = 0;
            var c = int.Parse(Console.ReadLine());
            for (int i = 1; i <= c; i++)
            {
                n = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += n;

                    if (n < evenMin)
                    {
                        evenMin = n;
                    }
                    if (evenMax < n)
                    {
                        evenMax = n;
                    }
                }

                if (!(i % 2 == 0))
                {
                    oddSum += n;

                    if (oddMin > n)
                    {
                        oddMin = n;
                    }
                    if (oddMax < n)
                    {
                        oddMax = n;
                    }
                }

            }
            Console.WriteLine("oddSum = {0}", oddSum);
            if (oddMin == 0 || oddMin == 1000000000.0)
            {
                Console.WriteLine("oddMin = No");
            }
            else
            Console.WriteLine("oddMin = {0}", oddMin);

            if (oddMax == -1000000000.0)
            {
                Console.WriteLine("oddMax = No");
            }
            else
            Console.WriteLine("oddMax = {0}", oddMax);

            Console.WriteLine("evenSum = {0}", evenSum);

            if( (evenMin == 0 || evenMin == -1000000000.0)|| evenMin == 1000000000.0)
            {
                Console.WriteLine("evenMin = No");
            }
            else
                Console.WriteLine("evenMin = {0}", evenMin);

            if (evenMax == 0 || evenMax == 1000000000.0|| evenMax == -1000000000.0)
            {
                Console.WriteLine("evenMax = No");
            }
            else
                Console.WriteLine("evenMax = {0}", evenMax);





        }
    }
}
