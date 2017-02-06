using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMP1
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var homeTown = Console.ReadLine();
            var currentTown = Console.ReadLine();
           
            bool ableToVote = age >= 18 && homeTown == currentTown;

            if (ableToVote)
            {
                    Console.WriteLine("Able to Vote");

            }
            else
            {
                Console.WriteLine("Not Able To Vote");
            }
          



        }
    }
}
