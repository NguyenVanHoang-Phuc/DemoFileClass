using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileClass
{
    public class DemoDirectoryClass
    {
        static void Main(string[] args)
        {
            string sourceDirectory = Directory.GetCurrentDirectory();
            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.*");
                foreach (string currentFile in txtFiles)
                {
                    Console.WriteLine(currentFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
