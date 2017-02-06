using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace факториел
{
    class Program
    {
        static void Main(string[] args)
        {

           int c = int.Parse(Console.ReadLine());
            var f = 1;
            //1<=c<=12
            for (int i = 1 ; i <= c; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);    
        }
    }
}
