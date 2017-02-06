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
            var homeTown = Console.ReadLine();
            var currentTown = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                if (currentTown == homeTown)
                {
                    Console.WriteLine("Able to Vote");
                }
                else
                {
                    Console.WriteLine("Not Able To Vote in Other Than HomeTown");
                }
            }
            else
	            {
                    Console.WriteLine("Not able to Vote because Underage");
                }
           
        }
    }
}
