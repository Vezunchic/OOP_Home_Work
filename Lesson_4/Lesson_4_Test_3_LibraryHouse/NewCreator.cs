using Lesson_4_NewHouseDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_NewCreator
{
    public class NewCreator// : Creator
    {
        static public HouseDescription CreateBuild()
        {
            Console.WriteLine("\nКаменный");
            return new NewHouseDescription();
        }
        static public HouseDescription CreateBuild(int a)
        {
            Console.WriteLine("\nДеревянный");
            return new NewHouseDescription();
        }
        static public HouseDescription CreateBuild(int a, int b)
        {
            Console.WriteLine("\nПанельный");
            return new NewHouseDescription();
        }
    }
}
