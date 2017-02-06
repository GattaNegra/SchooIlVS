using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddevensum
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Да се напише програма, която въвежда n цели числа 
            //и проверява дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции.
            // При равенство да се отпечата "Yes" + сумата; 
            //иначе да се отпечата "No" + разликата.
            //Разликата се изчислява по абсолютна стойност.
            //            Подсказки: Въведете числата едно по едно и изчислете двете суми(числа на четни позиции и числа на
            //            нечетни позиции).
            //Както в предходната задача, изчислете абсолютна стойност на разлката и отпечатайте резултата
            //("Yes" + сумата при разлика 0 или "No" + разликата в противен случай).

            var evenSum=0;
            var oddSum=0;
          //  var num = 0;
            var n = 0;
            var c = int.Parse(Console.ReadLine());
            // var n1=0;
            //

            //
            for (int i = 0; i < c; i++)

            {
                n = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += n;
                }
                if (i % 2 != 0)
                {
                    oddSum += n;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("yes sum {0}", oddSum = evenSum);
            }
            else
            {
                Console.WriteLine("no diff {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
