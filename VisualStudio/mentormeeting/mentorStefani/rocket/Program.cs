using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Да се напише програма, която прочита от конзолата цяло четно число N и чертае ракета. 
             Ракетата има ширина – 3 * N колони.
                Входът се чете от конзолата и съдържа само едно цяло четно число в интервала [4...100].
                Да се отпечата на конзолата ракета
            */

            int n = int.Parse(Console.ReadLine());

            //1 cycle for top
            //1 static line
            //1 cycle for body 
            //1 cycle for bottom
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string ('.',n/2-i));

            }

        }
    }
}
