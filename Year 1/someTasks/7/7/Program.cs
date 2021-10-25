using System;

namespace _7
{
    class Program
    {
        static void Main()
        {
            // Створюю три змiннi R - радiус, L - довжина, V - об'єм
            Double R, L, V;
            // Для зручності запису присвоюю перемінній Pi значення Math.PI
            Double Pi = Math.PI;

            // Прошу користувача ввести радіус кола
            Console.Write("Будь-ласка, введiть радiус кола: ");
            R = Convert.ToInt32(Console.ReadLine());

            // Проводимо обчислення
            L = 2 * Pi * R;
            V = Pi * (R * R);

            // Виводимо результати в консоль округливши значення довжини та об'єма за допомогою Math.Round
            Console.WriteLine("Тобто радiус кола - " + R + ". Його довжина - " + Math.Round(L, 2) + ". Та його об'єм - " + Math.Round(V, 2));
            Console.ReadKey();
        }
    }
}
