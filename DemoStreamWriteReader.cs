using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileClass
{
    public class DemoStreamWriteReader
    {
        static void Main(string[] args)
        {
            string input = null;
            string fileName = @"MyData_2.txt";
            Console.WriteLine("*** Demo StreamWriter and StreamReader ***\n");
            using StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine("Hello");
            writer.WriteLine("World");
            writer.WriteLine("!");
            for (int i = 1; i <= 10; i++)
            {
                writer.Write(i + " ");
            }
            writer.Write(writer.NewLine);
            writer.Close();
            Console.WriteLine("File was created.");
            Console.WriteLine("******************");
            Console.WriteLine("Now read data from file.");
            using StreamReader sr = new StreamReader(fileName);
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
