using System;

namespace Lesson_6_Test_2
{
    class Rectangle : Point
    {
        public int width { get; set; } // ширина
        public int height { get; set; } //высота

        public Rectangle() { }
        public Rectangle( int X,int Y,int width,int height)
        {
            this.width = width;
            this.height = height;
            XСentre = X;
            YСentre = Y;
        }

        public void SquareRectangle()
        {

            double S = width * height;
            Console.WriteLine($"\nПлощадь прямоугольника: {S}\n");

        }

    }
}
