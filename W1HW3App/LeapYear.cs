using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter year your want to identity:");
                try
                {
                    int year = System.Int32.Parse(Console.ReadLine());
                    if (year != 0)
                    {
                        // Determining whether it is a leap year
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                        {
                            Console.WriteLine("Year is a Leap");
                        }
                        else
                        {
                            Console.WriteLine("Year is not a Leap");
                        }
                    }
                }
                // Catch illegal input exception
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter the correct year!");
                }
                
            }
            
        }
    }
}
