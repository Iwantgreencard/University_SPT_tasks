using System;
using System.Text;

namespace Lab_8
{
    class Program
    {
        static void Main()
        {

            // Типові команди для зміни заголовку та кодування вихідних данних
            Console.Title = "Піскун Іван | 3 підгруппа | Варіант 11";
            Console.OutputEncoding = Encoding.UTF8;

            // Я вирішив використовувати числа типу double, бо добуток, який отримував використовуючи int дуже часто перебільшував навіть можливу довжину змінної типу long
            double dobytok = 1;
            double[] numbers = new double[100];
            int indexOfMax = 0;
            int indexOfMin = 0;
            Random rand = new Random();

            // Заповнюю масив псевдовипадковими числами
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Round(rand.NextDouble()*10, 1);
            }
            
            // Визначаю мінімальний та максимальний елементи масиву і записую їхній індекс
            double max = numbers[0];
            double min = numbers[0];
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    indexOfMax = i;
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    indexOfMin = i;
                }
            }
            // Вивожу згенеровані числа
            Console.WriteLine("Сгенеровані числа: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 8 == 0)
                {
                    Console.WriteLine();
                }
                if (numbers[i] == max && indexOfMax == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0, 6}", numbers[i]);
                    Console.ResetColor();
                }
                else if (numbers[i] == min && indexOfMin == i)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("{0, 6}", numbers[i]);
                    Console.ResetColor();
                }
                else if(indexOfMin > indexOfMax && i < indexOfMin && i > indexOfMax)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0, 6}", numbers[i]);
                    Console.ResetColor();
                }
                else if(indexOfMin < indexOfMax && i > indexOfMin && i < indexOfMax)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0, 6}", numbers[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("{0, 6}", numbers[i]);
                }
            }
            Console.WriteLine();

            // Вивожу мапу згенерованої таблиці
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Мінімальний елемент масиву");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Максимальний елемент масиву");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Елементи розташовані між макс. і мін.");
            Console.ResetColor();

            // Вивожу добуток чисел
            Console.WriteLine();
            Console.WriteLine("Добуток чисел, розташованих між максимальним та мінімальним числом: ");
            if (indexOfMin > indexOfMax)
            {
                for (var i = indexOfMax+1; i < indexOfMin; i++)
                {
                    dobytok *= numbers[i];
                    if ((i + 1) == indexOfMin)
                    {
                        Console.Write(numbers[i]);
                    }
                    else
                    {
                        Console.Write(numbers[i] + " * ");
                    }
                }
            }
            else if(indexOfMin < indexOfMax)
            {
                for (var i = indexOfMin+1; i < indexOfMax; i++)
                {
                    dobytok *= numbers[i];
                    if ((i + 1) == indexOfMax)
                    {
                        Console.Write(numbers[i]);
                    }
                    else
                    {
                        Console.Write(numbers[i] + " * ");
                    }
                }
            }

            Console.Write(" = " + dobytok);
            Console.WriteLine();
            Console.ReadKey()
        }
    }
}
