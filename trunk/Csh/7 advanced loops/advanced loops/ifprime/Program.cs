using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifprime
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            //prime -> b=0 , not prime -> b=1

            var b = 0;

            if (p < 2)
            {
                b = 1;
            }

            else
            {
                if (p == 2)
                {
                    b = 0;
                }

                else
                {
                    int sq = Convert.ToInt32(Math.Truncate(Math.Sqrt(p)));
                 //   Console.WriteLine(sq);

                    for (int i = 2; i <= sq; i++)
                    //prime -> b=0 , not prime -> b=1

                    {
                        if (p % i == 0)
                        {
                            b = 1;
                        }
                        
                     //   Console.WriteLine(i);
                    }
                }
            }
            var s = b == 0 ? "Prime" : "Not Prime";
            Console.WriteLine(s);
        }
    }
}
