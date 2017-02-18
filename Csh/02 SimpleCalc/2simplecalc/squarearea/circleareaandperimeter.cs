<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squarearea
{
    class circleareaandperimeter
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            // p*r*r
            double area = Math.PI * (Math.Pow(radius,2));
            

            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Area = {0} \nPerimeter = {1}", area, perimeter);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squarearea
{
    class circleareaandperimeter
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            // p*r*r
            double area = Math.PI * (Math.Pow(radius,2));
            

            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Area = {0} \nPerimeter = {1}", area, perimeter);
        }
    }
}
>>>>>>> a133a25be30296e6ae9e8d9736acf3a888c9aa99
