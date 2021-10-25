using System;
using System.Text;

namespace Task_12
{
    class Program
    {
        static void Main()
        {

            // Типові формальності
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Завдання 11 | Піскун Іван | 3 підгруппа";

            // Створюю потрібні змінні
            Random rand = new Random();
            int replace_component;
            int last_component;

            // Вивожу текстові данні
            Console.WriteLine("Ця программа створює масив, заповнений випадковими числами \nПотім,зміщає кожний елемент цього масиву вправо на одну позицію");
            Console.Write("Натисніть що небудь для створення масива");
            Console.ReadKey();
            Console.WriteLine();

            // Створюю масив, його розмір - випадково від 5 до 10 символів
            int[] array = new int[rand.Next(5, 10)];

            // Заповнюю масив числасми від 1 до 10
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 10);
            }

            // Вивожу масив
            Console.Write("Ваш масив - [");
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 1)
                {
                    Console.Write("{0}", array[i]);
                }
                else if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }
            }
            Console.Write("]");

            // Беру останній елемент масиву
            last_component = array[array.Length - 1];

            // Цикл, котрий зміщає елементи вправо
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (i == 0)
                {
                    replace_component = last_component;
                }
                else
                {
                    replace_component = array[i-1];
                }
                array[i] = replace_component;
            }
            Console.WriteLine();

            // Вивожу змінений масив
            Console.Write("Ваш змінений масив - [");
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 1)
                {
                    Console.Write("{0}", array[i]);
                }
                else if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }
            }
            Console.Write("]");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
