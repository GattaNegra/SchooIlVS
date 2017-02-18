using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace timeplus15mins
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var sumMins = minutes + 15;
            int sumHr;
            int totalHr;


            if (sumMins > 59)
            {
                sumHr = (hours + 1);
            }
       
            else
            {
                sumHr = hours;
            }
           
            if (sumHr > 23)
            {
                totalHr = sumHr - 24;
            }
            else
            {
                totalHr = sumHr;
            }


            var totalmins = sumMins % 60;

            Console.WriteLine("{0}:{1:00}", totalHr, totalmins);



        }
    }
}
