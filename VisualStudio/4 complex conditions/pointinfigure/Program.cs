using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointinfigure
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Фигура се състои от 6 блокчета с размер h *h, разположени като на фигурата вдясно.
            //Долният ляв ъгъл на сградата е на позиция { 0, 0}. 
            //Горният десен ъгъл на фигурата е на позиция { 2 * h, 4 * h}. 
            //На фигурата координатите са дадени при h = 2.
            //Напишете програма, която въвежда цяло число h и координатите на дадена точка { x, y} (цели числа) и 
            //отпечатва дали точката е:
            //вътре във фигурата(inside),
            //вън от фигурата(outside) 
            //или на някоя от стените на фигурата(border).
            //neither up
            //neither down
            //  *
            //  *
            //  *
            // ***
            //A(x,y)
            //C(x1,y1)
            //B=(x1,y)
            //D=(x,y1)
            //P=(xP,yP)
            //horizInside = x < xP AND xP < x1
            //vertInside = y1 < yP AND yP < y
            // inside = horizInside && vertInside
            //horizoutside = xM < x ||x1xM 
            //vertoutside = yM<y||y1<yM
            //outside=horizoutside||vertoutside

            // var h = int.Parse(Console.ReadLine());
            // var blockSize = h * h;
            var blockSize = int.Parse(Console.ReadLine());
            var pointToCheckX = int.Parse(Console.ReadLine());
            var pointToCheckY = int.Parse(Console.ReadLine());

            var lowerRectangleLeftPointX =0;
            var lowerRectangleLeftPointY =0;
            var lowerRectangUpperRightPointX = 3*blockSize;
            var lowerRectangleUpperRightPointY = blockSize;

            var isPointHorizontallyInsideLowerRectangle = lowerRectangleLeftPointX < pointToCheckX&&
                pointToCheckX<lowerRectangleUpperRightPointX;
            var isPointVerticallyInsideLowerRectangle = lowerRectangleLeftPointY < pointToCheckY &&
                pointToCheckY < lowerRectangleUpperRightPointY;
            var isPointInsideLowerRectangle = isPointHorizontallyInsideLowerRectangle && isPointVerticallyInsideLowerRectangle;

            var isPointVerticallyOutsideLowerRectangle = pointToCheckX < lowerRectangleLeftPointX || lowerRectangUpperRightPointX < pointToCheckX;
            var isPointHorizontallyOutsideLowerRectangle = pointToCheckY < lowerRectangleLeftPointY || lowerRectangleUpperRightPointY < pointToCheckY;
            var isPointOutsideLowerRectangle = isPointHorizontallyOutsideLowerRectangle || isPointVerticallyOutsideLowerRectangle;

            var isPointOnBorderofLowerectangle = isPointInsideLowerRectangle && isPointOutsideLowerRectangle;

            var isPointInsideUpperRectangle = true;
            var isPointOutsideUpperRectangle = false;
            var isPointOnBorderofUpperRectangle = false;

            var isPointOnCommonSideOfTheRectangles =
                blockSize < pointToCheckX && pointToCheckX <= 2 * blockSize && pointToCheckY == blockSize;

            var isPointInsideFigure =
                isPointInsideLowerRectangle || isPointInsideUpperRectangle || isPointOnCommonSideOfTheRectangles;

            var isPointOutsideFigure = isPointOutsideLowerRectangle && isPointOutsideUpperRectangle;

            var isPointOnBorderofFigure = isPointOutsideFigure && isPointInsideFigure;




        }
    }
}
