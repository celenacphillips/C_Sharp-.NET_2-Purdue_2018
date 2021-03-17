using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit6_Exercise1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name, followed by pressing ENTER");
            String name = "";

            try
            {
                name = Console.ReadLine();
                if (name.Equals(null) || name.Equals(""))
                    throw new NullReferenceException();
                else
                    Console.WriteLine("Your name is {0}", name);

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Sorry, name must not be NULL!");
            }            
        }
    }
}
