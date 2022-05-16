using System;

namespace Lesson_4_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseDescription one = new HouseDescription();
           
            Console.WriteLine("Какая высота здания?");
            one.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("количество этажей?");
            one.Floors = int.Parse(Console.ReadLine());
            Console.WriteLine("количество квартир?");
            one.NumberApartments = int.Parse(Console.ReadLine());
            Console.WriteLine("количество подьездов?");
            one.Entrance = int.Parse(Console.ReadLine());

           
            HouseDescription two = new HouseDescription();
            HouseDescription tree = new HouseDescription();

            Console.WriteLine($"Номер дома: {one.BuildingNumber} высота этажа: {one.HeightCalculation()} количество квартир в подьезде: {one.NumberApartmentsEntrance()}  количество квартир на этаже: {one.NumberApartmentsFloor()} ");
            Console.WriteLine($"\nНомер дома: {two.BuildingNumber} Высота {two.Height} количество этажей{two.Floors} количество квартир{two.NumberApartments} количество подьездов {two.Entrance}  ");
            Console.WriteLine($"\nНомер дома: {tree.BuildingNumber} Высота {tree.Height} количество этажей{tree.Floors} количество квартир{tree.NumberApartments} количество подьездов {tree.Entrance} ");
        }


    }
    class HouseDescription
    {
        private int _buildingNumber; //номер дома 
        private double _height;//высота здания
        private int _floors;//этажность
        private int _numberApartments;//количество квартир
        private int _entrances;//количество подьездов

        static int _saveBuildingNumber;// статическая переменная

        public HouseDescription()
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
            if (_floors > _numberApartments)
            {
                Console.WriteLine("Не верно введено количество этажей или квартир\n");
                return 0;
                
            }
            double apartments = _numberApartments / _floors;
            return apartments;
        }

        public int BuildingNumber
        {
            get { return _buildingNumber; }
            set { _buildingNumber = value; }
        }

        
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

    
        public int Floors
        {
            get { return _floors; }
            set { _floors = value; }
        }
       
        public int NumberApartments
        {
            get { return _numberApartments; }
            set { _numberApartments = value; }
        }
        
        public int Entrance 
        {
            get { return _entrances; }
            set { _entrances = value; }
        }

        
    }
}
