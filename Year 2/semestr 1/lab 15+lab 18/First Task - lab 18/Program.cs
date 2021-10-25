using System;
using System.Text;
namespace First_Task___lab_18
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Лабораторна 18 - завдання 1 \"Класс Point3D\" | Піскун Іван | 4 підгруппа |";
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-------------");
            Console.ResetColor();

            // Створюємо об'єкт класу Point3D
            Point3D first_point = new Point3D();
            first_point.set_coordinates(1, 2, 5);
            Console.WriteLine("Перша точка");
            first_point.show_coordinates();

            Point3D second_point = new Point3D(7, 8, 5);
            Point3D third_point = new Point3D(12, 1, 6);

            Point3D[] points = {first_point, second_point, third_point};

            int sum_x = 0;
            Console.WriteLine("\n-------------");
            Console.WriteLine("Массив точок");
            foreach (Point3D point in points)
            {
                point.show_coordinates();
                Console.WriteLine();
                sum_x += point.X;
            }
            Console.WriteLine("Сумма X координат точок массиву: {0}", sum_x);
            Console.WriteLine("\n-------------");
            Console.WriteLine("Точка, координати якої дорівнюють сумі всіх точок масиву вище");
            Point3D last_point = new Point3D();
            last_point = first_point + second_point + third_point;
            last_point.show_coordinates();
            Console.ReadLine();

        }
    }
}
