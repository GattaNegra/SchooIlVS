using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairsums
{
    class pairsums
    {
        static void Main(string[] args)
        {


            int n = (int.Parse(Console.ReadLine()));
          //  Console.WriteLine(n);
            int maxDiff = 0;
            int lastSum = 0;
            for (int i = 0; i < n; i++)
            {
                int firstCurrent = int.Parse(Console.ReadLine());
                int secondCurrent = int.Parse(Console.ReadLine());
                int sum = firstCurrent + secondCurrent;

                if (i==0)
                {
                    lastSum = sum;
                }
                int currentDiff = Math.Abs(lastSum - sum);

                if (currentDiff!=0)
                {
                    if(maxDiff<currentDiff)
                    {
                        maxDiff = currentDiff;
                    }
                    //checkifequal=false
                }
                lastSum = sum;
            }
            if (maxDiff==0)
            {
                Console.WriteLine("yes value= {0}",lastSum);

            }
            else
            {
                Console.WriteLine("no maxdiff={0}",maxDiff);
            }


        }
    }
}
