using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit5_Exercise4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String famousWordsPath = ("../../../../IT232_Williams_Unit5_Exercise1_C/FamousWords.txt");

            ArrayList famousWordsAL = ReadFileAndStoreInArrayList(famousWordsPath);
            AllOnOneLine(famousWordsAL);
        }

        private static ArrayList ReadFileAndStoreInArrayList(String path)
        {
            ArrayList storedList = new ArrayList();

            try
            {
                if (File.Exists(path))
                {
                    StringReader sReader = new StringReader(File.ReadAllText(path));

                    String[] words = sReader.ReadToEnd().Split(' ');

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

        private static void AllOnOneLine(ArrayList newArrayList)
        {
            for (int i = 0; i < newArrayList.Count; i++)
            {
                Console.Write("{0} ", newArrayList[i]);
            }
            Console.WriteLine();
        }
    }
}
