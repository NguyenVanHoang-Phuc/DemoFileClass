using System.Text;

namespace DemoFileClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Demo File Stream ****");
            using FileStream fStream = File.Open("MyFile.dat", FileMode.Create);
            string msg = "abcdef";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            fStream.Position = 0;
            Console.Write("Print message as an array of bytes: \n");
            byte[] bytesFromFile = new byte[msgAsByteArray.Length];
            for (int i = 0; i < msgAsByteArray.Length; i++)
            {
                bytesFromFile[i] = (byte)fStream.ReadByte();
                Console.Write($"{bytesFromFile[i],5}");
            }
            Console.WriteLine("\nDecode Message: ");
            Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            Console.ReadLine();
        }
    }
}