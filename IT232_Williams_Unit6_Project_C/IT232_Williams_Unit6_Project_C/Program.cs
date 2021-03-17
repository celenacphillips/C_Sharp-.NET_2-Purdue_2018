using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit6_Project_C
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number1 = 1;
                int number2 = 0;
                String[] nameArray = { "Joe", "Sam" };
                String path = "filename.txt";


                RangeCheck(20);
                CheckForNull("something");
                ArrayOutOfBounds(nameArray);
                FileDoesNotExist(path);
                Console.WriteLine("The answer to {0} / {1} is {2}.", number1, number2, DivideByZero(number1, number2));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("RangeCheck NOT passed.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("CheckForNull NOT passed.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ArrayOutOfBounds Error Occured.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileDoesNotExist Error Occured.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZero Error Occured.");
            }

        }

        private static void RangeCheck (int num1)
        {
            if (num1 > 0 && num1 < 26)
                Console.WriteLine("RangeCheck passed.");
            else
                throw new ArgumentOutOfRangeException();
        }

        private static void CheckForNull (String value)
        {
            if (value.Equals(null) || value.Equals(""))
                throw new ArgumentNullException();
            else
                Console.WriteLine("CheckForNull passed.");
        }

        private static void ArrayOutOfBounds (String [] newArray)
        {
            for (int i = 0; i < newArray.Length +2; i++)
            {
                Console.WriteLine(newArray[i]);
                if (i > newArray.Length)
                    throw new IndexOutOfRangeException();
            }
        }

        private static void FileDoesNotExist (String fileName)
        {
            if (File.Exists(fileName))
                Console.WriteLine("File does exist.");
            else
                throw new FileNotFoundException();                
        }

        private static int DivideByZero (int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();
            else
                return num1 / num2;

        }
    }
}
