using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumnum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*От първия ред на входа се въвежда броят числа n.
           От следващите n реда се въвежда по едно цяло число.
           Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им. Примери:*/
            int n =int.Parse(Console.ReadLine());
            var sum =0;

            for (int i = 0; i < n; i++)
            {
                int num =int.Parse(
                    Console.ReadLine());
                sum = sum + num;
            }


            Console.WriteLine(sum);


        }
    }
}
