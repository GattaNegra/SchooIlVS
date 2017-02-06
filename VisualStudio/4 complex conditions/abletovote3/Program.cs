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
            Console.WriteLine("Insert Age");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert HomeTown");
            var homeTown = Console.ReadLine();
            Console.WriteLine("insert CurrentTown");
            var currentTown = Console.ReadLine();

            bool notableToVote = age < 18 || homeTown!= currentTown;

            if (!notableToVote)
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
