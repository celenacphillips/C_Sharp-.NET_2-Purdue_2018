using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit4_Exercise3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList days = new ArrayList {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};

            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine(days[i]);
            }
            Console.WriteLine();
            for (int i = days.Count-1; i >= 0; i--)
            {
                Console.WriteLine(days[i]);
            }
            Console.WriteLine();

            ArrayList workingDays = new ArrayList(days);
            workingDays.Remove("Saturday");
            workingDays.Remove("Sunday");

            for (int i = 0; i < workingDays.Count; i++)
            {
                Console.WriteLine(workingDays[i]);
            }
        }
    }
}
