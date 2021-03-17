using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit4_Project_C
{
    class Program
    {
        struct addr
        {
            public string name, street, city, state, zipcode;
            public const int MAX = 5;
        }

        static void Main(string[] args)
        {
            addr[] listOfAddr = new addr[addr.MAX];

            List<String> names = new List<string>();
            List<String> streets = new List<string>();
            List<String> cities = new List<string>();
            List<String> states = new List<string>();
            List<String> zipcodes = new List<string>();

            names.Add("Bob");
            names.Add("Bill");
            names.Add("Ed");
            names.Add("Wally");
            names.Add("George");

            streets.Add("123 Elm St.");
            streets.Add("456 Main St.");
            streets.Add("986 Skidmore Rd.");
            streets.Add("568 Lakeside Terrace");
            streets.Add("9863 Waldorf Ave.");

            cities.Add("Houston");
            cities.Add("New Orleans");
            cities.Add("Tampa");
            cities.Add("Atlanta");
            cities.Add("Richmond");

            states.Add("Texas");
            states.Add("Louisana");
            states.Add("Florida");
            states.Add("Georgia");
            states.Add("Virginia");

            zipcodes.Add("23464");
            zipcodes.Add("34654");
            zipcodes.Add("34646");
            zipcodes.Add("56848");
            zipcodes.Add("86534");

            for (int i = 0; i < listOfAddr.Length; i++)
            {
                listOfAddr[i].name = names[i];
                listOfAddr[i].street = streets[i];
                listOfAddr[i].city = cities[i];
                listOfAddr[i].state = states[i];
                listOfAddr[i].zipcode = zipcodes[i];
            }

            for (int i = 0; i < listOfAddr.Length; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}, {4} {5}", i, listOfAddr[i].name, listOfAddr[i].street, listOfAddr[i].city, listOfAddr[i].state, listOfAddr[i].zipcode);
            }
            Console.WriteLine("\n\n");

            Dictionary<string, int> animalsAtTheZoo = new Dictionary<string, int>();

            animalsAtTheZoo.Add("raccoon", 4);
            animalsAtTheZoo.Add("bear", 5);
            animalsAtTheZoo.Add("tiger", 3);
            animalsAtTheZoo.Add("elephant", 2);
            animalsAtTheZoo.Add("giraffe", 3);
            animalsAtTheZoo.Add("zebra", 6);
            animalsAtTheZoo.Add("lion", 5);
            animalsAtTheZoo.Add("bat", 34);
            animalsAtTheZoo.Add("iguana", 21);
            animalsAtTheZoo.Add("otter", 12);
            animalsAtTheZoo.Add("alligator", 8);

            List<String> animals = animalsAtTheZoo.Keys.ToList();
            int counter = 0;

            while (counter < animalsAtTheZoo.Count)
            {
                Console.WriteLine("{0} {1}",animals[counter], animalsAtTheZoo[animals[counter]]);

                counter++;
            }

            Console.WriteLine("There are {0} bats at the zoo.", animalsAtTheZoo["bat"]);

            animalsAtTheZoo.Remove("zebra");
            animalsAtTheZoo.Add("zebra", 5);
            Console.WriteLine("There are {0} zebras at the zoo.", animalsAtTheZoo["zebra"]);
        }
    }
}
