using System;
using System.Text;

namespace Second_task
{
    public class Person
    {
        protected int height;
        protected int weight;
        protected DateTime date_of_birth;
        protected string last_name;

        public Person() { 
        
        }
        public Person(int height, int weight, DateTime date_of_birth, string last_name)
        {
            this.height = height;
            this.weight = weight;
            this.date_of_birth = date_of_birth;
            this.last_name = last_name;
        }
        public string Last_name
        {
            get { return last_name; }
        }
        public int Height
        {
            get { return height; }
        }
        public int Weight
        {
            get { return weight; }
        }
        public void set_height(int height)
        {
            this.height = height;
        }
        public void set_weight(int weight)
        {
            this.weight = weight;
        }
        public void set_date_of_birth(DateTime date_of_birth)
        {
            this.date_of_birth = date_of_birth;
        }
        public void set_last_name(string last_name)
        {
            this.last_name = last_name;
        }
        public virtual void show_person()
        {
            Console.WriteLine($"| Прізвище: {this.last_name}");
            Console.WriteLine($"| Дата народження: {this.date_of_birth}");
            Console.WriteLine($"| Зріст: {this.height}");
            Console.WriteLine($"| Вага: {this.weight}");
        }
        public virtual void show_person(bool show_picture)
        {
            Console.WriteLine($"     | Прізвище: {this.last_name}");
            Console.WriteLine($" O   | Дата народження: {this.date_of_birth.Date}");
            Console.WriteLine($"/|\\  | Зріст: {this.height} см.");
            Console.WriteLine($"/ \\  | Вага: {this.weight} кг.");
        }   
    }
    class Program
    {
        static void Main()
        {
            Console.Title = "Лабораторна 15 - завдання 2 \"Класс Person\" | Піскун Іван | 4 підгруппа |";
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----Завдання 1-----\n");
            Console.ResetColor();

            // Створюємо три об'єкта класа Person
            // Перші два заповнюємо через конструктор, третій створюємо пустим
            Person first_person = new Person(165, 50, new DateTime(2003, 8, 12), "Піскун");
            Person second_person = new Person(192, 75, new DateTime(1999, 12, 24), "Довгов'язов");
            Person third_person = new Person();

            // Заповнюємо третій об'єкт через методи нашого класа
            third_person.set_height(170);
            third_person.set_weight(120);
            third_person.set_last_name("Товстий");
            third_person.set_date_of_birth(new DateTime(2000, 6, 2));

            // Поміщаємо наші об'єкти в масив
            Object[] persons = { first_person, second_person, third_person };

            int average_weight = 0;

            // Виводимо вміст об'єктів на екран
            foreach (Person person in persons)
            {
                // Записуємо спільну вагу
                average_weight += person.Weight;
                person.show_person(true);
                Console.WriteLine("-----------------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----Завдання 2----- *на відмінну оцінку\n");
            Console.ResetColor();

            // Рахуємо середню вагу
            average_weight = average_weight / persons.Length;
            Console.WriteLine($"Cередня вага всіх людей вище - {average_weight} кг.");

            Console.ReadKey();
        }
    }
}
