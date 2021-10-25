using System;
using System.Text;

namespace Task_9
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | 3 подгруппа | Завдання 9";
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            int size_N, size_M, diapazon_min, diapazon_max, max_element, min_element, suma;
            Random rand = new Random();

            try
            {
                Console.Write("Для створення матриці, введіть її розміри NxM. N - ");
                size_N = Int32.Parse(Console.ReadLine());
                Console.Write("                                               M - ");
                size_M = Int32.Parse(Console.ReadLine());

                int[,] matrix = new int[size_N, size_M];
                int[,] second_matrix = new int[3, size_M];

                Console.WriteLine();
                Console.WriteLine("Тепер введіть діапазон чисел, з інтервалу яких, будуть заповнятися елементи матриці");
                Console.Write("Мінімальне число - ");
                diapazon_min = Int32.Parse(Console.ReadLine());
                Console.Write("Максимальне число - ");
                diapazon_max = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < size_N; i++)
                {
                    for (int j = 0; j < size_M; j++)
                    {
                        matrix[i, j] = rand.Next(diapazon_min, diapazon_max);
                    }
                }

                Console.WriteLine("Сформована матриця");
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    suma = 0;
                    max_element = matrix[0, i];
                    min_element = matrix[0, i];
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        suma += matrix[j, i];
                        if (matrix[j, i] > max_element)
                        {
                            max_element = matrix[j, i];
                        }
                        if (matrix[j, i] < min_element)
                        {
                            min_element = matrix[j, i];
                        }
                    }
                    second_matrix[0, i] = max_element;
                    second_matrix[1, i] = suma / size_N;
                    second_matrix[2, i] = min_element;
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write("{0,6}", matrix[i, j]);
                    }
                    Console.WriteLine();

                }
                Console.WriteLine();
                for (int i = 0; i < second_matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < second_matrix.GetLength(1); j++)
                    {
                        if (i == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if (i == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        if (i == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.Write("{0, 6}", second_matrix[i, j]);
                    }
                    if (i == 0)
                    {
                        Console.WriteLine(" - Максимальні значення стовпців матриці вище");
                    }
                    if (i == 1)
                    {
                        Console.WriteLine(" - Середнє арифметичне стовпців матриці вище");
                    }
                    if (i == 2)
                    {
                        Console.WriteLine(" - Мінімальні значення стовпців матриці вище");
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Вводити можна лише числа");
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

    /*
suma += matrix[i, j];
if (matrix[i, r] > max_element)
{
    max_element = matrix[i, r];
    Console.ForegroundColor = ConsoleColor.Red;
}
if (matrix[i, r] < min_element)
{
    min_element = matrix[i, r];
    Console.ForegroundColor = ConsoleColor.Blue;
}
Console.Write("{0, 6}", matrix[i, r]);
Console.ResetColor();
    */