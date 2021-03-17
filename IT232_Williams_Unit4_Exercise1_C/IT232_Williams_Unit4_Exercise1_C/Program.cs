using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit4_Exercise1_C
{
    struct car
    {
        public string make, model, color;
    }

    class Program
    {
        static void Main(string[] args)
        {
            car[] newCar = new car [3];

            newCar[0].make = "Toyota";
            newCar[0].model = "Camrey";
            newCar[0].color = "Blue";

            newCar[1].make = "Ford";
            newCar[1].model = "Mustang";
            newCar[1].color = "Red";

            newCar[2].make = "Chevrolet";
            newCar[2].model = "Nova";
            newCar[2].color = "Yellow";

            for (int i = 0; i < newCar.Length; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", newCar[i].make, newCar[i].model, newCar[i].color);
            }
        }
    }
}
