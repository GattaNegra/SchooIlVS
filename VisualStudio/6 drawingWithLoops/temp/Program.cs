using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             —
var count =20;
var hiss="";
for  (var i = o;
i<count; i++)
{
hiss+="s";
}

Console.WriteLine(hiss);
Console.WriteLine(new string(s,count));

             */
            //hour/minute
            //    var hour = 0;
            //   var minute = 0;
            /*  for (var hour = 0; hour < 24; hour++)
              {
                  for (var minute  = 0; minute < 60; minute ++)
                  {
                      Console.WriteLine("{0:00}:{1:00}",hour,minute);
                  }
                 // Console.WriteLine(hour);
              }*/
            /*  for (var i = 1; i <= 10; i++)
              {
                  Console.WriteLine(new string('*', 10));
              }
              */

            int f = int.Parse(Console.ReadLine());
            for (int i = 0; i < f; i++)

            {
                Console.Write("h");

                for (int i1 = 0; i1 < i-1; i1++)
                {
                Console.Write("b");

                }
                Console.WriteLine();
            }
        }
    }
}
