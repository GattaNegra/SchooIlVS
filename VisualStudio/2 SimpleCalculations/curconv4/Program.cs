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
          //  double bgncr = 1;
            double usdcr = 1.79549;
            double eurcr = 1.95583;
            double gbpcr = 2.53405;
            Console.WriteLine("Enter Amount:");
            double amt = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Currency:");
            var icur = Console.ReadLine();
            Console.WriteLine("Output Currency:");
            var ocur = Console.ReadLine();

            //    double bgnamt = (amt *); // 6 lv = 2 usd . 1 usd =6/2 ; 1 usd=3 lv  ; 9 lv / 3 = 3 usd
            //    double bgntoeur = (amt /eurcr);
            //    double bgntogbp = (amt /gbpcr);

            //ICUR IS BGN
            if (icur.ToUpper() == "BGN")
            {
                if (ocur.ToUpper() == "USD")
                {
                    var sum = Math.Round((amt / usdcr), 2);
                    Console.WriteLine(sum);
                }
                //bgn to eur
                else if (ocur.ToUpper() == "EUR")
                {
                    var sum = Math.Round((amt / eurcr), 2);
                    Console.WriteLine(sum);
                }
                //bgn to gbp
                else if (ocur.ToUpper() == "GBP")
                {
                    var sum = Math.Round((amt / gbpcr), 2);
                    Console.WriteLine(sum);
                }
            }
            //ICUR IS USD
            else if (icur.ToUpper() == "USD")
            //usd to bgn      
            {
                if (ocur.ToUpper() == "BGN")
                {
                    var sum = Math.Round((usdcr * amt), 2);
                    Console.WriteLine(sum);
                }
                //usd to eur
                else if (ocur.ToUpper() == "EUR")
                {
                    var sum = Math.Round(((usdcr*amt)/ eurcr), 2);
                    Console.WriteLine(sum);
                }
                //usd to gbp
                else if (ocur.ToUpper() == "GBP")
                {
                    var sum = Math.Round(((usdcr * amt) / gbpcr), 2);
                    Console.WriteLine(sum);
                }
            }
            //ICUR IS EUR
            else if (icur.ToUpper() == "EUR")
            //eur to bgn      
            {
                if (ocur.ToUpper() == "BGN")
                {
                    var sum = Math.Round((eurcr * amt), 2);
                    Console.WriteLine(sum);
                }
                //eur to usd
                else if (ocur.ToUpper() == "EUR")
                {
                    var sum = Math.Round(((eurcr * amt) / usdcr), 2);
                    Console.WriteLine(sum);
                }
                //eur to gbp
                else if (ocur.ToUpper() == "GBP")
                {
                    var sum = Math.Round(((eurcr * amt) / gbpcr), 2);
                    Console.WriteLine(sum);
                }
            }
            //ICUR IS GBP
            else if (icur.ToUpper() == "GBP")
            //gbp to bgn      
            {
                if (ocur.ToUpper() == "BGN")
                {
                    var sum = Math.Round((gbpcr * amt), 2);
                    Console.WriteLine(sum);
                }
                //gbp to usd
                else if (ocur.ToUpper() == "USD")
                {
                    var sum = Math.Round(((gbpcr * amt) / usdcr), 2);
                    Console.WriteLine(sum);
                }
                //gbp to eur
                else if (ocur.ToUpper() == "EUR")
                {
                    var sum = Math.Round(((gbpcr * amt) / eurcr), 2);
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
