using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit3_Exercise3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            //This code will produce an out of bounds error.
            Console.WriteLine("Element at index 11: {1}", array[11]);
        }
    }
}
