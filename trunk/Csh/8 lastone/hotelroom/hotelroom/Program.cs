using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelroom
{
    class Program
    {
        static void Main(string[] args)
        {
            /* MAke with switchcase!!!
             * 
За апартамент, при повече от 14 нощувки, без значение от месеца : 10% намаление.
За студио, при повече от 7 нощувки през май и октомври : 5% намаление.
За студио, при повече от 14 нощувки през май и октомври : 30% намаление.
За студио, при повече от 14 нощувки през юни и септември: 20% намаление.
Май и октомври  |  Юни и септември  |  Юли и август
Студио – 50     | Студио – 75.20    | Студио – 76
Апартамент – 65 | Апартамент – 68.70 | Апартамент – 77 лв

             * 
             */
            var aPr = 0.0;
            var sPr = 0.0;
            var month= (Console.ReadLine().ToLower());
            var stay =int.Parse(Console.ReadLine());


            if (month=="may" || month=="oct")
            {
                if (stay <= 7)
                {
                    sPr = stay * 50;
                    aPr = stay * 65;
                }
                if (stay > 7)
                {
                    sPr = stay * (50 - (50 * 0.05));
                    aPr = stay * 65;
                }

                if (stay>14)
                {
                    aPr = stay * (65 - (65 * 0.1));
                    sPr = stay * (50 - (50 * 0.3));
                }
             
            }

            if (month == "jun" || month == "sept")
            {
                if (stay<=14)
                {
                    aPr = stay * 68.7 ;
                    sPr = stay * 75.20;
                
                }

                if (stay > 14)
                {
                    aPr = stay * (68.7-(68.7*0.1));
                    sPr = stay * (75.20- (75.20 * 0.2));
                }

            }
            if (month == "jul" || month == "aug")
            {
                if (stay <= 14)
                {
                    aPr = stay * 77;
                    sPr = stay * 76;
                }
                if (stay > 14)
                {
                    aPr = stay * (77 - (77 * 0.1));
                    sPr = stay * 76;
                }

            }

            Console.WriteLine("Appartment: {0:f2}",aPr);
            Console.WriteLine("Studio: {0:f2}",sPr);

        }
    }
}
