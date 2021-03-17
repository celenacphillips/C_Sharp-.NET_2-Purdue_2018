using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit5_Exercise1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList famousWords = new ArrayList();
            famousWords.Add("Now");
            famousWords.Add("is");
            famousWords.Add("the");
            famousWords.Add("time");
            famousWords.Add("for");
            famousWords.Add("all");
            famousWords.Add("good");
            famousWords.Add("men");
            famousWords.Add("to");
            famousWords.Add("come");
            famousWords.Add("to");
            famousWords.Add("the");
            famousWords.Add("aid");
            famousWords.Add("of");
            famousWords.Add("their");
            famousWords.Add("country.");

            try
            {
                if (File.Exists("../../../FamousWords.txt"))
                {
                    File.Delete("../../../FamousWords.txt");
                }

                FileStream fs = File.Create ("../../../FamousWords.txt");
                foreach (Object obj in famousWords)
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(obj.ToString() + " ");
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
