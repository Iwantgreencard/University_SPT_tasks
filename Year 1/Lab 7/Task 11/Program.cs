using System;
using System.Text;

namespace Task_11
{
    class Program
    {
        static void Main()
        {
            // Типові формальності
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Завдання 11 | Піскун Іван | 3 підгруппа";

            // Створюю змінну, для запису туда розміру масива
            int size;
            
            // Вивожу запрошення на вводення розміру масиву
            Console.Write("Скільки елементів буде в вашому масиві? ");

            try
            {
                size = Int32.Parse(Console.ReadLine());

                // Створюю масив з таким розміром
                int[] array = new int[size];

                Console.WriteLine("Отже, розмір вашого масиву - {0}, заповнювати його можна тільки числами.", size);

                // Цикл який запрошує користувача вводити елементи масива
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Число номер {0}: ", i);
                    array[i] = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                // Сортую елемент, щоб виставити елементи від більшого до меншого
                Array.Sort(array);

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
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Вводити можна лише числа і вони повинні бути не великими");
                Console.WriteLine("Введіть y, щоб перезапустити программу або будь що інше, для виходу: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
