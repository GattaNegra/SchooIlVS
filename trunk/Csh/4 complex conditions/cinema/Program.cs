using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.Има три вида прожекции с
            //билети на различни цени:

            //Premiere – премиерна прожекция, на цена 12.00 лева.
            //Normal – стандартна прожекция, на цена 7.50 лева.
            //Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            //въвежда тип прожекция(стринг), 
            //брой редове и брой колони в залата(цели числа) 
            //и изчислява общите приходи от билети при пълна зала.
            //Резултатът да се отпечата във формат с 2 знака след десетичната точка.

            var projType = Console.ReadLine().ToLower() ;
            var rows = int.Parse(Console.ReadLine());
            var colmns = int.Parse(Console.ReadLine());
            var pricePrem = 12.00;
            var priceNor = 7.50;
            var priceDisc = 5.00;

            var price = 0.0;
            var income = 0.0;

            if (projType == "premiere")
            {
                price = pricePrem;
                        }
           else if (projType == "normal")
            {
                price = priceNor;
                            }
           else if (projType == "discount")
            {
                price = priceDisc;
                        }
            income = rows * colmns * price;
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
