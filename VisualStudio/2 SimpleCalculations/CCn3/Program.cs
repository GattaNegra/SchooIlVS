using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCn3
{
    class Program
    {
        static void Main(string[] args)
        {
            double usdcr = 1.79549;
            double eurcr = 1.95583;
            double gbpcr = 2.53405;
            Console.WriteLine("Enter Amount:");
            double amt = double.Parse(Console.ReadLine());
            double amt2;
            double amt3;
            Console.WriteLine("Input Currency:");
            var icur = Console.ReadLine();
            Console.WriteLine("Output Currency:");
            var ocur = Console.ReadLine();


            if (icur.ToUpper() == "BGN")
            //lv to lv = amt
            {
                amt2 = amt;
            }
            else if (icur.ToUpper() == "USD")
                //usd to lv = amt * changerate
            {
                amt2 = amt * usdcr;
            }
            else if (icur.ToUpper() == "EUR")
                //eur to lv = amt * changerate
            {
                amt2 = amt * eurcr;
            }
            else if (icur.ToUpper() == "GBP")
                //gbp to lv = amt * changerate
            {
                amt2=amt * gbpcr;
            }
            else
            {
                Console.WriteLine("Wrong Input Currency");
                return;
            }


            if (ocur.ToUpper() == "BGN")
            //lv to lv = amt2
            {
                amt3 = amt2;
            }
            else if (ocur.ToUpper() == "USD")
            //lv to usd = amt2 / changerate
            {
                amt3 = amt2 / usdcr;
            }
            else if (ocur.ToUpper() == "EUR")
            //lv to eur = amt2 / changerate
            {
                amt3 = amt2 / eurcr;
            }
            else if (ocur.ToUpper() == "GBP")
            //lv to gbp = amt2 / changerate
            {
                amt3 = amt2 / gbpcr;
            }
            else
            {
                Console.WriteLine("Wrong Output Currency");
                return;
            }
            Console.Write(ocur.ToUpper() + ": ");
            Console.WriteLine(Math.Round(amt3, 2));

        }
    }
}
