using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace axe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Да се напише програма, която прочита цяло число N и чертае брадва.
           Ширината на брадвата е 5 * N колони.
           Входът е цяло число N в интервала[2..42].
           Да се отпечата на конзолата брадва.*/

            //cycle top
            //cycle handle
            //cycle bottom

            int n =int.Parse(Console.ReadLine());
            Console.WriteLine(new string ('-',3 * n - n / 2 + 1)  +
                new string ('*',n/2)  +
                new string('*', n -1) +
                new string('*', n / 2) +
                new string ('-', (n+1) / 2));
        }
    }
}
