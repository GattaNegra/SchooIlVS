using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firsttimesec = int.Parse(Console.ReadLine());
            var secondtimesec = int.Parse(Console.ReadLine());
            var thirdtimesec = int.Parse(Console.ReadLine());

            var sumtimeseconds =
                firsttimesec +
                secondtimesec +
                thirdtimesec;
            var totaltimeinmins = sumtimeseconds / 60;
            var totaltimeinsec = sumtimeseconds % 60;

            Console.WriteLine("{0}:{1:00}", totaltimeinmins, totaltimeinsec);
        }
    }
}
