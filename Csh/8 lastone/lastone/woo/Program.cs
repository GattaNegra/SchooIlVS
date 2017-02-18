using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace woo
{
    class Program
    {
        static void Main(string[] args)
        {

           var n= int.Parse(Console.ReadLine());
            var c = n;
            var ost2 = 0d;
            var ost3 = 0d;
            var ost4 = 0d;
         //  var p2 = 0d;

            while (n!=0)
            {
                var num =int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    ost2 ++;
                }
                if (num % 3 == 0)
                {
                    ost3 ++;
                }
                if (num % 4 == 0)
                {
                    ost4 ++;
                }

                n -= 1;
               
            }
          //  p2 = ;
            Console.WriteLine("{0:f2}%",((ost2 / c) * 100));
            Console.WriteLine("{0:f2}%", ((ost3 / c) * 100));
            Console.WriteLine("{0:f2}%", ((ost4 / c) * 100));

        }
    }
}
