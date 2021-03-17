using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit6_Exercise7_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dividing by zero.");
            try
            {
                int zero = 0;
                int answer = 4 / zero;
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR! Cannot divide by zero!");
            }

            Console.WriteLine("\nArray out of bounds.");
            try
            {
                int[] newArray = new int[2];

                for (int i = 0; i < 5; i++)
                {
                    newArray[i] = i;
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ERROR! Index out of range!");
            }

            Console.WriteLine("\nString is null.");
            try
            {
                String input = "";

                if (input.Equals(null) || input.Equals(""))
                    throw new ArgumentNullException();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ERROR! String cannot be NULL!");
            }
        }
    }
}
