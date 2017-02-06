using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0to100
{
    class Program
    {

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string text = "";
            string text1 = "";
            string text2 = "";
            var numf = 0;
            var nums = 0;

            if (num >= 0 && num <= 100)
            {
                if (num <= 10)
                {
                    if (num == 0)
                    {
                        text = "zero";
                    }
                    else if (num == 1)
                    {

                        text = "one";
                    }
                    else if (num == 2)
                    {
                        text = "two";
                    }
                    else if (num == 3)
                    {
                        text = "three";
                    }
                    else if (num == 4)
                    {
                        text = "four";
                    }
                    else if (num == 5)
                    {
                        text = "five";
                    }
                    else if (num == 6)
                    {
                        text = "six";
                    }
                    else if (num == 7)
                    {
                        text = "seven";
                    }
                    else if (num == 8)
                    {
                        text = "eight";
                    }
                    else if (num == 9)
                    {
                        text = "nine";
                    }
                    else if (num == 10)
                    {
                        text = "ten";
                    }
                    Console.WriteLine(text);


                }

                else if (num > 10 && num <= 19)

                {
                    if (num == 11)
                    {

                        text = "eleven";
                    }
                    else if (num == 12)
                    {
                        text = "twelve";
                    }
                    else if (num == 13)
                    {
                        text = "thirteen";
                    }
                    else if (num == 14)
                    {
                        text = "fourteen";
                    }
                    else if (num == 15)
                    {
                        text = "fifteen";
                    }
                    else if (num == 16)
                    {
                        text = "sixteen";
                    }
                    else if (num == 17)
                    {
                        text = "seventeen";
                    }
                    else if (num == 18)
                    {
                        text = "eighteen";
                    }
                    else if (num == 19)
                    {
                        text = "nineteen";
                    }
                    Console.WriteLine(text);
                }

                if (num > 19 && num <= 100)

                {
                    if (num % 10 == 0)
                    {

                        if (num == 20)
                        {
                            text2 = "twenty";
                        }
                        else if (num == 30)
                        {
                            text2 = "thirty";
                        }
                        else if (num == 40)
                        {
                            text2 = "fourty";
                        }
                        else if (num == 50)
                        {
                            text2 = "fifty";
                        }
                        else if (num == 60)
                        {
                            text2 = "sixty";
                        }
                        else if (num == 70)
                        {
                            text2 = "seventy";
                        }
                        else if (num == 80)
                        {
                            text2 = "eighty";
                        }
                        else if (num == 90)
                        {
                            text2 = "ninety";
                        }
                        else if (num == 100)
                        {
                            text2 = "one hundred";
                        }
                         Console.WriteLine(text2);
                    }

                   else if (num % 10 != 0)

                        {
                    numf = num / 10;
                    nums = num % 10;
                    
                        if (numf == 1)
                        {
                            text2 = "one";
                        }
                        if (numf == 2)
                        {
                            text2 = "twenty";
                        }
                        else if (numf == 3)
                        {
                            text2 = "thirty";
                        }
                        else if (numf == 4)
                        {
                            text2 = "fourty";
                        }
                        else if (numf == 5)
                        {
                            text2 = "fifty";
                        }
                        else if (numf == 6)
                        {
                            text2 = "sixty";
                        }
                        else if (numf == 7)
                        {
                            text2 = "seventy";
                        }
                        else if (numf == 8)
                        {
                            text2 = "eighty";
                        }
                        else if (numf == 9)
                        {
                            text2 = "ninety";
                        }


                        if (nums == 1)
                        {

                            text1 = "one";
                        }
                        else if (nums == 2)
                        {
                            text1 = "two";
                        }
                        else if (nums == 3)
                        {
                            text1 = "three";
                        }
                        else if (nums == 4)
                        {
                            text1 = "four";
                        }
                        else if (nums == 5)
                        {
                            text1 = "five";
                        }
                        else if (nums == 6)
                        {
                            text1 = "six";
                        }
                        else if (nums == 7)
                        {
                            text1 = "seven";
                        }
                        else if (nums == 8)
                        {
                            text1 = "eight";
                        }
                        else if (nums == 9)
                        {
                            text1 = "nine";

                        }
                        Console.Write("{0} ", text2);
                        Console.WriteLine(text1);



                    }

                }


                
                   
            }

            else
                Console.WriteLine("invalid number");




        }
    }
}



