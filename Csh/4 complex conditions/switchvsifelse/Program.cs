using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchvsifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Black (B), White (W)");
            //var catColor = char.Parse(Console.ReadLine());
            var catColor = char.ToLower(char.Parse(Console.ReadLine()));
            switch (catColor)
            {
              //  case 'B':
                case 'b':
                    Console.WriteLine("The Cat Is Black");
                break;

                //case 'W':
                case 'w':
                    Console.WriteLine("The Cat Is White");
                    break;

                default:
                    Console.WriteLine("You have Entered Invalid Letter");
                break;
            }


        }
    }
}
