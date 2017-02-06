using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialnums
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Да се напише програма, която въвежда едно цяло число N 
            и генерира всички възможни “специални” числа от 1111 до 9999. 
            За да бъде “специалнo” едно число, то трябва да отговаря на следното условие:

            N да се дели на всяка една от неговите цифри без остатък.
            Пример: 

            N = 16, 2418 е специално число:
            16 / 2 = 8 без остатък
            16 / 4 = 4 без остатък
            16 / 1 = 16 без остатък
            16 / 8 = 2 без остатък

            */


            int n = int.Parse(Console.ReadLine());
            int l = 0;
            int s = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                var num = i;
               // Console.WriteLine(num);

                while (num != 0)
                {
                    l = num % 10;
                    num = num / 10;
                    //  Console.WriteLine(l);

                   
                    if (n/l==0)
                    {
                        Console.WriteLine(s);
                    }

                }


                
            }
        }
    }
}

