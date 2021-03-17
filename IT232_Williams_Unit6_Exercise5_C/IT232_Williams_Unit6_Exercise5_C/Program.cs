using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit6_Exercise5_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number less than or equal to 10, followed by pressing ENTER");
            int number = 0;

            try
            {
                number = Int32.Parse(Console.ReadLine());
                if (number > 10)
                    throw new Exception();
                else
                    Console.WriteLine("Your number is less than or equal to 10. It was {0}.", number);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR! Number is greater than 10!");
            }
        }
    }
}
