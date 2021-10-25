using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            // Тут я ініціалізую числові змінні і присвоюю їм значення, що дані в моєму варіанті. Та перемінні для запису в них обчислених значень
            double x = 0.26, 
                y = 0.82,
                z = 0.16, 
                a = 5.7, 
                b = 4.8, v, n, d, L;
            // Змінію заголовок консольного вікна на особисту інформацію
            Console.Title = ("Піскун Іван | Варіант - " + (2 + 9) + " | Підгрупа 3");

            // Вивожу на екран текстову інформацію про те, що робить программа
            Console.WriteLine("Ця програма знаходить 4 змiннi за формулами: ");
            Console.WriteLine("--------------------");
            Console.WriteLine("v = √a + √(b + e^ax)");
            Console.WriteLine("n = (ln^3(10 + e^(-bx)))/b+x");
            Console.WriteLine("d = (x + (y/x+4)) / y(x-2) + (1/x^2+4)");
            Console.WriteLine("L = (arctg (z/2))^3");
            Console.WriteLine("--------------------");
            Console.WriteLine("Вiдомi змiннi: x = 0.26; y = 0.82; z = 0.16; a = 5.7; b = 4.8");
            Console.WriteLine("--------------------");
            // Виконую математичні розрахунки згідно формул вище, та записую результат ініційовані раніше змінні
            v = Math.Sqrt(a) + Math.Sqrt(b + Math.Exp(a*x));
            n = Math.Pow(Math.Log(10 + Math.Exp(-b * x)), 3) / (b + x);
            d = (x + (y / (x + 4))) / (y * (x - 2) + (1/(x*x+4)));
            L = Math.Pow(Math.Atan(z / 2), 3);
            Console.WriteLine("Для того, щоб почати обчислення натиснiть Enter");
            Console.ReadKey();
            // Вивожу результат обчислень на екран
            Console.WriteLine("--------------------");
            Console.WriteLine("v = {0:0.00} | n = {1:0.00} | d = {2:0.00} | L = {3:0.00000000}", v, n, d, L);
            Console.ReadKey();
        }
    }
}
