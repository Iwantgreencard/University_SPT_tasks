using System;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            //Стандартний заголовок лабораторної
            Console.Title = "Лабораторна 20 - завдання 1 \"mynum.txt\" | Піскун Іван | 4 підгруппа |";
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.ResetColor();


            
            Console.WriteLine("Ця программа записує числа які ви вводите в файл mynum.txt\n\"exit\" - для виходу, \"list\" - для показу, списку чисел з файла, \"max\" - максимальне число зі списку, \"min\" - мінімальне");
            // Цикл на управління потоком программиі
            while (true)
            {
                try
                {
                    Console.Write("Введіть своє число: ");
                    string input = Console.ReadLine();
                    string line;
                    List<string> numbers = new List<string>();
                    using (StreamReader sr = new StreamReader("mynum.txt"))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            numbers.Add(line);
                        }
                    }

                    if (input.ToLower() == "exit")
                    {
                        break;
                    }
                    else if (input.ToLower() == "list")
                    {
                        Console.WriteLine(String.Empty);
                        int maxLength = numbers[0].Length;
                        foreach (string l in numbers)
                        {
                            if (l.Length > maxLength)
                            {
                                maxLength = l.Length;
                            }
                        }
                        int counter = 0;
                        double sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            string output = String.Format("{0:f2}", Convert.ToDouble(numbers[i])); 
                            Console.WriteLine("|  {0} елемент - "+ output.PadRight(maxLength+3) + "  |", ++counter);
                            sum += Convert.ToDouble(numbers[i]);
                        }
                        Console.WriteLine("|  Сума = " + sum.ToString().PadRight(maxLength+8) + "  |");
                        Console.WriteLine(String.Empty);
                    }
                    else if(input.ToLower() == "min")
                    {
                        double min = Convert.ToDouble(numbers[0]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (Convert.ToDouble(numbers[i]) < min)
                            {
                                min = Convert.ToDouble(numbers[i]);
                            }
                        }
                        Console.WriteLine("Найменше число зі списку - " + min);
                    }
                    else if (input.ToLower() == "max")
                    {
                        double max = Convert.ToDouble(numbers[0]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (Convert.ToDouble(numbers[i]) > max)
                            {
                                max = Convert.ToDouble(numbers[i]);
                            }
                        }
                        Console.WriteLine("Найбільше число зі списку - " + max);
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter("mynum.txt", true, Encoding.UTF8))
                        {
                            sw.WriteLine(Convert.ToDouble(input));
                            Console.WriteLine("Ваше число записано, можете перевіряти файл.");
                        }
                    }
                }
                catch (Exception a)
                {
                    Console.WriteLine(a.Message);
                }
            }
        }
    }
}
