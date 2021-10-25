using System;
using System.Text;


namespace Task_7
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | 3 подгруппа | Завдання 7";
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            int size;
            Random rand = new Random();

            try
            {
                Console.Write("Для створення квадратної матриці, введіть її розмір NxN. N - ");
                size = Int32.Parse(Console.ReadLine());

                int[,] numbers = new int[size, size];
                int[] first_column = new int[size];

                Console.WriteLine("Ваша матриця");
                Console.WriteLine();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        numbers[i, j] = rand.Next(1, 30);
                        if (j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (j == size - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write("{0, 6}", numbers[i, j]);
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.Write("Змінена матриця з переставленими");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" першим ");
                Console.ResetColor();
                Console.Write(" та ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" останнім");
                Console.ResetColor();
                Console.WriteLine(" рядками");
                Console.WriteLine();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0,6}", numbers[i, size-1]);
                            Console.ResetColor();
                        }
                        else if(j == size - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0,6}", numbers[i, 0]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write("{0,6}", numbers[i, j]);
                        }
                    }
                    Console.WriteLine();

                }

            }
            
            catch (Exception A)
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
