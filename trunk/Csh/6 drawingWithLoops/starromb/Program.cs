using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starromb
{
    class Program
    {
        static void Main(string[] args)
        {
            var stars = int.Parse(Console.ReadLine());

            

            for (var row = 1; row <= stars; row++)
            {
                for (var col = 1; col <= stars - row; col++)
                    Console.Write(" ");
                Console.Write("*");
                for (var col = 1; col < row; col++)
                    Console.Write(" *");
                Console.WriteLine();
            }

            for (var row = 1; row <= stars-1; row++)
            {
                for (var col = 1; col <= row; col++)
                    Console.Write(" ");
                Console.Write("*");
                for (var col = 1; col < stars-row; col++)
                    Console.Write(" *");
                Console.WriteLine();
            }


        }
    }
}

