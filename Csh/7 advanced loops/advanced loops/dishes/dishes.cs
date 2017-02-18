using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dishes
{
    class dishes
    {
        static void Main(string[] args)
        {
            var dirtydishes = int.Parse(Console.ReadLine());
            var dishesAreWashed = dirtydishes == 0;

            if (!dishesAreWashed)
            {
                do
                {
                    Console.WriteLine("Mrun!");
                    dirtydishes = int.Parse(Console.ReadLine());
                    dishesAreWashed = dirtydishes == 0;
                }
                while (!dishesAreWashed);
                {
                    Console.WriteLine("Nai-Posle!!!");
                }

            }
            else
            {
                Console.WriteLine("Bravo!");

            }
        }
    }
}
