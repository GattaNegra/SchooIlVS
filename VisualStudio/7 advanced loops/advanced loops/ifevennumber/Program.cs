using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifevennumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int c = int.Parse(Console.ReadLine());
                    if (c % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", c);
                        break;
                    }
                    else
                    {
                     Console.WriteLine("The number is not even.");
                    } 
                }
                catch
                {

                    Console.WriteLine("Invalid Number!");
                }

            }
        }
    }
}
