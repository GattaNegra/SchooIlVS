using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personfrom
{
    class Program
    {
        static void Main(string[] args)
        {
            // “You are <firstName> <lastName>, a <age>-years old person from <town>”.
            var fName =Console.ReadLine();
            var lName =Console.ReadLine();
            var age =Console.ReadLine();
            var town =Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", fName,lName,age,town);
        }
    }
}
