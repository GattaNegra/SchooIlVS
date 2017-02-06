using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choco
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int places = int.Parse(Console.ReadLine());
            for (int choc = 1; choc <= places; choc++)
            {
                int n = int.Parse(Console.ReadLine());
total += n;
            }
             
            Console.WriteLine("Total: {0}", total); 
        }
    }
}
