using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace одй
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Да се напише програма, която прочита от конзолата цяло нечетно число N и чертае лисица,
             Лисицата има ширина – 2 * N + 3 колони.
             Входът се чете от конзолата и съдържа само едно цяло нечетно число в интервала [7...57].
             Изход : Да се отпечата на конзолата лисица,
            */
            int n = int.Parse(Console.ReadLine());

            var col = (2 * n) + 3;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string ('*',i) +"\\"+new string ('-',col-4-(2*i)) + "\n");
            }
                             
          

        }
    }
}
