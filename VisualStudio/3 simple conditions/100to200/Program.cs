using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100to200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //<=99
            if (num <= 99)
            {
                Console.WriteLine("Less than 100");
            }
            //<=200
            else if(num <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            //>200
            else if  (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else
                return;

        }
    }
}
