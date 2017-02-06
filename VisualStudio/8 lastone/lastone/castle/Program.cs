using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Да се напише програма, която прочита от конзолата цяло число n 
             * и чертае крепост с ширина 2 * n 
             * колони и височина n реда като в примерите по-долу.  
             * Лявата и дясната колона във вътрешността си са широки n / 2.
4            * 
/^^\/^^\
|       |
|       |
|       |
|       |
\__/\__/
             */


            int n = int.Parse(Console.ReadLine());
            int dash = n % 2 == 0 ? n-(n / 2) : (n-(n / 2) - 1);
            Console.WriteLine(dash);
            Console.WriteLine("/" + new string('^', n / 2) + "\\" + new string('_', dash) + "/" + new string('^', n / 2) + "\\");
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|" + new string(' ', (2 * n) - 2) + "|");
            }
      
        Console.WriteLine("|" + new string(' ', n / 2) + " " + new string('_', dash) + " " + new string(' ', n / 2) + "|");
            Console.WriteLine("\\" + new string('_', n / 2) + "/" + new string(' ', dash) + "\\" + new string('_', n / 2) + "/");

        }
    }
}

