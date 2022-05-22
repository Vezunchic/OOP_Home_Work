using System;
namespace Lesson_6_Test_2

{
    class Figure
    {
        private Color _shapeColor; // цвет
        private VisibilityStatus _conditionShape; //видмость обьекта
        private int _xСentre; // Координата Х
        private int _yСentre;// Координата У

        public int XСentre
        {
            get { return _xСentre; }
            set { _xСentre = value; }
        }
        public int YСentre
        {
            get { return _yСentre; }
            set { _yСentre = value; }
        }

        public Figure()
        {

            _conditionShape = VisibilityStatus.Visible;
            Console.ForegroundColor = ConsoleColor.Green;
            _shapeColor = Color.Green;
        }
        public void MovingShapeHorizontall(string coordinateX)// передвижение по горризонтали
        {

            bool result = int.TryParse(coordinateX, out var check); // Проверка на правельный ввод 
            if (result == true)
            {

                XСentre = XСentre + check;
            }
            else
            {
                Console.WriteLine("Не првельный ввод.");

            }


        }
        public void MovingShapeVerticall(string coordinateY)// передвижение по вертикали
        {

            bool result = int.TryParse(coordinateY, out var check); // Проверка на правельный ввод 
            if (result == true)
            {

                YСentre = YСentre + check;
            }
            else
            {
                Console.WriteLine("Не првельный ввод.");

            }
        }
        public void ChangingColor(string color) //изменение цвета
        {

            bool result = int.TryParse(color, out var check); // Проверка на правельный ввод 
            if (result == true)
            {
                _shapeColor = GetColorSelection(check);

            }
            else
            {
                Console.WriteLine("Не првельный ввод.");
            }

        }
        public void StatusSurveyShape(string confirmation) //определение статуса отображения
        {


            if (confirmation == "y")
            {
                if (_conditionShape != VisibilityStatus.Visible)
                {
                    _conditionShape = VisibilityStatus.Visible;
                    Console.WriteLine("Статус: Visible");
                    return;
                }
                if (_conditionShape != VisibilityStatus.Invisible)
                {
                    _conditionShape = VisibilityStatus.Invisible;
                    Console.WriteLine("Статус: Invisible");
                    return;
                }

            }
            Console.WriteLine("Стаус не изменен\n");
        }

        private Color GetColorSelection(int number) // выбор цвета
        {

            switch (number)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    return Color.Blue;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    return Color.Red;
                case 3:
                    Console.ForegroundColor = ConsoleColor.White;
                    return Color.White;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return Color.Yellow;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Black;
                    return Color.Black;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            return Color.Green;
        }
        public override string ToString()
        {

            return string.Format($" Цвет : \t { _shapeColor}\n Видмость обьекта :\t { _conditionShape}\n Координаты центра: \t ({_xСentre}; {_yСentre})");
        }

        enum Color
        {
            Green,
            Blue,
            Red,
            White,
            Yellow,
            Black
        }
        enum VisibilityStatus
        {
            Visible,
            Invisible

        }

    }
}
