using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit6_Exercise6_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, followed by pressing ENTER");
            int number = 0;

            try
            {
                number = Int32.Parse(Console.ReadLine());
                if (number == 7)
                    Console.WriteLine("Your number is {0}.", number);
                else if (number == 3)
                    throw new Exception();
                else
                    Console.WriteLine("Your number was not 7 or 3. It was {0}.", number);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR! Number cannot be 3!");
            }
        }
    }
}
