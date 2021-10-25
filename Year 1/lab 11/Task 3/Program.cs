using System;
using System.Text;
using System.Collections;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | Лабораторна 11 | Завдання 3";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            multiple_of_five();

            Console.WriteLine();
            Console.ReadKey();
        }
        static void multiple_of_five()
        {
            int diapazon_min, diapazon_max;
            Queue numbers = new Queue();


            Console.WriteLine("Введіть будь ласка діапазон чисел.");
            try
            {
                Console.Write("Введіть мінімальне число: ");
                diapazon_min = Int32.Parse(Console.ReadLine());
                Console.Write("Введіть максимальне число: ");
                diapazon_max = Int32.Parse(Console.ReadLine());
                int counter = 0;
                for (int i = diapazon_min; i < diapazon_max + 1; i++)
                {
                    if (i % 5 == 0)
                    {
                        counter++;
                        numbers.Enqueue(i);
                    }
                }
                Console.WriteLine("В діапазоні, що ви вказали {0} чисел(-а) кратних 5", counter);
                foreach (Object number in numbers)
                {
                    Console.Write("{0} | ", number);
                }
            }
            catch
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Вводити можна лише цілі числа");
                Console.WriteLine("Введіть y, щоб перезапустити программу або будь що інше, для виходу: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
        }
    }
}