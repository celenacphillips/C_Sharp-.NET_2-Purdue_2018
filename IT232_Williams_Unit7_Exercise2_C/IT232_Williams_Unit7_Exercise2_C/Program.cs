using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit7_Exercise2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String filePath = ("../../../../IT232_Williams_Unit7_Exercise1_C/logfile.log");
            DisplayLogfile(filePath);
        }

        private static void DisplayLogfile (String path)
        {
            try
            {
                if (File.Exists(path))
                {
                    StringReader sReader = new StringReader(File.ReadAllText(path));

                    String[] words = sReader.ReadToEnd().Split(' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        Console.Write (words[i] + " ");
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
