using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitorveg
{
    class Program
    {
        static void Main(string[] args)
        {
            //въвежда име на продукт и проверява дали е плод или зеленчук.
            //Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes
            //Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot
            //Всички останали са "unknown"
            //Да се изведе “fruit”, “vegetable” или “unknown” според въведения продукт.

            var unit = Console.ReadLine().ToLower();
            if (unit == "banana" || unit == "apple" || unit == "kiwi" || unit == "cherry" || unit == "lemon" || unit == "grapes")
            {
                Console.WriteLine("fruit");
            }
           else if (unit == "tomato" || unit == "cucumber" || unit == "pepper" || unit == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");

            }

        }
    }
}
