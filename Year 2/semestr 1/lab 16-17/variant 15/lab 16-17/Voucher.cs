using System;
using System.Collections.Generic;
using System.Text;

namespace lab_16_17
{
    class Voucher
    {
        // Поля
        private int id;
        private string country;
        private int period;
        private string servicing;
        private int cost;
        public string[] servicing_types = { "Bussines", "Comfort", "VIP" };

        // Властивості
        public int Id {
            get { return id; }
            set { this.id = value; }
        }
        public string Country
        {
            get { return country; }
            set { this.country = value; }
        }
        public int Period
        {
            get { return period; }
            set { this.period = value; }
        }
        public string Servicing
        {
            get { return servicing; }
            set { this.servicing = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { this.cost = value; }
        }

        // Конструктори
        public Voucher()
        {

        }
        public Voucher(int id, string country)
        {
            this.id = id;
            this.country = country;
            this.servicing = "Bussines";
        }
        public Voucher(string country, int period) {
            this.id = id;
            this.country = country;
            this.period = period;
            this.servicing = "Bussines";
        }
        public Voucher(string country, int period, string servicicng)
        {
            this.id = id;
            this.country = country;
            this.period = period;
            this.servicing = servicicng;
        }
        public Voucher(int id, string country, int period, string servicicng, int cost)
        {
            this.id = id;
            this.country = country;
            this.period = period;
            this.servicing = servicicng;
            this.cost = cost;
        }

        // Методи
        public void set_id(int id)
        {
            this.id = id;
        }
        public void change_country(string country)
        {
            this.country = country;
        }
        public void change_period(int period)
        {
            int gap = 0;
            bool minus = false;
            gap = this.period - period;
            if (period != 0)
            {
                if (gap > 0)
                {
                    minus = true;
                }
                gap = Math.Abs(gap);
                for (int i = 0; i < gap; i++)
                {
                    if (minus)
                    {
                        this.cost -= (this.cost / 100) * 10;
                    }
                    else
                    {
                        this.cost += (this.cost / 100) * 10;
                    }
                }
                Console.WriteLine("При змінні терміну путівки, в разі збільшення, ви доплачуєте 10 відсотків від ціни за кожний настуний день, " +
                "так само і в разі зменшення терміну, за кожний день ціна путівки зменшується на 10 відсотків");
            }
            else
            {
                this.cost = 0;
                Console.WriteLine($"Вашу поїздку відмінено");
            }
            Console.WriteLine($"Термін поїздки змінено з {this.period} днів(-я) на {period} днів(-я)");
            Console.WriteLine($"Нова ціна - {this.cost}");
            this.period = period;
        }
        public void change_servicing(string servicing)
        {
            int service_now_number = 0, service_repclacing_number = 0;
            string message = "";
            int gap = 0;
            if (this.servicing != servicing)
            {
                for (int i = 0; i < servicing_types.Length; i++)
                {
                    if (servicing == servicing_types[i])
                    {
                        service_repclacing_number = i;
                    }
                    else if (this.servicing == servicing_types[i])
                    {
                        service_now_number = i;
                    }
                }
                switch (service_now_number - service_repclacing_number)
                {
                    case 1:
                        gap = -30;
                        break;
                    case 0:
                        gap = -60;
                        break;
                    case -1:
                        gap = 30;
                        break;
                    case -2:
                        gap = 60;
                        break;
                }
                this.cost += (this.cost / 100) * gap;
                message = $"Ваш план обслуговування буде змінено з {this.servicing} на {servicing}. Нова ціна путівки - {this.cost} грн.({gap}%)";
            }
            Console.WriteLine("----------");
            Console.WriteLine(message);
            this.servicing = servicing;
        }
        public void set_cost(int cost)
        {
            this.cost = cost;
        }
        public int one_day_cost()
        {
            int day_cost = 0;
            day_cost = this.cost / this.period;
            return day_cost;
        }
        public void show_voucher()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine($"█ Номер поїздки:      {this.id}                     ");
            Console.WriteLine($"█ Країна:             {this.country}                ");
            Console.WriteLine($"█ Термін:             {this.period} днів(-я,-і,-нь) ");
            Console.WriteLine($"█ Тип обслуговування: {this.servicing}              ");
            Console.WriteLine($"█ Ціна:               {this.cost} грн.              ");
            Console.WriteLine($"█ Ціна за один день:  {this.one_day_cost()} грн.    ");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        }
        public static void search_by_id(Voucher[] vouchers, int id)
        {
            bool found = false;
            for (int i = 0; i < vouchers.Length; i++)
            {
                if (vouchers[i].Id == id)
                {
                    found = true;
                    Console.WriteLine($"Квиток з номером {id} знайдено");
                    vouchers[i].show_voucher();
                }
            }
            if (!found)
            {
                Console.WriteLine($"Квиток з номером {id} не знайдено в базі");
            }
        }
        public static void search_by_country(Voucher[] vouchers, string country)
        {
            bool found = false;
            for (int i = 0; i < vouchers.Length; i++)
            {
                if (vouchers[i].Country == country)
                {
                    found = true;
                    Console.WriteLine($"Квиток з країною {country} знайдено");
                    vouchers[i].show_voucher();
                }
            }
            if (!found)
            {
                Console.WriteLine($"Квиток з країною {country} не знайдено в базі");
            }
        }
        public static void search_by_servicing(Voucher[] vouchers, string servicing)
        {
            bool found = false;
            for (int i = 0; i < vouchers.Length; i++)
            {
                if (vouchers[i].Servicing == servicing)
                {
                    found = true;
                    Console.WriteLine($"Квиток типом обслуговування {servicing} знайдено");
                    vouchers[i].show_voucher();
                }
            }
            if (!found)
            {
                Console.WriteLine($"Квиток з номером {servicing} не знайдено в базі");
            }
        }
        public static void search_by_cost(Voucher[] vouchers, int cost)
        {
            bool found = false;
            for (int i = 0; i < vouchers.Length; i++)
            {
                if (vouchers[i].Cost == cost)
                {
                    found = true;
                    Console.WriteLine($"Квиток, з ціною {cost} грн, знайдено");
                    vouchers[i].show_voucher();
                }
            }
            if (!found)
            {
                Console.WriteLine($"Квиток, з ціною {cost} грн, не знайдено в базі");
            }
        }
        public static void search_by_period(Voucher[] vouchers, int period)
        {
            bool found = false;
            for (int i = 0; i < vouchers.Length; i++)
            {
                if (vouchers[i].Period == period)
                {
                    found = true;
                    Console.WriteLine($"Квиток, з періодом поїздки {period} днів, знайдено");
                    vouchers[i].show_voucher();
                }
            }
            if (!found)
            {
                Console.WriteLine($"Квиток, з періодом поїздки {period} днів, не знайдено в базі");
            }
        }
        public static bool operator ==(Voucher first, Voucher second){
            if (first.cost == second.cost &&
               first.country == second.country &&
               first.id == second.id &&
               first.period == second.period &&
               first.servicing == second.servicing)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Voucher first, Voucher second)
        {
            if (first.cost != second.cost ||
               first.country != second.country ||
               first.id != second.id ||
               first.period != second.period ||
               first.servicing != second.servicing)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
