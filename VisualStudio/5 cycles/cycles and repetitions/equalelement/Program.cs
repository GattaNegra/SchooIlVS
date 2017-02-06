using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalelement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Да се напише програма, която въвежда n цели числа и проверява дали сред тях съществува число, което е
            равно на сумата на всички останали. Ако има такъв елемент, печата "Yes" + неговата стойност; иначе печата
            "No" + разликата между най-големия елемент и сумата на останалите (по абсолютна стойност). 
             */

            var n = int.Parse(Console.ReadLine());
            int num=0;
            int sum = 0;
            int numMax = 0;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (numMax<num)
                {
                    numMax = num;
                }
            }
          //  Console.WriteLine("sum {0}",sum);
           // Console.WriteLine("num max {0}",numMax);
            if (sum==(numMax*2))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",numMax);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs((sum-numMax)-numMax));
            }

        }
    }
}
