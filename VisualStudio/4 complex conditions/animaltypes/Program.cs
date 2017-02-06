using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animaltypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //dog->mammal
            //crocodile, tortoise, snake->reptile
            //others->unknown
            var animal = Console.ReadLine().ToLower();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
               default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
