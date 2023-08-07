using System;
using System.Collections.Generic;
using System.Numerics;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elemnts = Console.ReadLine()
              .Split();
            BigInteger sum = 0;

            foreach (var item in elemnts)
            {
                try
                {
                    int number = int.Parse(item);
                    sum += number;
                }
                catch (FormatException)
                {

                    Console.WriteLine($"The element '{item}' is in wrong format!");
                }
                catch (OverflowException)
                {

                    Console.WriteLine($"The element '{item}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
                }

            }
            Console.WriteLine($"The total sum of all integers is: {sum}");



            

            



        }
    }

    
    
}

