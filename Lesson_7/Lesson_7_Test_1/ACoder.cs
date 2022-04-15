
using Newtonsoft.Json;
using System;
using System.IO;

namespace Lesson_7_Test_1
{
    class ACoder : IСoder
    {
        public string Encode(string line, string path) //шифрование
        {
            char[] characterString = line.ToCharArray(); //разбиваем линию на символы
            string code = LoadConfiguration(path); // получаем строку для сравнения
            char[] codeChar = code.ToCharArray(); // разбиваем строку на символы
            string newCoupLine = "";
            for (int i = 0; i <= characterString.Length - 1; i++)
            {
                for (int j = 0; j <= codeChar.Length - 1; j++)
                {
                    if (characterString[i] == codeChar[j])
                    {
                        if (characterString[i] == codeChar[codeChar.Length - 1])
                        {
                            newCoupLine += codeChar[0].ToString();
                        }
                        else
                        {
                            newCoupLine += codeChar[j + 1].ToString();
                        }


                        break;
                    }

                }

            }
            Console.WriteLine($"Шифрование методом А: {newCoupLine}");
            return newCoupLine;
        }
        public string Decode(string line, string path)//дешифрования 
        {
            char[] characterString = line.ToCharArray(); //разбиваем линию на символы
            string code = LoadConfiguration(path); // получаем строку для сравнения
            char[] codeChar = code.ToCharArray(); // разбиваем строку на символы
            string newCoupLine = "";
            for (int i = 0; i <= characterString.Length - 1; i++)
            {
                for (int j = 0; j <= codeChar.Length - 1; j++)
                {
                    if (characterString[i] == codeChar[j])
                    {
                        if (characterString[i] == codeChar[0])
                        {
                            newCoupLine += codeChar[codeChar.Length - 1].ToString();
                        }
                        else
                        {
                            newCoupLine += codeChar[j - 1].ToString();
                        }


                        break;
                    }

                }

            }
            Console.WriteLine($"Дешифрование меттодом А: {newCoupLine}");
            return newCoupLine;
        }


        static string LoadConfiguration(string path) // подгрузка символов из файла для сравнения(шифрования) , если его нет то записывает файл
        {
            if (File.Exists(path))
            {
                var textToFile = File.ReadAllText(path);
                try
                {
                    string config = JsonConvert.DeserializeObject<string>(textToFile);
                    return config;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Ошибка: {ex.Message} ");
                    return "";
                }

            }
            else
            {
                string toFile = JsonConvert.SerializeObject("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"); // текст с которыи будет сравнивать для шифрования (если нет файла)
                using (var sw = File.AppendText(path))
                {
                    sw.WriteLine(toFile);
                }
                return LoadConfiguration(path);
            }



        }
    }
}
