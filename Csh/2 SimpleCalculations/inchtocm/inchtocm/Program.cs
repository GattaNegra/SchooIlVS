using System;
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
            var name = (Console.ReadLine());
            var age = int.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Hello," +name+ " you are " +age + " yrs old and you are " +gender);
            Console.WriteLine("Hello, {0}, you are  {1}, and you are  {2}.", name, age, gender);
            //  Console.Write("Name:");
            // Console.WriteLine(name);
            // Console.Write("Age:");
            // Console.WriteLine(age);
            //Console.Write("Gender:");
            //Console.WriteLine(gender);
        }
    }
}
