using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit3_Exercise1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] daysOfWeek = new String [] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(daysOfWeek [i]);
            }
            Console.WriteLine();

            for (int i = daysOfWeek.Length - 1; i >= 0; i--)
            {
                Console.WriteLine (daysOfWeek [i]);
            }
        }
    }
}
