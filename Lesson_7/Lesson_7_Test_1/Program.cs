using Newtonsoft.Json;
using System;
using System.IO;

namespace Lesson_7_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line = "АБЭЮЯ";
            Console.WriteLine("Исходный текст: АБЭЮЯ");
            string path = @"FileInfo.txt";
            ACoder encryptionA = new ACoder();
            string codeA = encryptionA.Encode(line, path);
            encryptionA.Decode(codeA,path);
            BCoder encryptionB = new BCoder();
            string codeB = encryptionB.Encode(line, path);
            encryptionB.Decode(codeB, path);
            Console.WriteLine("нажмите клавишу");
            Console.ReadKey();

        }
    }
}
