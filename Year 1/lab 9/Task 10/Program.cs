using System;
using System.Text;
using System.Collections;

namespace Task_10
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | 3 подгруппа | Завдання 10";
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8; 

            int n;
            int m;
            Queue possible_winner = new Queue();
            Queue possible_winner_by_number = new Queue();
            int counter = 0;
            int index_of_max = 0;


            Random rand = new Random();
            try
            {
                Console.Write("Скільки буде гравців? ");
                n = Int32.Parse(Console.ReadLine());
                Console.Write("Скільки стрибків вони будуть робити? ");
                m = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                double[,] results = new double[n, m];
                double[] possible_winners_by_suma = new double[n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        results[i, j] = Math.Round(rand.NextDouble()*10/2, 1) ;
                    }
                }
                double max_result = results[0,0];
                double suma_results = 0;
                int counter_max_result = 0;






                for (var i = 0; i < n; i++)
                {
                    suma_results = 0;
                    for (int j = 0; j < m; j++)
                    {
                        suma_results += results[i, j];
                        if (results[i, j] > max_result)
                        {
                            max_result = results[i, j];
                            index_of_max = i+1;
                        }
                    }
                    possible_winners_by_suma[i] = suma_results;
                }

                for (var i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (results[i, j] == max_result)
                        {
                            counter_max_result++;
                            possible_winner.Enqueue(i + 1);
                            break;
                        }
                    }
                }

                double max_suma = possible_winners_by_suma[0];

                for (var i = 0; i < possible_winners_by_suma.Length; i++)
                {
                    foreach (Object num in possible_winner)
                    {
                        if (Convert.ToInt32(num) == i+1)
                        {
                            if (possible_winners_by_suma[i] > max_suma)
                            {
                                max_suma = possible_winners_by_suma[i];
                                index_of_max = i + 1;
                            }
                        }
                    }
                }

                for (var i = 0; i < possible_winners_by_suma.Length; i++)
                {
                            if (possible_winners_by_suma[i] == max_suma)
                            {
                                counter++;
                                possible_winner_by_number.Enqueue(i + 1);
                                continue;
                            }
                }




                Console.WriteLine("Таблиця результатів");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0, 2}", i + 1);
                    Console.Write(" |");
                    for (int j = 0; j < m; j++)
                    {
                        if (results[i,j] == max_result)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.Write("{0, 6} м", results[i, j]);
                        Console.ResetColor();
                    }
                    Console.Write(" |");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.Write("Максимальний результат - {0} ", max_result);
                if (counter_max_result > 1)
                {
                    Console.WriteLine("Мають {0} гравці(-в)", possible_winner.Count);
                    Console.WriteLine("Переможцем з них буде той, в кого сума всіх стрибків буде більшою");
                    Console.WriteLine();
                    if (counter > 1)
                    {
                        Console.WriteLine("Виявилось, що сума результатів у {0} з цих гравців також однакова - {1}, тепер переможцем буде той гравець, номер якого найменший", counter, Math.Round(max_suma, 2));
                        int min = Convert.ToInt32(possible_winner_by_number.Peek());
                        foreach (Object num in possible_winner_by_number)
                        {
                            if (Convert.ToInt32(num) < min)
                            {
                                min = Convert.ToInt32(num);
                                Console.WriteLine("{0, 2} {1, 6}", num, min);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Виграє гравець з номером {0}", min);

                    }
                    else
                    {
                        Console.WriteLine("Переможцем стає гравець з номером {0}, сума всіх його стрибків - {1}", index_of_max, Math.Round(max_suma, 2));
                    }
                }
                else
                {
                    Console.WriteLine("Виграє гравець з номером - {0}", index_of_max);
                }
                Console.WriteLine();

            }

            catch(Exception A)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Вводити можна лише числа також, не може бути 0 гравців або 0 стрибків");
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
