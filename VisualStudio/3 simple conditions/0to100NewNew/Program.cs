using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0to100NewNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string text = "";
            //if =0 &&=100
            if (num == 100)
            //0, 10..19
            {
                // 
            }
            else
            {
                int numf = num / 10;
                int nums = num % 10;

                // {
                //20 .. 99
                // num / 10  (twenty, thirty...)
                //}

                // 
                Console.WriteLine();
                // 1 .. 9

                if (nums > 0 && numf > 0)
                {
                    Console.WriteLine("{0} {1}", texts, textf);
                }
                else
                {
                    Console.WriteLine("{0}{1}", texts, textf);
                }

                //

                string kyp = "";
                if( nums > 0 && numf > 0)
                {
                    kyp = " ";
                }
                Console.WriteLine("{0}{1}{2}", texts, kyp, textf);
            }
        }
    }
}
