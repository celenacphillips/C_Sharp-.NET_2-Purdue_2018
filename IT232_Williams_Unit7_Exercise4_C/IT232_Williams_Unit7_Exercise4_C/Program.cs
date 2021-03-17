using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit7_Exercise4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String filePath = ("../../../logfile.log");
            String[] array1 = new String[1];
            String[] array2 = null;

            CreateFile(filePath);

            try
            {
                Console.WriteLine("DivideByZero test started");
                DivideByZero(1,0, filePath);
            }
            catch (DivideByZeroException)
            {
                StringReader sReader = new StringReader(File.ReadAllText(filePath));

                String[] fileText = sReader.ReadToEnd().Split('\r');

                TextWriter stdErr = new StreamWriter(filePath);
                Console.SetError(stdErr);

                for (int i = 0; i < fileText.Length; i++)
                {
                    Console.Error.WriteLine(fileText[i] + "\n");
                }

                Console.Error.WriteLine("  DivideByZero Error Occured.");
                Console.Error.Close();
                Console.WriteLine("DivideByZero test completed\n");
            }



            try
            {
                Console.WriteLine("FileNotFound test started");
                FileDoesNotExist("text.txt");
            }
            catch (FileNotFoundException)
            {
                StringReader sReader = new StringReader(File.ReadAllText(filePath));

                String[] fileText = sReader.ReadToEnd().Split('\r');

                TextWriter stdErr = new StreamWriter(filePath);
                Console.SetError(stdErr);

                for (int i = 0; i < fileText.Length; i++)
                {
                    Console.Error.WriteLine(fileText[i] + "\n");
                }

                Console.Error.WriteLine("  FileNotFound Error Occured.");
                Console.Error.Close();
                Console.WriteLine("FileNotFound test completed\n");
            }



            try
            {
                Console.WriteLine("ArrayOutOfBounds test started");
                ArrayOutOfBounds(array1);
            }
            catch (IndexOutOfRangeException)
            {
                StringReader sReader = new StringReader(File.ReadAllText(filePath));

                String[] fileText = sReader.ReadToEnd().Split('\r');

                TextWriter stdErr = new StreamWriter(filePath);
                Console.SetError(stdErr);

                for (int i = 0; i < fileText.Length; i++)
                {
                    Console.Error.WriteLine(fileText[i] + "\n");
                }

                Console.Error.WriteLine("  IndexOutOfRange Error Occured.");
                Console.Error.Close();
                Console.WriteLine("ArrayOutOfBounds test completed\n");
            }



            try
            {
                Console.WriteLine("ArrayIsNull test started");
                ArrayIsNull(array2, filePath);
            }
            catch (NullReferenceException)
            {
                StringReader sReader = new StringReader(File.ReadAllText(filePath));

                String[] fileText = sReader.ReadToEnd().Split('\r');

                TextWriter stdErr = new StreamWriter(filePath);
                Console.SetError(stdErr);

                for (int i = 0; i < fileText.Length; i++)
                {
                    Console.Error.WriteLine(fileText[i] + "\n");
                }

                Console.Error.WriteLine("  NullReferenceException Error Occured.");
                Console.Error.Close();
                Console.WriteLine("ArrayIsNull test completed\n");
            }
        }

        private static void CreateFile(String path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                TextWriter stdErr = new StreamWriter(path);
                string appName = typeof(Program).Assembly.Location;
                appName = appName.Substring(appName.LastIndexOf('\\') + 1);
                Console.SetError(stdErr);
                Console.Error.WriteLine("Error Log for Application {0}", appName);
                Console.Error.Close();

                Console.WriteLine("{0} has been created.", path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static void DivideByZero(int num1, int num2, String fileName)
        {
            if (num2 == 0)
                throw new DivideByZeroException();
            else
            {
                TextWriter stdErr = new StreamWriter(fileName);
                Console.SetError(stdErr);
                Console.Error.WriteLine("DivideByZero Exception Avoided.");
                Console.Error.WriteLine("Answer is {0}.", num1/num2);
                Console.Error.Close();
            }
        }

        private static void FileDoesNotExist(String fileName)
        {
            if (File.Exists(fileName))
            {
                TextWriter stdErr = new StreamWriter(fileName);
                Console.SetError(stdErr);
                Console.Error.WriteLine("File does exist.");
                File.Delete(fileName);
            }
            else
                throw new FileNotFoundException();
        }

        private static void ArrayOutOfBounds(String[] newArray)
        {
            for (int i = 0; i < newArray.Length + 2; i++)
            {
                String answer = newArray[i];
                if (i > newArray.Length)
                    throw new IndexOutOfRangeException();
            }
        }

        private static void ArrayIsNull(String[] newArray, String fileName)
        {
            if (newArray.Equals(null) || newArray.Equals(""))
                throw new NullReferenceException();
            else
            {
                StreamReader reader = File.OpenText(fileName);
                String fileText = reader.ReadLine();
                fileText += "\r\nArray is NOT NULL.";
                reader.Close();

                TextWriter stdErr = new StreamWriter(fileName);
                Console.SetError(stdErr);
                Console.Error.WriteLine(fileText);
                Console.Error.Close();
            }
        }
    }
}
