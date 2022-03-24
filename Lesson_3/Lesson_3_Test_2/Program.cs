using System;

namespace Lesson_3_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            LineFeed(line);
           
        }

        private static void LineFeed(string line)
        {
            char[] coupLine = line.ToCharArray();
            for (int symbol = coupLine.Length - 1; symbol >= 0; symbol--)
            {
                Console.Write(coupLine[symbol]);
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        }

       
    }
}
