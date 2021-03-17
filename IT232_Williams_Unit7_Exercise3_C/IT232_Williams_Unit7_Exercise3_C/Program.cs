using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit7_Exercise3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Method DivideByZero has been created");
                Console.WriteLine("Method FileDoesNotExist has been created");
                Console.WriteLine("Method ArrayOutOfBounds has been created");
                Console.WriteLine("Method ArrayIsNull has been created");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArrayIsNull Error Occured.");
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

        private static int DivideByZero(int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();
            else
                return num1 / num2;
        }

        private static void FileDoesNotExist(String fileName)
        {
            if (File.Exists(fileName))
                Console.WriteLine("File does exist.");
            else
                throw new FileNotFoundException();
        }

        private static void ArrayOutOfBounds(String[] newArray)
        {
            for (int i = 0; i < newArray.Length + 2; i++)
            {
                Console.WriteLine(newArray[i]);
                if (i > newArray.Length)
                    throw new IndexOutOfRangeException();
            }
        }

        private static void ArrayIsNull(String[] newArray)
        {
            if (newArray.Equals(null) || newArray.Equals(""))
                throw new ArgumentNullException();
            else
                Console.WriteLine("CheckForNull passed.");
        }
    }
}
