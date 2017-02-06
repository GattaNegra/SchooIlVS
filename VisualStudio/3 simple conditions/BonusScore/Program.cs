using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Дадено е цяло число – брой точки. Върху него се начисляват бонус точки по правилата, описани по-долу. 
            //Да се напише програма, която пресмята бонус точките за това число и общия брой точки с бонусите.
            // Ако числото е до 100 включително, бонус точките са 5.
            // Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
            //   Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.
            //     Допълнителни бонус точки(начисляват се отделно от предходните):
            //o За четно число  +1 т.
            //   o За число, което завършва на 5  +2 т.

            double x = double.Parse(Console.ReadLine());
            //x even +1
            bool even = (x % 2 == 0);
            int bonusEven = 1;

            //x ?5 +2
            bool five = (x % 5 == 0);
            //bool five = (x % 10 == 5);
            int bonusFive = 2;

            //double perc10 = (x - (x - (x * .10)));
            double perc10 = x * .10;

            //double perc20 = (x - (x - (x * .20)));
            double perc20 = x * .20;
            //Console.WriteLine("10% = {0} 20% = {1}", perc10, perc20);

            // x<=100 +5
            if (x <= 100)
            {

                if (even)
                {
                    //  Console.WriteLine(bonusEven);
                    Console.WriteLine("Bonus: {0}", 5 + bonusEven);
                    Console.WriteLine("Total: {0}", x + 5 + bonusEven);
                }

                else if (five)
                {

                    //  Console.WriteLine(bonusEven);
                    Console.WriteLine("Bonus: {0}", 5 + bonusFive);
                    Console.WriteLine("Total: {0}", x + 5 + bonusFive);
                }
                else if (five || even)
                {
                    //  Console.WriteLine(bonusEven);
                    Console.WriteLine("Bonus: {0}", 5 + bonusFive + bonusEven);
                    Console.WriteLine("Total: {0}", x + 5 + bonusEven + bonusFive);
                }
                else
                {
                    Console.WriteLine("Bonus: {0}", 5);
                    Console.WriteLine("Total1: {0}", x + 5);
                }
            }

            //x>100 +20%x
            if (x > 100)
            {
                if (x < 1000)
                {
                    if (even)
                    {
                        //  Console.WriteLine(bonusEven);
                        Console.WriteLine("Bonus: {0}", + bonusEven + perc20);
                        Console.WriteLine("Total: {0}", x + bonusEven + perc20);
                    }

                    else if (five)
                    {

                        //  Console.WriteLine(bonusEven);
                        Console.WriteLine("Bonus: {0}", bonusFive + perc20);
                        Console.WriteLine("Total: {0}", x + bonusFive + perc20);
                    }
                    else if (five || even)
                    {
                        //  Console.WriteLine(bonusEven);
                        Console.WriteLine("Bonus: {0}",+ bonusFive + bonusEven + perc20);
                        Console.WriteLine("Total: {0}", x  + bonusEven + bonusFive + perc20);
                    }
                    else
                    {
                        Console.WriteLine("Bonus: {0}", perc20);
                        Console.WriteLine("Total: {0}", x +  perc20);
                    }
                }
                if (x > 1000)
                {
                    if (even)
                    {
                        //  Console.WriteLine(bonusEven);
                        Console.WriteLine("Bonus: {0}", bonusEven + perc10);
                        Console.WriteLine("Total: {0}", x + bonusEven + perc10);
                    }

                    else if (five)
                    {

                        //  Console.WriteLine(bonusEven);
                        Console.WriteLine("Bonus: {0}",  bonusFive + perc10);
                        Console.WriteLine("Total: {0}", x + bonusFive + perc10);
                    }
                    else if (five || even)
                    {
                        //  Console.WriteLine(bonusEven);
                        Console.WriteLine("Bonus: {0}",  bonusFive + bonusEven + perc10);
                        Console.WriteLine("Total: {0}", x + bonusEven + bonusFive + perc10);
                    }
                    else
                    {
                        Console.WriteLine("Bonus: {0}", perc10);
                        Console.WriteLine("Total: {0}", x + perc10);
                    }
                }
            //x>1000 10x

           
            }

        }
    }

    



}


