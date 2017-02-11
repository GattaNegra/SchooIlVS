using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class passwordGuess
    {
        static void Main(string[] args)

        {
            string pass = "s3cr3t!P@ssw0rd";
            string guess = Console.ReadLine();
            if (pass == guess)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
