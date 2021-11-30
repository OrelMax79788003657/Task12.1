using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task12._1
{
    public static class Circle
    {
        public static void ToCircumference(double radius, out double circumference)
        {
            circumference = 2 * Math.PI * radius;
        }
        public static void ToSquare(double radius, out double square)
        {
            square = 2 * Math.PI * radius * radius;
        }
        public static void IsOverLap(double radius, double x, double y, double x0, double y0, out bool overlap)
        {
            if (Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2)) <= radius)
            {
                overlap = true;
            }
            else
            {
                overlap = false;
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            string tempNum = " ";
            double R = 0;
            double x = 0;
            double y = 0;
            double x0 = 0;
            double y0 = 0;

            bool overlap = false;
            double circumference = 0;
            double square = 0;

            Console.Write("Введите значение радиуса: ");
            tempNum = Console.ReadLine();
            while (!double.TryParse(tempNum, out R))
            {
                Console.Write(" This is not valid input. Try again");
                tempNum = Console.ReadLine();
            }
            Console.Write("Введите значение х для точки: ");
            tempNum = Console.ReadLine();
            while (!double.TryParse(tempNum, out x))
            {
                Console.Write(" This is not valid input. Try again");
                tempNum = Console.ReadLine();
            }
            Console.Write("Введите значение у для точки: ");
            tempNum = Console.ReadLine();
            while (!double.TryParse(tempNum, out y))
            {
                Console.Write(" This is not valid input. Try again");
                tempNum = Console.ReadLine();
            }
            Console.Write("Введите значение х0 для центра: ");
            tempNum = Console.ReadLine();
            while (!double.TryParse(tempNum, out x0))
            {
                Console.Write(" This is not valid input. Try again");
                tempNum = Console.ReadLine();
            }
            Console.Write("Введите значение у0 для ценра: ");
            tempNum = Console.ReadLine();
            while (!double.TryParse(tempNum, out y0))
            {
                Console.Write(" This is not valid input. Try again");
                tempNum = Console.ReadLine();
            }

            Circle.ToCircumference(R, out circumference);
            Console.WriteLine($"\nДлина окружности: {circumference}\n");

            Circle.ToSquare(R, out square);
            Console.WriteLine($"Площадь окружности: {square}\n");

            Circle.IsOverLap(R, x, y, x0, y0, out overlap);
            Console.WriteLine($"Приленадлежит ли точка: {overlap}\n");

            Console.ReadKey();

        }
    }
}
