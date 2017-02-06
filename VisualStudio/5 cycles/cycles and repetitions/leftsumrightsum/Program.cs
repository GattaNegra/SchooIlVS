using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftsumrightsum
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Да се напише програма, която въвежда 2 * n цели числа и проверява дали сумата на първите n числа (лява
            //  сума) е равна на сумата на вторите n числа (дясна сума). При равенство печата "Yes" + сумата; иначе печата
            //"No" + разликата.Разликата се изчислява като положително число(по абсолютна стойност).
            //Въведете n.
            // Въведете първите n числа (лявата половина) и ги сумирайте.
            // Въведете още n числа (дясната половина) и ги сумирайте.
            // Изчислете разликата между сумите по абсолютна стойност: Math.Abs(leftSum - rightSum).
            // Ако разликата е 0, отпечатайте "Yes" + сумата; иначе отпечатайте "No" + разликата.

            var leftSum = 0;
            var rightSum = 0;
            var n=0;
            var c = int.Parse(Console.ReadLine());
           // var n1=0;
            for (int i = 0; i < c; i++)
            {
                n = int.Parse(Console.ReadLine());
                leftSum +=n;
            }
         //   Console.WriteLine(leftSum);
            for (int i = 0; i < c; i++)
            {
                n = int.Parse(Console.ReadLine());
                rightSum +=n;
            }
           // Console.WriteLine(rightSum);
          if (leftSum==rightSum)
          {
            Console.WriteLine("yes sum {0}", leftSum=rightSum);
          }
          else
           {
             Console.WriteLine("no diff {0}", Math.Abs(leftSum - rightSum));
          }

            //
        }
    }
}
