using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nxnstarsrectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = int.Parse(Console.ReadLine());
           



            //col 
            Console.Write("+ ");
            for (int j = 0; j < c - 2; j++)
            {
                Console.Write("- ");
            }

            Console.WriteLine("+");
           
           

            for (int i = 1; i <= c-2; i++)
            {
                Console.Write("| ");
                for (int j1 = 0; j1 < c-2; j1++)
                {
                    Console.Write("- ");
                }
                
                Console.WriteLine("|");
            }
            Console.Write("+ ");
            for (int j1 = 0; j1 < c - 2; j1++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            //end

        }
    }
}
