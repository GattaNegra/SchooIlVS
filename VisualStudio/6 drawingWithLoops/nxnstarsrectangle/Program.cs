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
            var stars = int.Parse(Console.ReadLine()); 
            for (var i = 1; i <= stars; i++)
            {
                Console.WriteLine(new string('*', stars));
            }
        }
    }
}
