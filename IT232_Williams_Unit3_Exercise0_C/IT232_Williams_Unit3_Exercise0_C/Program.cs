using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit3_Exercise0_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] carTypes = new String [] {"Chrysler", "Ford", "Toyota"};

            for (int i = 0; i < carTypes.Length; i++)
            {
                Console.WriteLine (carTypes[i]);
            }
        }
    }
}
