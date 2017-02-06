using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obuvki3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shokoladi");
            int shokoladi = int.Parse(Console.ReadLine());
            Console.WriteLine("Obuvki");
            int kupeniObiuvki = int.Parse(Console.ReadLine());

            bool happy = shokoladi > 0;
            bool happy2 = kupeniObiuvki > 0;

            bool hmood = happy && happy2;
            if (!hmood)
            {
                Console.WriteLine(":(((");
            }
            else
            Console.WriteLine(":)))");

            //if (kupeniObiuvki >= 10 || shokoladi > 0)
            //{
            //    Console.WriteLine(":)");
            //}
            //else if (kupeniObiuvki < 10 || shokoladi == 0)
            //{
            //    Console.WriteLine(":(((");
            //}
            //else if(kupeniObiuvki > 10 || shokoladi == 0)
            //{
            //    Console.WriteLine(":|");
            //}
        }
    }
}
