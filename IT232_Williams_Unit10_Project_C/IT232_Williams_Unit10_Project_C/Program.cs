using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit10_Project_C
{
    class Program : Animal
    {
        static void Main(string[] args)
        {
            Dog ScoobyDoo = new Dog();
            ScoobyDoo.SetName("Scooby Doo");
            ScoobyDoo.SetBreed("Great Dane");
            ScoobyDoo.SetBarkSound("ra-rou");
            ScoobyDoo.SetHairColor("brown");
            ScoobyDoo.SetHairLength("short");
            ScoobyDoo.Sit();

            Dog RinTinTin = new Dog();
            RinTinTin.SetName("Rin Tin Tin");
            RinTinTin.SetBreed("German Shepherd");
            RinTinTin.SetBarkSound("bark bark");
            RinTinTin.SetHairColor("tan");
            RinTinTin.SetHairLength("long");
            RinTinTin.Run();

            Dog Paco = new Dog();
            Paco.SetName("Paco");
            Paco.SetBreed("Chihuahua");
            Paco.SetBarkSound("yip yip");
            Paco.SetHairColor("tan");
            Paco.SetHairLength("short");
            Paco.Stand();

            Dog Banksy = new Dog();
            Banksy.SetName("Banksy");
            Banksy.SetBreed("Rottweiler");
            Banksy.SetBarkSound("grrr grrrr");
            Banksy.SetHairColor("black");
            Banksy.SetHairLength("short");
            Banksy.Run();


            Console.WriteLine("{0} is a {1} with {2}, {3} hair. He says {4} and is currently {5}.\n",
                ScoobyDoo.GetName(), ScoobyDoo.GetBreed(), ScoobyDoo.GetHairLength(), ScoobyDoo.GetHairColor(), ScoobyDoo.GetBarkSound(), ScoobyDoo.GetMovement());

            Console.WriteLine("{0} is a {1} with {2}, {3} hair. He says {4} and is currently {5}.\n",
                RinTinTin.GetName(), RinTinTin.GetBreed(), RinTinTin.GetHairLength(), RinTinTin.GetHairColor(), RinTinTin.GetBarkSound(), RinTinTin.GetMovement());

            Console.WriteLine("{0} is a {1} with {2}, {3} hair. He says {4} and is currently {5}.\n",
                Paco.GetName(), Paco.GetBreed(), Paco.GetHairLength(), Paco.GetHairColor(), Paco.GetBarkSound(), Paco.GetMovement());

            Console.WriteLine("{0} is a {1} with {2}, {3} hair. He says {4} and is currently {5}.\n",
                Banksy.GetName(), Banksy.GetBreed(), Banksy.GetHairLength(), Banksy.GetHairColor(), Banksy.GetBarkSound(), Banksy.GetMovement());
        }
    }
}
