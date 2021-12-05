using System;

namespace _2_3
{
    class Program
    {
        static void Main()
        {
            // Створюю 3 числові перемінні
            double y, x, a;
            // Виводимо в консоль пояснення того, що робить ця программа
            Console.WriteLine("Ця программа обчисляє значення y та x");
            Console.WriteLine("В рiвняннi: y = 6x + (56a/3), x = 8.5a");
            // В завданні 1 я пояснював що робить WriteLine, метод Write робить те саме, тільки курсор вводу залишається в тому же рядку
            Console.Write("Будь-ласка введiть значення а для розвязку: ");
            // Зчитуємо те що ввів користувач і конвертуємо його за допомогою методу Parse в double
            a = Double.Parse(Console.ReadLine());
            // проводиму обчислення
            x = 8.5 * a;
            y = 6 * x + ((56*a)/3);
            // цей код знизу я зробив тільки того, щоб можна було через меню "Откладка" відслідити "Точку останова"
            a = a;

            // виводимо значення a, x, y в консоль
            Console.WriteLine("a = " + a);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.ReadKey();
        }
    }
}
