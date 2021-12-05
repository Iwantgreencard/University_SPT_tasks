using System;
using System.Text;
using Voucher;
using System.IO;
using System.Runtime;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace lab_21
{

    class Program
    {
        static void help_command()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.ResetColor();
    

            Console.WriteLine("|  exit - для виходу з программи\n" +
                "|  help - для списку команд\n" +
                "|  show_file - виводить вміст файлу\n" +
                "|  show_vouchers - виводить об'єкти записані в файл\n" +
                "|  new_voucher - створити нову путівку та записати її в файл\n" +
                "|  search - пошук за id");
        }
        static void Main()
        {
            string line;
            int count = 0;

            Console.Title = "Лабораторна 21-23 - завдання \"Voucher в файл\" | Піскун Іван | 4 підгруппа | Київський Університет ім. Бориса Грінченка";
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.ResetColor();

            Console.WriteLine("Ця программа дозволяє вам створювати путівки та записує їх в файл vouchers.json, список команд по роботі з нею:");
            help_command();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.ResetColor();

            using (FileStream fs = new FileStream("vouchers.json", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        count++;
                    }
                }
            }

            bool running = true;

            while (running)
            {
                try
                {
                    Random rand = new Random();
                    Console.Write("Команда: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string input = Console.ReadLine();
                    Console.ResetColor();
                    switch (input)
                    {
                        #region Команда вихід та список команд
                        case "exit":
                            running = false;
                            break;
                        case "help":
                            help_command();

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(new string('-', 50));
                            Console.ResetColor();

                            break;
                        #endregion
                        #region вивести на екран файл та вивести звіт
                        case "show_file":
                            Console.WriteLine("Текст файлу:");
                            using ( StreamReader sr = new StreamReader("vouchers.json") )
                            {
                                Console.WriteLine(sr.ReadToEnd());
                            }

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(new string('-', 50));
                            Console.ResetColor();

                            break;
                        case "show_vouchers":
                            string header = $"Звіт по путівкам";
                            int centerX = (Console.WindowWidth / 2) - (header.Length / 2);
                            Console.SetCursorPosition(centerX, Console.CursorTop);
                            Console.Write(header);
                            Console.SetCursorPosition(0, Console.CursorTop + 1);
                            using ( StreamReader sr = new StreamReader("vouchers.json"))
                            {
                                while ((line = sr.ReadLine()) != null)
                                {
                                    Voucher_first voucher = JsonSerializer.Deserialize<Voucher_first>(line);
                                    voucher.show_voucher();
                                }
                            }

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(new string('-', 50));
                            Console.ResetColor();

                            break;
                        case "search":
                            Console.Write("Введіть id путівки: ");
                            input = Console.ReadLine();
                            using (StreamReader sr = new StreamReader("vouchers.json"))
                            {
                                List<Voucher_first> vouchers = new List<Voucher_first>();
                                while ((line = sr.ReadLine()) != null)
                                {
                                    Voucher_first voucher = JsonSerializer.Deserialize<Voucher_first>(line);
                                    vouchers.Add(voucher);
                                }
                                Voucher_first.search_by_id(vouchers.ToArray(), Convert.ToInt32(input));
                            }
                            break;
                        #endregion
                        #region Команда створити путівку
                        case "new_voucher":
                            Voucher_first new_voucher = new Voucher_first();
                            Console.Write("Заповніть будь-ласка куди б ви хотіли поїхати: ");
                            new_voucher.Country = Console.ReadLine();
                            bool is_number = false;
                            while (!is_number)
                            {
                                try
                                {
                                    try
                                    {
                                        Console.Write("На скільки(днів): ");
                                        new_voucher.Period = Convert.ToInt32(Console.ReadLine());
                                        is_number = true;
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Вибачте, вводити можна тільки, цілі числа, спробуйте знову.");
                                        throw;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    is_number = false;
                                }
                            }
                            Console.Write("Тип обслуговування(Bussines, Comfort, VIP): ");
                            bool right_servicicng = false;
                            while (!right_servicicng)
                            {
                                new_voucher.Servicing = Console.ReadLine();
                                int cost = 0;
                                switch ((new_voucher.Servicing).ToLower())
                                {
                                    case "bussines":
                                        cost = rand.Next(1000, 1500) * new_voucher.Period;
                                        right_servicicng = true;
                                        break;
                                    case "comfort":
                                        cost = rand.Next(1500, 2000) * new_voucher.Period;
                                        right_servicicng = true;
                                        break;
                                    case "vip":
                                        cost = rand.Next(2500, 4000) * new_voucher.Period;
                                        right_servicicng = true;
                                        break;
                                    default:
                                        right_servicicng = false;
                                        Console.WriteLine("Вибачте, є тільки три плана обслуговування - Bussines, Comfort, VIP.");
                                        Console.Write("Введіть один з них: ");
                                        break;
                                }
                                new_voucher.set_cost(cost);
                            }
                            count = 0;
                            using (StreamReader sr = new StreamReader("vouchers.json"))
                            {
                                while ((line = sr.ReadLine()) != null)
                                {
                                    count++;
                                }
                            }
                            new_voucher.set_id(210 + count);
                            Console.WriteLine("Ваша путівка:");
                            new_voucher.show_voucher();
                            string json = JsonSerializer.Serialize<Voucher_first>(new_voucher);
                            using ( StreamWriter sw = new StreamWriter("vouchers.json", true))
                            {
                                sw.WriteLine(json);
                            }

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(new string('-', 50));
                            Console.ResetColor();

                            break;
                        #endregion
                    }
                }
                catch (Exception A)
                {
                    Console.WriteLine(A.Message);
                    throw;
                }
            }
        }
    }
}
