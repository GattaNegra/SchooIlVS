<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglearea
{
    class Program
    {
        static void Main(string[] args)
            //area=(a*h)/2
                    
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var ar = Math.Round(((a * h) / 2),2);

            Console.WriteLine("Area = {0}",ar);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglearea
{
    class Program
    {
        static void Main(string[] args)
            //area=(a*h)/2
                    
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var ar = Math.Round(((a * h) / 2),2);

            Console.WriteLine("Area = {0}",ar);
        }
    }
}
>>>>>>> a133a25be30296e6ae9e8d9736acf3a888c9aa99
