using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit5_Exercise2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String famousWordsPath = ("../../../../IT232_Williams_Unit5_Exercise1_C/FamousWords.txt");

            ReadFileAndStoreInArrayList(famousWordsPath);
        }

        private static void ReadFileAndStoreInArrayList (String path)
        {
            ArrayList famousWordsAL = new ArrayList();

            try
            {
                if (File.Exists(path))
                {
                    StringReader sReader = new StringReader(File.ReadAllText(path));

                    String[] words = sReader.ReadToEnd().Split (' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        famousWordsAL.Add(words[i]);
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
        }
    }
}
