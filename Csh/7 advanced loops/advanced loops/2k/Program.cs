using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2k
{
    class Program
    {
        static void Main(string[] args)
        {

            int c = int.Parse(Console.ReadLine());
            int num =1 ;
            for (int i = 0; i <= c; i++)
            {
                if (num<=c&&num>0)
                {
                Console.WriteLine(num);

                }
                num = (num * 2) + 1;

                
            }

        }
    }
}
