using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boots2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kupeniObiuvki = int.Parse(Console.ReadLine());

            bool maleWins = kupeniObiuvki > 10;

            if (kupeniObiuvki < 10)
            {
                Console.WriteLine(":(((");

            }
            else if (kupeniObiuvki == 10)
            {
                Console.WriteLine("Mrun!");
            }
            else if (kupeniObiuvki > 10)
            {
                Console.WriteLine("Magistrala");
            }



        }
    }
}

