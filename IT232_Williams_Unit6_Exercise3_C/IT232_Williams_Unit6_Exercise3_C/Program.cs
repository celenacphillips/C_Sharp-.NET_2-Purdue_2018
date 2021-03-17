using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit6_Exercise3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number greater than 25, followed by pressing ENTER");
            int number = 0;

            try
            {
                number = Int32.Parse(Console.ReadLine());
                if (number < 25)
                    throw new Exception();
                else
                    Console.WriteLine("Your number is greater than 25. It was {0}.", number);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR! Number is less than 25!");
            }
        }
    }
}
