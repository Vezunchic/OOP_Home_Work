using System;

namespace Lesson_3_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            string coupLine = CoupLine(line);
            Console.WriteLine(coupLine);
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        }

        private static string CoupLine(string line)
        {
            char[] coupLine = line.ToCharArray();
            string newCoupLine = "";

            for (int symbol = coupLine.Length - 1; symbol >= 0; symbol--)
            {
                newCoupLine += coupLine[symbol].ToString();
            }

            Console.WriteLine();
            return newCoupLine;


        }


    }
}
