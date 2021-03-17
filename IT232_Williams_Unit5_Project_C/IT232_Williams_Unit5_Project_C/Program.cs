using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit5_Project_C
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList produceList = new ArrayList();

            produceList.Add("bananas 0.59");
            produceList.Add("grapes 2.99");
            produceList.Add("apples 1.49");
            produceList.Add("pears 1.39");
            produceList.Add("lettuce 0.99");
            produceList.Add("onions 0.79");
            produceList.Add("potatoes 0.59");
            produceList.Add("peaches 1.59");

            String filePath = ("../../../ProducePrice.txt");

            CreateFile(filePath, produceList);
            Console.WriteLine ("There are {0} products in the file.", FileLineCount(filePath));

            AddToFile(filePath);
            Console.WriteLine("There are {0} products in the file.", FileLineCount(filePath));

            ArrayList storedList = ReadFileAndStoreInArrayList(filePath);

            int counter = 0;
            foreach (String item in storedList)
            {
                counter++;
                Console.WriteLine("{0} {1}", counter, item);
            }
            Console.WriteLine("There are {0} products in the file.", FileLineCount(filePath));
        }

        private static void CreateFile (String path, ArrayList fileList)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (FileStream fs = File.Create(path))
                {
                    foreach (Object obj in fileList)
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(obj.ToString() + "\r\n");
                        fs.Write(info, 0, info.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static void AddToFile(String path)
        {
            ArrayList newList = new ArrayList();
            newList.Add("peppers 0.99");
            newList.Add("celery 1.29");
            newList.Add("cabbage 0.79");
            newList.Add("tomatoes 1.19");

            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        foreach (Object obj in newList)
                        {
                            sw.WriteLine(obj.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static int FileLineCount (String path)
        {
            int count = 0;

            try
            {
                if (File.Exists(path))
                {
                    StringReader sReader = new StringReader(File.ReadAllText(path));

                    String[] words = sReader.ReadToEnd().Split('\n');

                    count = words.Length - 1;
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

            return count;
        }

        private static ArrayList ReadFileAndStoreInArrayList(String path)
        {
            ArrayList productList = new ArrayList();

            try
            {
                if (File.Exists(path))
                {
                    using (StringReader sReader = new StringReader(File.ReadAllText(path)))
                    {
                        String[] words = sReader.ReadToEnd().Split('\n');

                        for (int i = 0; i < words.Length; i++)
                        {
                            productList.Add(words[i]);
                        }
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

            return productList;
        }

    }
}
