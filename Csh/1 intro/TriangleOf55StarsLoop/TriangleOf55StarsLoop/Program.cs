<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55StarsLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int lines = 1;
                while( lines <= 10)
                {
                    {
                        Console.WriteLine(lines);
                    }
                    lines++;
                }
            }
            for (int lines = 1; 
                lines <= 10;
                lines++)
            {
                //Console.WriteLine(new string('*', i));

                for (int stars = 1;
                    stars <= lines;
                    stars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55StarsLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int lines = 1;
                while( lines <= 10)
                {
                    {
                        Console.WriteLine(lines);
                    }
                    lines++;
                }
            }
            for (int lines = 1; 
                lines <= 10;
                lines++)
            {
                //Console.WriteLine(new string('*', i));

                for (int stars = 1;
                    stars <= lines;
                    stars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
}
>>>>>>> a133a25be30296e6ae9e8d9736acf3a888c9aa99
