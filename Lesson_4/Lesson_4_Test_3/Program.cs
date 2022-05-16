using System;
using Lesson_4_NewHouseDescription;
using Lesson_4_NewCreator;

namespace Lesson_4_Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип дома: \nКаменный :\t1 \nДеревянный :\t2 \nПанельный :\t3");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    {
                        NewHouseDescription home = (NewHouseDescription)NewCreator.CreateBuild();
                        Console.WriteLine($"\nНомер дома: {home.BuildingNumber} высота этажа: {home.HeightCalculation()} количество квартир в подьезде: {home.NumberApartmentsEntrance()}  количество квартир на этаже: {home.NumberApartmentsFloor()} ");
                    }
                    break;
                case 2:
                    {
                        NewHouseDescription home = (NewHouseDescription)NewCreator.CreateBuild(1);
                        Console.WriteLine($"\nНомер дома: {home.BuildingNumber} высота этажа: {home.HeightCalculation()} количество квартир в подьезде: {home.NumberApartmentsEntrance()}  количество квартир на этаже: {home.NumberApartmentsFloor()} ");
                    }
                    break;
                case 3:
                    {
                        NewHouseDescription home = (NewHouseDescription)NewCreator.CreateBuild(1, 2);
                        Console.WriteLine($"\nНомер дома: {home.BuildingNumber} высота этажа: {home.HeightCalculation()} количество квартир в подьезде: {home.NumberApartmentsEntrance()}  количество квартир на этаже: {home.NumberApartmentsFloor()} ");
                    }
                    break;
            }

            Console.ReadKey();


        }
    }
}
