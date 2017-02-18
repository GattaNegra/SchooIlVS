<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchtocm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1inch=2.54cm
            var inchInCm = 2.54;
            double lengthInInches =double.Parse(Console.ReadLine());
            double lengthInCm = Math.Abs(lengthInInches * inchInCm);
            Console.WriteLine(lengthInCm);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchtocm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1inch=2.54cm
            var inchInCm = 2.54;
            double lengthInInches =double.Parse(Console.ReadLine());
            double lengthInCm = Math.Abs(lengthInInches * inchInCm);
            Console.WriteLine(lengthInCm);
        }
    }
}
>>>>>>> a133a25be30296e6ae9e8d9736acf3a888c9aa99
