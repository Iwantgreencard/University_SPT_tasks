using System;
using System.Text;
using System.Linq;
namespace Task_8
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | 3 подгруппа | Завдання 8";
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            string name, password;

            string[,,] rights = { {{ "Alice", "Bob", "Carl" }, { "Merton", "Marley", "Sagan" }, { "rx", "w", "rw" } }};

            Console.WriteLine("{0, 10} | {1, 10} | {2, 10}", "Нікнейм", "Пароль", "Права доступу");
            Console.WriteLine("    ----------------------------------");
            for (int i = 0; i < rights.GetLength(1); i++)
            {
                Console.WriteLine("{0, 10} | {1, 10} | {2, 10}", rights[0, 0, i], rights[0,1,i], rights[0,2,i]);
            }
            Console.WriteLine();

            Console.Write("Ввведіть нікнейм: ");
            name = Console.ReadLine();

            for (int i = 0; i < rights.GetLength(1); i++)
            {
                if (name == rights[0, 0, i])
                {
                    Console.Write("Доброго дня, {0} введіть будь ласка ваш пароль: ", rights[0, 0, i]);
                    password = Console.ReadLine();
                    if (password == rights[0, 1, i])
                    {
                        Console.Write("Пароль введено вірно. {0}, ви маєте такі права щодо файлів: ", rights[0, 0, i]);
                        if (rights[0, 2, i].Contains("r"))
                        {
                            Console.Write("читання ");
                        }
                        if (rights[0, 2, i].Contains("x"))
                        {
                            Console.Write("виконання ");
                        }
                        if (rights[0, 2, i].Contains("w"))
                        {
                            Console.Write("запис ");
                        }
                    }
                    else
                    {
                        Console.Write("Пароль введено не вірно. Авторизацію провалено");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
