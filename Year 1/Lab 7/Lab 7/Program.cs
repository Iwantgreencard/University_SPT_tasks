using System;
using System.Text;
using System.Collections;

namespace Lab_7
{
    class Program
    {
        static void Main()
        {
            // Типові формальності
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Завдання 8 | Піскун Іван | 3 підгруппа";

            // Створюю два масива і одну чергу, для її заповнення
            int[] firstArray = new int[10];
            int[] secondArray = new int[10];
            Queue thirdArray = new Queue();

            bool match;

            // Вивожу текстові відомості
            Console.WriteLine("Отже, ця программа робить перевірку двох масивів \nЯкі заповнюються 10 рандомними числами від 1 до 10, і шукає там однакові числа");

            Random rand = new Random();

            // Заповнюю два масива випадковими числами
            for (int i = 0; i < 10; i++)
            {
                firstArray[i] = rand.Next(0, 10);
                secondArray[i] = rand.Next(0, 10);
            }

            // Вивожу перший масив і якщо є збіг з числом в другому масиві вивожу це число червоним шрифтом, записую це число в третій масив
            Console.Write("Перший масив: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                match = false;
                for (int r = 0; r < secondArray.Length; r++)
                {
                    if (firstArray[i] == secondArray[r])
                    {
                        match = true;
                        if (!thirdArray.Contains(firstArray[i]))
                        {
                            thirdArray.Enqueue(firstArray[i]);
                        }
                    }
                }
                if (match)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} ", firstArray[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("{0} ", firstArray[i]);
                }
            }

            // Вивожу другий масив
            Console.WriteLine();
            Console.Write("Другий масив: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                match = false;
                for (int j = 0; j < firstArray.Length; j++)
                {

                    if (firstArray[j] == secondArray[i])
                    {
                        match = true;
                    }
                }
                if (match)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} ", secondArray[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("{0} ", secondArray[i]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");

            // Вивожу третій елемент
            Console.Write("Третій масив, що складається з однакових елементів перших двох: ");
            foreach (Object num in thirdArray)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
