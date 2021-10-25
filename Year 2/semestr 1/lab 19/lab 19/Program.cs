using System;
using Voucher;
using System.Text;

namespace lab_19
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Піскун Іван // Лабораторна 19 // Варіант 20 // \"Туритисна путівка\"";

            // Створюємо 2 об'єкти класу Voucher_firts та 2 класи об'єкту Voucher_second
            Voucher_first vf1 = new Voucher_first();
            Voucher_first vf2 = new Voucher_first(31, "Україна", 1, "VIP", 1200);
            Voucher_second vs1 = new Voucher_second(44, "Гімалаї", 1, "VIP", 2400, "Туристична", 300);
            Voucher_second vs2 = new Voucher_second();
            // Заповнюємо інформацією першу путівку
            vf1.set_cost(3000);
            vf1.set_id(123);
            vf1.Period = 12;
            vf1.Servicing = "Bussines";
            vf1.Country = "Россія";
            // Заповнюємо інформацією четверту путівку
            vs2.Id = 12;
            vs2.Period = 2;
            vs2.Servicing = "Comfort";
            vs2.Cost = 3000;
            vs2.Country = "Америка";
            vs2.Transfer_cost = 1000;
            vs2.Category = "Робоча";

            // Виводимо на екран інформацію з об'єктів
            vf1.show_voucher();
            vf2.show_voucher();
            vs1.show_voucher();
            vs2.show_voucher();

            Console.ReadKey();

        }
    }
}
