using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (n<=100)
            {
                bonus = 5;
                if (n%2==0)
                {
                    bonus +=1;
                }
                if (n%10==5)
                {
                    bonus+=2;
                }
                
            }
            if (n<1000&&n>=100)
            {
                bonus = (n * 0.2);
                if (n % 2 == 0)
                {
                    bonus+=1;
                }
                if (n % 10 == 5)
                {
                    bonus += 2;
                }
               

            }
            if (n>=1000)
            {
                bonus = (n * 0.1);
                if (n % 2 == 0)
                {
                    bonus += 1;
                }
                if (n % 10 == 5)
                {
                    bonus +=2;
                }
               
            }
            Console.WriteLine(bonus);
            Console.WriteLine(n+bonus);
        }
    }
}
