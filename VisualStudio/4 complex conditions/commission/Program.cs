using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commission
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите s:
            //Град  | 0 ≤ s ≤ 500   |   500 < s ≤ 1 000 |   1 000 < s ≤ 10 000 |    s > 10 000
            //Sofia |   5 %         |    7 %            |       8 %            |    12 %
            //Varna |   4.5 %       |    7.5 %          |       10 %           |    13 %
            //Plovdiv|   5.5 %      |    8 %            |        12 %          |    14.5 %
            //
            //чете име на град (стринг)и обем на продажби(десетично число) и изчислява и извежда ...комисионна .
            //Резултатът да се изведе закръглен с 2 цифри след десетичната точка.
            //При невалиден град или обем на продажбите(отрицателно число) да се отпечата “error”. 

            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double commission = 0.0;



            if (sales <0)

                Console.WriteLine("invalid");    

            if (sales >= 0 && sales <= 500)
            {
                switch (city)
                {
                    case "sofia":
                        commission = sales * 0.05;

                        break;
                    case "plovdiv":
                        commission = sales * 0.045;

                        break;
                    case "varna":
                        commission = sales * 0.055;

                        break;

                    default:
                        Console.WriteLine("error");

                        break;
                }

                /*  if (city == "sofia")
                  {
                      commission = sales * 0.05;
                  }
                  if (city == "varna")
                  {
                      commission = sales * 0.045;
                  }
                  if (city == "plovdiv")
                  {
                      commission = sales * 0.055;
                  }
  */
            }
           else if (sales > 500 && sales <= 1000)
            {
                if (city == "sofia")
                {
                    commission = sales * 0.07;
                }
                if (city == "varna")
                {
                    commission = sales * 0.075;
                }
                if (city == "plovdiv")
                {
                    commission = sales * 0.08;
                }

            }

          else  if (sales > 1000 && sales <= 10000)
            {
                if (city == "sofia")
                {
                    commission = sales * 0.08;
                }
                if (city == "varna")
                {
                    commission = sales * 0.1;
                }
                if (city == "plovdiv")
                {
                    commission = sales * 0.12;
                }

            }
          else  if (sales > 10000)
            {
                if (city == "sofia")
                {
                    commission = sales * 0.12;
                }
                if (city == "varna")
                {
                    commission = sales * 0.13;
                }
                if (city == "plovdiv")
                {
                    commission = sales * 0.145;
                }

            }


            if ((commission > 0) && (city == "sofia" || city == "varna" || city == "plovdiv"))
            {
                Console.WriteLine("{0:f2}", commission);
            }
         else   if ((commission < 0) || (city != "sofia" || city != "varna" || city != "plovdiv"))

            {
                Console.WriteLine("error");
            }


        }
    }
}
