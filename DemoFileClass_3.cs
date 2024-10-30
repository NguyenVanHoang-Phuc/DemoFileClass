using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileClass
{
    public class DemoFileClass_3
    {
        static void Main(string[] args)
        {
            string path = "MyFile_3.txt";
            Console.WriteLine("*** Demo FileInfo Class ***\n");
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Hello World.");
            }
            Console.WriteLine("Read File: ");
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
            Console.WriteLine("File Infomation: ");
            FileInfo testFile = new FileInfo(path);
            Console.WriteLine($"Name:{testFile.Name}");
            Console.WriteLine($"Creation time:{testFile.CreationTime}");
            Console.WriteLine($"Last Write time:{testFile.LastWriteTime}");
            Console.WriteLine($"Directory Name:{testFile.DirectoryName}");
            Console.ReadLine();
        }
    }
}
