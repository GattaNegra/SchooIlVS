using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber= int.Parse (Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is: {0}",
                firstNumber + secondNumber);

            Console.WriteLine("Div is: {0}", 
                firstNumber - secondNumber);

            Console.WriteLine("Time is: {0}",
               firstNumber * secondNumber);

            Console.WriteLine("Del: {0:F2}",
               firstNumber / secondNumber);
         }
    }
}
