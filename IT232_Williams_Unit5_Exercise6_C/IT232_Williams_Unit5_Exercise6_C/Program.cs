using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit5_Exercise6_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String filePath = ("../../../test.txt");

            ArrayList storedArrayList = ReadFileAndStoreInArrayList(filePath);

            DisplayFileForwards(storedArrayList);
            Console.WriteLine();
            DisplayFileBackwards(storedArrayList);
        }

        private static ArrayList ReadFileAndStoreInArrayList(String path)
        {
            ArrayList storedList = new ArrayList();

            try
            {
                if (File.Exists(path))
                {
                    StringReader sReader = new StringReader(File.ReadAllText(path));

                    String[] words = sReader.ReadToEnd().Split('\n');

                    for (int i = 0; i < words.Length; i++)
                    {
                        storedList.Add(words[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Error! File not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return storedList;
        }

        private static void DisplayFileForwards(ArrayList newArrayList)
        {
            for (int i = 0; i < newArrayList.Count; i++)
            {
                Console.WriteLine(newArrayList[i]);
            }
        }

        private static void DisplayFileBackwards(ArrayList newArrayList)
        {
            for (int i = newArrayList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(newArrayList[i]);
            };
        }
    }
}
