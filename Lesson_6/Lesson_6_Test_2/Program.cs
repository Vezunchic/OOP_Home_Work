using System;

namespace Lesson_6_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало программы:\n");
            Point point = new Point();
            Console.WriteLine($" {point.GetType()}\n{point}\n");

            System.Console.WriteLine("На сколько передвинуть обьект по горизонтали?");
            string coordinateY = Console.ReadLine();
            point.MovingShapeHorizontall(coordinateY); // изменение кординаты по горизонтали
            Console.WriteLine($" {point.GetType()}\n{point}\n"); ;

            System.Console.WriteLine("На сколько передвинуть обьект по вертикали?");
            string coordinateX = Console.ReadLine();
            point.MovingShapeVerticall(coordinateX); // изменение кординаты по вертикали
            Console.WriteLine($"{point.GetType()}\n{point}\n");

            Console.WriteLine("На какой цвет хотите изменить?");
            Console.WriteLine(" 0 = Green,\n 1 = Blue,\n 2 = Red,\n 3 = White, \n 4 = Yellow \n 5 = Black");
            string color = Console.ReadLine();
            point.ChangingColor(color);        // изменение цвета
            Console.WriteLine($"\n {point.GetType()}\n{point}\n");

            Console.WriteLine("Хотите изменить статус видимости обьекта? y или n.");
            string confirmation = Console.ReadLine();
            point.StatusSurveyShape(confirmation);   // изменение статуса
            Console.WriteLine($"\n {point.GetType()}\n{point}\n");

            Circle сircle = new Circle();
            Console.WriteLine($" {сircle.GetType()}\n{сircle}\n Радиус \t {сircle.R}");
            сircle.SquareCircle();       // расчет площади окружности
            

            Rectangle rectangle = new Rectangle(10,10,100,100);
            Console.WriteLine($"\n {rectangle.GetType()}\n{rectangle}\n Высота: {rectangle.height}\tШирина: {rectangle.width}");
            rectangle.SquareRectangle(); // расчет площади прямоугольника
            System.Console.WriteLine("На сколько передвинуть обьект по горизонтали?");
            rectangle.MovingShapeHorizontall(Console.ReadLine());// изменение кординаты по горизонтали
            Console.WriteLine($"\n {rectangle.GetType()}\n{rectangle}\n Высота: {rectangle.height}\tШирина: {rectangle.width}");
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        }
    }
}
