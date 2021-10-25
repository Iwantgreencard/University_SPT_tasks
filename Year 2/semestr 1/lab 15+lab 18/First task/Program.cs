using System;
using System.Text;

namespace lab_15
{
    public class Point
    {
        protected int x;
        protected int y;


        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void set_x(int x)
        {
            this.x = x;
        }
        public void set_y(int y)
        {
            this.y = y;
        }
        public virtual void set_coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void show_coordinates()
        {
            Console.WriteLine($"| x = {this.x} ");
            Console.WriteLine($"| y = {this.y} ");

        }
        public void display_point()
        {
            
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Title = "Лабораторна 15 - завдання 1 \"Класс Point\" | Піскун Іван | 4 підгруппа |";
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----Завдання 1-----\n");
            Console.ResetColor();

            // Створюємо об'єкт
            Point first_point = new Point();

            // Заповнюємо координати нашої точки 
            first_point.set_x(14);
            first_point.set_y(88);

            // Виведо координати в консолі
            Console.WriteLine("Координати вашої точки");
            first_point.show_coordinates();

            // Відділяємо першу частину виконання
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----Завдання 2-----\n");
            Console.ResetColor();

            // Створємо ще два об'єкта, відразу заповняючи їх через перенавантажений конструктор
            Point second_point = new Point(5, 6);
            Point third_point = new Point(10, 22);

            // Створюємо масив і заповняємо його попередньо створеними "точками"
            object[] points = { first_point, second_point, third_point };

            // Виводимо наш масив об'єктів
            int i = 1;
            foreach (Point point in points){
                Console.WriteLine($"Координати точки №{i}");
                point.show_coordinates();
                i++;
            }

            // Відділяємо другу частину виконання
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----Завдання 3----- *на відмінну оцінка\n");
            Console.ResetColor();

            // Ствоюємо пустий об'єкт класу Point
            Point last_point = new Point();

            // Створюємо дві змінні для запису в них суми координат попередніх точок
            int sum_of_x = 0;
            int sum_of_y = 0;

            // Додаємо координати точок
            foreach (Point point in points)
            {
                sum_of_x += point.X;
                sum_of_y += point.Y;
            }

            // Записуємо координати в наш останній об'єкт
            last_point.set_x(sum_of_x);
            last_point.set_y(sum_of_y);

            // Виводимо данні про точки
            i = 1;
            foreach (Point point in points)
            {
                Console.WriteLine($"Координати точки №{i}");
                point.show_coordinates();
                i++;
            }
            Console.WriteLine("Координати точки №4");
            last_point.show_coordinates();


            // Рахуємо і виводимо суму всіх координат наших точок
            sum_of_x += sum_of_x;
            sum_of_y += sum_of_y;
            Console.WriteLine("Сума кординати всіх об'єктів x = {0}", sum_of_x);
            Console.WriteLine("Сума кординати всіх об'єктів y = {0}", sum_of_y);

            Console.ReadKey();

            
        }
    }
}
