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
            //            проверява дали точка { x, y} се намира вътре в правоъгълник { x1, y1} – { x2, y2}.
            //Входните данни се четат от конзолата и се състоят от 6 реда:
            //десетичните числа x1, y1, x2, y2, x и y(като се гарантира, че x1 < x2 и y1 < y2).
            //Една точка е вътрешна за даден правоъгълник, ако се намира някъде във вътрешността му или върху някоя от страните му. 
            //Отпечатайте “Inside” или “Outside”. 

            var x1 = decimal.Parse(Console.ReadLine());
            var y1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());
            var x = decimal.Parse(Console.ReadLine());
            var y = decimal.Parse(Console.ReadLine());

            if (x1>x2||y1>y2)
            {
                return;
            }
            if ((x>=x1&&y>=y1)&&(x<=x2&&y<=y2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }


        }
    }
}
