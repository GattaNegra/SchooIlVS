using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = double.Parse(Console.ReadLine());
            if (n>=5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                return;
            }
        }
    }
}
