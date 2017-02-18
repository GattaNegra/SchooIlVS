using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int min = 0;
            int sec = 00;

            int total = ((a + b + c));
            if (total<=59)
            {
                min = 0;
                sec = total;
            }

            if (total >=60)//&&total<=119)
            {
                min = total/60;
 sec = total%60;
            }

            Console.WriteLine("{0}:{1}",min,sec);
        }
    }
}
