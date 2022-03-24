using System;
using System.Text;
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

        public static void LoadConfiguration(string path)
        {
            
            if (File.Exists(path))
            {
                var textToFile = File.ReadAllText(path);

                string[] happy = textToFile.Split(new char[] { '&', ' ' }, StringSplitOptions.RemoveEmptyEntries); // данные с файла разбивает по строкам

                for (int i = 0; i < happy.Length; i++) // проходит весь массив строк
                {
                    char[] coupLine = happy[i].ToCharArray(); // Данную строку разбивает на массив символов 
                    foreach (char ch in coupLine) // проходит весь массив символов
                    {
                        if (ch == '@') // Ищет в данном массиве символов элемент
                        {
                            Console.WriteLine(happy[i]);
                            
                            using (var sw = File.AppendText(@"FileMail.txt")) // записывает данный массив строк в файл
                            {
                                sw.WriteLine(happy[i]);
                            }
                            
                            continue;
                        }

                       
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
        



    }
}

        
      
