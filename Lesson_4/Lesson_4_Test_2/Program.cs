using System;

namespace Lesson_4_Test_2
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
    /* abstract class Creator
     {
         public abstract HouseDescription CreateBuild();
     }*/
    internal class NewCreator// : Creator
    {
        static public HouseDescription CreateBuild()
        {
            Console.WriteLine("Каменный");
            return new NewHouseDescription();
        }
        static public HouseDescription CreateBuild(int a)
        {
            Console.WriteLine("Деревянный");
            return new NewHouseDescription();
        }
        static public HouseDescription CreateBuild(int a, int b)
        {
            Console.WriteLine("Панельный");
            return new NewHouseDescription();
        }
    }
    abstract class HouseDescription { }

    class NewHouseDescription : HouseDescription
    {


        private int _buildingNumber; //номер дома 
        private double _height = 10;//высота здания
        private int _floors = 2;//этажность
        private int _numberApartments = 4;//количество квартир
        private int _entrances = 2;//количество подьездов

        static int _saveBuildingNumber;// статическая переменная

        public NewHouseDescription()
        {
            SetAccountNumber();
            
        }
        public void SetAccountNumber() //уникальный номер дома
        {
            _buildingNumber = _saveBuildingNumber + 5;
            _saveBuildingNumber = _buildingNumber;

        }
        public double HeightCalculation() //высота этажа
        {
            double floor = _height / _floors;
            return floor;
        }
        public double NumberApartmentsEntrance() //количество квартир в подьезде
        {
            if (_entrances > _numberApartments)
            {
                Console.WriteLine("Не верно введено количество подьездов\n");
                return 0;
            }
            double apartments = _numberApartments / _entrances;
            return apartments;
        }
        public double NumberApartmentsFloor() //количество квартир на этаже
        {
            double apartments = _numberApartments / _floors;
            return apartments;
        }


        public int BuildingNumber
        {
            get { return _buildingNumber; }
            set { _buildingNumber = value; }
        }
        public double Height { get; set; }
        public int Floors { get; set; }
        public int NumberApartments { get; set; }
        public int Entrance { get; set; }



    }
}
