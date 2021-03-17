using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit6_Exercise4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number less than 5, followed by pressing ENTER");
            int number = 0;

            try
            {
                number = Int32.Parse(Console.ReadLine());
                if (number > 5)
                    throw new Exception();
                else
                    Console.WriteLine("Your number is less than 5. It was {0}.", number);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR! Number is greater than 5!");
            }
        }
    }
}
