using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashtichka
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int c = int.Parse(Console.ReadLine());
            int star = (c % 2) == 0 ? 2 : 1;
            int dash = (c-1)/2;

            
            for (int i = 0; i < (c + 1) / 2; i++)
            {

                Console.WriteLine(new string ('-',dash)+new string ('*',star) + new string('-', dash));
                star += 2;
                dash--;
            }

            for (int i = 0; i < c/2; i++)
            {
                Console.Write("|"+new string ('*',c-2)+"|\n");
            }

        }
    }
}
