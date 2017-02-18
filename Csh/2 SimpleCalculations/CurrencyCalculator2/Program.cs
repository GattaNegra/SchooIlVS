using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curconv4
{
    class Program
    {
        static void Main(string[] args)
        {
            //конвертиране на парична сума от една валута в друга.
            //Трябва да се поддържат следните валути: BGN, USD, EUR, GBP.
            //Използвайте следните фиксирани валутни курсове:
            // 1.79549 USD
            // 1.95583 EUR
            // 2.53405 GBP
            double usdcr = 1.79549;
            double eurcr = 1.95583;
            double gbpcr = 2.53405;
            Console.WriteLine("Enter Amount:");
            double amt = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Currency:");
            var icur = Console.ReadLine();
            Console.WriteLine("Output Currency:");
            var ocur = Console.ReadLine();

            double b2u = (amt / usdcr); // bgn to usd
            double b2e = (amt / eurcr); // bgn to eur
            double b2g = (amt / gbpcr); // bgn to gbp

            double u2b = (amt * usdcr);// usd to bgn
            double e2b = (amt * eurcr);// eur to bgn
            double g2b = (amt * gbpcr);// gbp to bgn
            double sum = amt;

            // bgn to usd
            if (ocur.ToUpper() == "USD")
            {
                sum = Math.Round((b2u), 2);
            }
            // bgn to eur
            else if (ocur.ToUpper() == "EUR")
            {
                sum = Math.Round((b2e), 2);
                // bgn to gbp
            }
            else if (ocur.ToUpper() == "GBP")
            {
                sum = Math.Round((b2g), 2);
            }
            Console.WriteLine(sum);

                //  if (icur.ToUpper() == "BGN")
                //    {

                //   }


                // usd to bgn
                // eur to bgn
                // gbp to bgn

                // usd to bgn to eur
                // usd to bgn to gbp

                // eur to bgn to usd
                // eur to bgn to gbp

                // gbp to bgn to usd
                // gbp to bgn to eur

                //  if (icur.ToUpper() == "BGN")
                //  {
                //     var sum = gbpcr * amt;
                //    console.writeline(sum);
                // }
                //else if (c=2)
                //    {
                //    var sum = eurcr * amt;
                //    console.writeline(sum);
                //    }
                //else
                //{
                //    var sum = usdcr * amt;
                //    console.writeline(sum);
                //}

                //math
                //      if (c > 2)
                //      {
                //         if (c = 2)
                //         {
                //             var sum = gbpcr * amt;
                //             Console.WriteLine(sum);
                //         }
                //         else
                //             var sum = eurcr * amt;
                //         Console.WriteLine(sum)
                //
                //     }
                //
                //    else
                //    sum = usdcr * amt;
                //   Console.WriteLine(sum);

                // Next statement in the program.


                //  double bgn = Math.Round((conv * usd), 2);
                //  Console.WriteLine(" : {0}", bgn);



            }
    }
}




