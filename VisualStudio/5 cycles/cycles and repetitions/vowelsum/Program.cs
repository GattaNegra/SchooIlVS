using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelsum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която въвежда текст (стринг)и изчислява и отпечатва сумата от стойностите на
            //гласните букви според таблицата по - долу:
            //буква     a    e   i   o   u
            //стойност  1    2   3   4   5
            // Прочетете входния текст s. 
            //Нулирайте сумата.
            // Завъртете цикъл от 0 до s.Length - 1(дължината на текста - 1).
            // Проверете всяка буква s[i] дали е гласна и съответно добавете към сумата стойността й.
            

           int total = 0;

            string s = Console.ReadLine().ToLower();
// Console.WriteLine(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                                switch (s[i])
                                {
                                    case 'a':
                                        total += 1;
                                        break;
                                    case 'e':
                                        total += 2;
                                        break;
                                    case 'i':
                                        total += 3;
                                        break;
                                    case 'o':
                                        total += 4;
                                        break;
                                    case 'u':
                                        total += 5;
                                        break;

                                }
 

            }

            Console.WriteLine("{0}", total);
        }
    }
}
