using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit3_Project_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] salesRegions = new String[4, 4];

            salesRegions[0, 0] = "North";
            salesRegions[1, 0] = "West";
            salesRegions[2, 0] = "East";
            salesRegions[3, 0] = "South";

            salesRegions[0, 1] = "Bob";
            salesRegions[0, 2] = "Will";
            salesRegions[0, 3] = "Ed";

            salesRegions[1, 1] = "Rob";
            salesRegions[1, 2] = "Earl";
            salesRegions[1, 3] = "Will";

            salesRegions[2, 1] = "Mitch";
            salesRegions[2, 2] = "Paul";
            salesRegions[2, 3] = "Ralph";

            salesRegions[3, 1] = "Eddy";
            salesRegions[3, 2] = "Hank";
            salesRegions[3, 3] = "Rudy";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("SalesRegion: {0}", salesRegions[i, 0]);
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine("Salesman: {0}", salesRegions[i, j]);
                }
            }
            

            ArrayList salesTeam = new ArrayList();

            salesTeam.Add("Bob");
            salesTeam.Add("Will");
            salesTeam.Add("Ed");

            Console.WriteLine("There are {0} sales team members.", salesTeam.Count);

            salesTeam.Add("Rob");
            salesTeam.Add("Earl");
            salesTeam.Add("Bill");

            Console.WriteLine("There are {0} sales team members.", salesTeam.Count);

            if (salesTeam.Contains("Will"))
                Console.WriteLine("Will is in the list.");
            else
                Console.WriteLine("Will is not in the list.");

            salesTeam.Remove("Ed");
            salesTeam.Remove("Earl");

            Console.WriteLine("There are {0} sales team members.", salesTeam.Count);

            for (int i = 0; i < salesTeam.Count; i++)
            {
                Console.Write("{0},", salesTeam[i]);
            }
            Console.WriteLine();
        }
    }
}
