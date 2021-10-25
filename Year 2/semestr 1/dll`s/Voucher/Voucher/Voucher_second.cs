using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucher
{
    public class Voucher_second : Voucher_first
    {
        private string category;
        private int transfer_cost;

        public Voucher_second()
        {

        }
        public Voucher_second(int id, string country, int period, string servicicng, int cost, string category, int transfer_cost)
        {
            this.id = id;
            this.country = country;
            this.period = period;
            this.servicing = servicicng;
            this.cost = cost;
            this.category = category;
            this.transfer_cost = transfer_cost;
        }
        public string Category {
            get { return category; }
            set { category = value; }
        }
        public int Transfer_cost
        {
            get { return transfer_cost; }
            set { transfer_cost = value; }
        }


        public override void show_voucher()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine($"█ Номер поїздки:      {this.id}                     ");
            Console.WriteLine($"█ Країна:             {this.country}                ");
            Console.WriteLine($"█ Термін:             {this.period} днів(-я,-і,-нь) ");
            Console.WriteLine($"█ Тип обслуговування: {this.servicing}              ");
            Console.WriteLine($"█ Ціна:               {this.cost} грн.              ");
            Console.WriteLine($"█ Ціна за один день:  {this.one_day_cost()} грн.    ");
            Console.WriteLine($"█ Категорія:          {this.category}    ");
            Console.WriteLine($"█ Вартість трансферу: {this.transfer_cost} грн.    ");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        }
        public void set_category(string category)
        {
            this.category = category;
        }
        public void set_transfer_cost(int transfer_cost)
        {
            this.transfer_cost = transfer_cost;
        }
    }
}
