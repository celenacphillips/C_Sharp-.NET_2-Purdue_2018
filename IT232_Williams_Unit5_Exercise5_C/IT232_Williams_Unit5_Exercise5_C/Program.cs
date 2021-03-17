using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit5_Exercise5_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String famousWordsPath = ("../../../../IT232_Williams_Unit5_Exercise1_C/FamousWords.txt");

            String[] famousWordsArray = ReadFileAndStoreInArray(famousWordsPath);
            DisplayOneWordAtATime(famousWordsArray);
            AllOnOneLine(famousWordsArray);
        }

        private static String[] ReadFileAndStoreInArray(String path)
        {
            String[] words = new String[] { "" };
            try
            {
                if (File.Exists(path))
                {
                    StringReader sReader = new StringReader(File.ReadAllText(path));
                    words = sReader.ReadToEnd().Split(' ');
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

            return words;
        }

        private static void DisplayOneWordAtATime(String[] newStringArray)
        {
            for (int i = 0; i < newStringArray.Length; i++)
            {
                Console.WriteLine (newStringArray[i].ToString());
            }
        }

        private static void AllOnOneLine(String [] newStringArray)
        {
            for (int i = 0; i < newStringArray.Length; i++)
            {
                Console.Write("{0} ", newStringArray[i]);
            }
            Console.WriteLine();
        }
    }
}
