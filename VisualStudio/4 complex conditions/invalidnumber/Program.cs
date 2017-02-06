using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //число е валидно, ако е в диапазона[100...200] или е 0.
            //Да се напише програма, която въвежда цяло число и печата “invalid” ако въведеното число не е валидно.
            var num = int.Parse(Console.ReadLine());
            if (!(num==0|| num >= 100&&num <=200))
            {
                Console.WriteLine("invalid");
            }
           
        }
    }
}
