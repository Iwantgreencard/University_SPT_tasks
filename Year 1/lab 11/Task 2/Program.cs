using System;
using System.Text;
using System.Collections;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | Лабораторна 11 | Завдання 2";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Queue numbers = new Queue();

            int diapazon_min, diapazon_max;

            Console.WriteLine("Введіть будь ласка діапазон чисел.");
            try
            {
                Console.Write("Введіть мінімальне число: ");
                diapazon_min = Int32.Parse(Console.ReadLine());
                Console.Write("Введіть максимальне число: ");
                diapazon_max = Int32.Parse(Console.ReadLine());

                Console.WriteLine("В діапазоні, що ви вказали {0} чисел кратних 5", multiple_of_five(diapazon_min, diapazon_max, numbers));
                Console.Write("Ці числа: | ");
                foreach (Object number in numbers)
                {
                    Console.Write("{0} | ", number);
                }
                Console.WriteLine();
                Console.ReadKey();
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
        static int multiple_of_five(int min, int max, Queue num)
        {
            int counter = 0;
            for (int i = min; i < max+1; i++)
            {
                if (i%5 == 0)
                {
                    counter++;
                    num.Enqueue(i);
                }
            }
            return counter;
        }
    }
}
