using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit7_Exercise1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String filePath = ("../../../logfile.log");
            CreateFile(filePath);
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

                Console.WriteLine("File has been created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
