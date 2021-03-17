using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit7_Project_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String filePath = "../../../logfile.txt";
            String[] array = null;

            try
            {
                LogFileSetup(filePath);
                FirstDoThis(filePath);
                ThenDoThat(filePath);
            }
            catch(Exception)
            {
                Console.WriteLine("Error in Task 1");
                Console.Error.WriteLine("Error in Task 1");
            }



            try
            {
                ArrayIsNull(array, filePath);
            }
            catch (NullReferenceException)
            {
                StringReader sReader = new StringReader(File.ReadAllText(filePath));

                String[] fileText = sReader.ReadToEnd().Split('\n');

                TextWriter stdErr = new StreamWriter(filePath);
                Console.SetError(stdErr);

                for (int i = 0; i < fileText.Length; i++)
                {
                    Console.Error.WriteLine(fileText[i] + "\n");
                }

                Console.Error.WriteLine("NullReferenceException Error Occured.");
                Console.Error.WriteLine("Object reference not set to an instance of an object.");

                CloseLogFile();
            }


            DisplayLogFile(filePath);
        }

        private static void LogFileSetup (String path)
        {
            try
            {
                TextWriter stdErr = new StreamWriter(path);
                string appName = typeof(Program).Assembly.Location;
                appName = appName.Substring(appName.LastIndexOf('\\') + 1);
                Console.SetError(stdErr);
                Console.Error.WriteLine("Error Log for Application {0}", appName);
                Console.WriteLine("{0} has been created.", path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static void CloseLogFile ()
        {
            Console.Error.Close();
        }

        private static void FirstDoThis (String path)
        {
            CloseLogFile();

            StringReader sReader = new StringReader(File.ReadAllText(path));

            String[] fileText = sReader.ReadToEnd().Split('\r');

            TextWriter stdErr = new StreamWriter(path);
            Console.SetError(stdErr);

            for (int i = 0; i < fileText.Length; i++)
            {
                Console.Error.WriteLine(fileText[i] + "\n");
            }
            
            Console.Error.WriteLine("FirstDoThis");
        }

        private static void ThenDoThat (String path)
        {
            CloseLogFile();

            StringReader sReader = new StringReader(File.ReadAllText(path));

            String[] fileText = sReader.ReadToEnd().Split('\r');

            TextWriter stdErr = new StreamWriter(path);
            Console.SetError(stdErr);

            for (int i = 0; i < fileText.Length; i++)
            {
                Console.Error.WriteLine(fileText[i] + "\n");
            }

            Console.Error.WriteLine("ThenDoThat");
        }

        private static void ArrayIsNull(String[] newArray, String path)
        {
            CloseLogFile();

            if (newArray.Equals(null) || newArray.Equals(""))
                throw new NullReferenceException();
            else
            {
                StreamReader reader = File.OpenText(path);
                String fileText = reader.ReadLine();
                fileText += "\r\nArray is NOT NULL.";
                reader.Close();

                TextWriter stdErr = new StreamWriter(path);
                Console.SetError(stdErr);
                Console.Error.WriteLine(fileText);
            }
        }

        private static void DisplayLogFile (String path)
        {
            CloseLogFile();

            try
            {
                if (File.Exists(path))
                {
                    StringReader sReader = new StringReader(File.ReadAllText(path));

                    String[] words = sReader.ReadToEnd().Split('\n');

                    for (int i = 0; i < words.Length; i++)
                    {
                        Console.Write(words[i] + "\n");
                    }
                }
                else
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}
