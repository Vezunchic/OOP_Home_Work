using System;


namespace Lesson_6_Test_2
{
    class Circle: Point
    {
        private int _r;

        public int R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Circle()
        {
            _r = 10;

        }
        public void SquareCircle()
        {
            double S = _r * _r * 3.14 ;
            Console.WriteLine($"\nПлощадь окружности: {S}\n");
          
        }
       
    }
}
