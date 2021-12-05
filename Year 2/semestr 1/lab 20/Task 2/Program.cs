using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Лабораторна 20 - завдання 2 \"students.txt\" | Піскун Іван | 4 підгруппа |";
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Ця программа записує прізвища студентів та їх рейтинги, що ви вводите, в файл students.txt\n\"exit\" - для виходу, \"list\" - для показу списку, " +
                "\"search\" - для пошуку за прізвищем");

            while (true)
            {
                try
                {
                    Console.Write("Введіть прізвище: ");
                    string input = Console.ReadLine();
                    string line;
                    List<string> lines = new List<string> { };
                    using (StreamReader sr = new StreamReader("students.txt"))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }

                    if (input.ToLower() == "exit")
                    {
                        break;
                    }
                    else if (input.ToLower() == "search")
                    {
                        int found = 0;
                        string last_name;
                        Console.Write("Введіть прізвище студента: ");
                        input = Console.ReadLine();
                        foreach (string li in lines)
                        {
                            found = li.IndexOf(" - ");
                            last_name = li.Substring(0, found);
                            if (input == last_name)
                            {
                                Console.WriteLine("Прізвище знайдено:");
                                Console.WriteLine(li);
                            }
                        }
                    }
                    else if (input.ToLower() == "list")
                    {
                        Console.WriteLine(String.Empty);
                        int counter = 0;
                        foreach (string l in lines)
                        {
                            Console.WriteLine(++counter + ". " + l);
                        }
                        Console.WriteLine(String.Empty);
                    }
                    else
                    {
                        Console.Write("Введіть рейтинг: ");
                        int input_number = Convert.ToInt32(Console.ReadLine());
                        using (StreamWriter sw = new StreamWriter("students.txt", true, Encoding.UTF8))
                        {
                            sw.WriteLine($"{input} - {input_number}");
                            Console.WriteLine("Записано до файлу.");
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
