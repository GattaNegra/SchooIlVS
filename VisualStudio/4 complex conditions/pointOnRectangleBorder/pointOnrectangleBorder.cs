using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pointinrect
{
    class pointInRect
    {
        static void Main(string[] args)
        {
            var x1 = decimal.Parse(Console.ReadLine());
            var y1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());
            var x = decimal.Parse(Console.ReadLine());
            var y = decimal.Parse(Console.ReadLine());

            bool inside1 = (x > x1 && x < x2);
            bool inside2 = (y > y1 && y < y2);

            bool inside = inside1 && inside2;

            bool outside1 = (x < x1 || x > x2);
            bool outside2 = (y < y1 || y > y2);

            bool outside = (outside1 || outside2);

            bool border1 = (x == x1 || x == x2);
            bool border2 = (y == y1 || y == y2);

            bool border = ((border1 && border2)||(border1&&inside1)||(border1&&inside2)||(border2&&inside1)||(border2&&inside2)|| (border1 && inside) || (border2 && inside));

            if (border)
            {
                Console.WriteLine("Border");
            }

            if (inside||outside)
            {
                Console.WriteLine("Inside / Outside");
            }
          //  return;

            



        }
    }
}