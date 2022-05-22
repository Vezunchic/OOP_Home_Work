using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Test_1
{
    interface IСoder
    {
        public string Encode() { return""; }//шифрование
       
        public string Decode() { return ""; }//дешифрования 
        
        public void LoadConfiguration() { } // подгрузка файла для шифрования
    }
}
