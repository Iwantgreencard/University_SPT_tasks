using System;
using System.Text;

namespace lab_10
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | 3 подгруппа | варіант 11";
            Console.OutputEncoding = Encoding.UTF8;

            int[,] matrix = new int[10, 10];
            int suma = 0;

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rand.Next(-10, 15);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        suma += matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0, 4}", matrix[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0, 4}", matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Сума елементів на діагоналі:");
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        if (i < 9)
                        {
                            if (matrix[i+1, j+1] < 0)
                            {
                                Console.Write(matrix[i, j]);
                            }
                            else
                            {
                                Console.Write(matrix[i, j] + "+");
                            }
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        suma += matrix[i, j];
                    }
                }
            }
            Console.ResetColor();
            Console.WriteLine("= " + suma);
            Console.WriteLine();
            Console.WriteLine("Змінена матриця");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(matrix[i,j] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0, 4}",matrix[i, j] + suma);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0, 4}",matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
