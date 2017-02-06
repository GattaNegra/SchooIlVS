using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitshop
{
    class fruitshop
    {
        static void Main(string[] args)
        {
            //  Магазин за плодове през работните дни работи на следните цени:
            //плод |    banana  | apple | orange| grapefruit| kiwi| pineapple| grapes
            //цена |    2.50    | 1.20  | 0.85  | 1.45      | 2.70| 5.50     | 3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //плод |    banana  | apple | orange| grapefruit| kiwi| pineapple| grapes
            //цена |    2.70    | 1.25  | 0.90  | 1.60      | 3.00| 5.60     | 4.20
            //
            //Напишете програма, която чете от конзолата плод 
            //(banana / apple / orange / grapefruit / kiwi / pineapple /grapes), 
            //ден от седмицата
            //(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday)
            //и количество
            //(десетично число) 
            //1. и пресмята цената според цените от таблиците по - горе.
            //2. Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.
            //3. При невалиден ден от седмицата или невалидно име на плод да се отпечата “error”. 


         //   Console.WriteLine("Fruit:");
            var fruit = Console.ReadLine().ToLower();
       //     Console.WriteLine("Day:");
            var day = Console.ReadLine().ToLower();
         //   Console.WriteLine("Amount:");
            var amt = double.Parse(Console.ReadLine());

            double price = 0.0;
            var priceBan = 0.0;
            var priceApp = 0.0;
            var priceOr = 0.0;
            var priceGF = 0.0;
            var priceKi = 0.0;
            var PricePi = 0.0;
            var priceGrap = 0.0;

          //  if (!(day == "saturday" || day == "sunday" || day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday") && !(fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes"))
         //   {
         //       Console.WriteLine("error");
          //      return;
         //   }
                if ((day == "saturday" || day == "sunday" || day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday") && (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes"))
            {

                if (day == "saturday" || day == "sunday")
                {
                    priceBan = 2.70;
                    priceApp = 1.25;
                    priceOr = 0.90;
                    priceGF = 1.60;
                    priceKi = 3.00;
                    PricePi = 5.60;
                    priceGrap = 4.20;

                }
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    priceBan = 2.50;
                    priceApp = 1.20;
                    priceOr = 0.85;
                    priceGF = 1.45;
                    priceKi = 2.70;
                    PricePi = 5.50;
                    priceGrap = 3.85;
                }
                if (fruit == "banana")
                {
                    price = priceBan;
                }
                if (fruit == "apple")
                {
                    price = priceApp;
                }
                if (fruit == "orange")
                {
                    price = priceOr;
                }
                if (fruit == "grapefruit")
                {
                    price = priceGF;
                }
                if (fruit == "kiwi")
                {
                    price = priceKi;
                }
                if (fruit == "pineapple")
                {
                    price = PricePi;
                }
                if (fruit == "grapes")
                {
                    price = priceGrap;
                }
                Console.WriteLine("{0:F2}", amt * price);

            }
            else
                Console.WriteLine("error");
            

        }
    }
}
