using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_NewHouseDescription
{
    public abstract class HouseDescription { }

   public class NewHouseDescription : HouseDescription
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
