using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit4_Exercise2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> fruit = new Dictionary<string, int> ();

            fruit.Add("Apples",5);
            fruit.Add("Bananas", 15);
            fruit.Add("Oranges", 2);
            fruit.Add("Kiwis", 1);

            Console.WriteLine("There are {0} apples.",fruit["Apples"]);
            Console.WriteLine("There are {0} bananas.", fruit["Bananas"]);
            Console.WriteLine("There are {0} oranges.", fruit["Oranges"]);
            Console.WriteLine("There are {0} kiwis.", fruit["Kiwis"]);
        }
    }
}
