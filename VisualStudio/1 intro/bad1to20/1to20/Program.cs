using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to20
{
    class Program
    {
        static void Main(string[] args)
        {



            int num;
            num = ((10));
            int count = 1;

            for (int lines = num; lines >= 1; lines--)
            {

                for (int spaces = lines - 1; spaces >= 1; spaces--)
                {
                    Console.Write(" ");

                }
                for (int star = 1; star <= count; star++)
                {
                    Console.Write("*");

                }
                count++;

                Console.WriteLine();
            }

        }
        }


    }
