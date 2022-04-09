using System;
using System.IO;

namespace Lesson_3_Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"FileInfo.txt";
            
            LoadConfiguration(path);


        }

        public static void LoadConfiguration(string path) //проверяет наличие файла
        {

            if (File.Exists(path))
            {
                var textToFile = File.ReadAllText(path);
                string[] lines = textToFile.Split(new char[] { '&', ' ' }, StringSplitOptions.RemoveEmptyEntries); // данные с файла разбивает по строкам
                for (int i = 0; i < lines.Length; i++) // проходит весь массив строк
                {
                    char[] coupLine = lines[i].ToCharArray(); // Данную строку разбивает на массив символов 
                    foreach (char ch in coupLine) // проходит весь массив символов
                    {
                        EmailAddress(ch, lines[i]);//поиск mail
                        
                    }

                }
                
            }
            else
            {
                Console.WriteLine("Файл не найден!");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();

        }

        public static void EmailAddress(char ch, string lines)
        {
            if (ch == '@') // Ищет в данном массиве символов элемент
            {
                Console.WriteLine(lines);

                using (var sw = File.AppendText(@"FileMail.txt")) // записывает данный массив строк в файл
                {
                    sw.WriteLine(lines);
                }

                
            }

        }


    }
}



