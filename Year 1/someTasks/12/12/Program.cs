﻿using System;

namespace _12
{
    class Program
    {
        static void Main()
        {
            int a, b, c, d, e, f;
            // Просимо користувача ввести суму копійок для розподілу
            Console.Write("Введiть кiлькiсть копiйок для розподiлу: ");
            a = Int32.Parse(Console.ReadLine());

            // Ділимо суму на 50, щоб дізнатись скільки таких монет потрібно видати та віднімаєм їх від загальної суми
            b = a / 50;
            a = a - (50 * b);

            // Ділимо остаток на 25, щоб дізнатись скільки таких монет потрібно видати та віднімаєм їх від остатку
            c = a / 25;
            a = a - (25 * c);

            // Ділимо остаток на 10, щоб дізнатись скільки таких монет потрібно видати та віднімаєм їх від остатку
            d = a / 10;
            a = a - (10 * d);

            // Ділимо остаток на 5, щоб дізнатись скільки таких монет потрібно видати та віднімаєм їх від остатку
            e = a / 5;
            a = a - (5 * e);

            // Ділимо остаток на 1, щоб дізнатись скільки таких монет потрібно видати та віднімаєм їх від остатку
            f = a / 1;
            a = a - f;
            // Виводимо результат в консоль
            Console.WriteLine("кiлькiсть монет номiналом в 50 - " + b);
            Console.WriteLine("кiлькiсть монет номiналом в 25 - " + c);
            Console.WriteLine("кiлькiсть монет номiналом в 10 - " + d);
            Console.WriteLine("кiлькiсть монет номiналом в 5 - " + e);
            Console.WriteLine("кiлькiсть монет номiналом в 1 - " + f);

            Console.ReadKey();
        }
    }
}
